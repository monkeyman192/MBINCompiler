using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Xml;

using libMBIN.Models.Structs;
using System.Runtime.InteropServices;

namespace libMBIN.Models
{
    public class NMSTemplate
    {
        internal static readonly Dictionary<string, Type> NMSTemplateMap = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(NMSTemplate))
                .ToDictionary(t => t.Name);

        internal static bool PrintToDebug = false; // disable this when doing things in debug mode (tests etc) for a nice speedup

        public static NMSTemplate TemplateFromName(string templateName)
        {
            Type type;
            if (!NMSTemplateMap.TryGetValue(templateName, out type))
                return null; // Template type doesn't exist

            return Activator.CreateInstance(type) as NMSTemplate;
        }

        public int GetDataSize()
        {
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                var addt = new List<Tuple<long, object>>();
                int addtIdx = 0;

                var prevPTD = PrintToDebug;
                PrintToDebug = false;
                AppendToWriter(bw, ref addt, ref addtIdx, GetType());
                PrintToDebug = prevPTD;

                return ms.ToArray().Length;
            }
        }

        public static int GetTemplateDataSize(string templateName)
        {
            var template = TemplateFromName(templateName);
            if (template == null)
                return 0;

            return template.GetDataSize();
        }

        public static object DeserializeValue(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo, NMSTemplate parent)
        {
            var template = parent.CustomDeserialize(reader, field, settings, templatePosition, fieldInfo);
            if (template != null)
                return template;

            var fieldType = field.Name;
            switch (fieldType)
            {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;
                    MarshalAsAttribute legacySettings = fieldInfo.GetCustomAttribute<MarshalAsAttribute>();
                    if (legacySettings != null)
                    {
                        size = legacySettings.SizeConst;
                    }

                    if (fieldType == "String")
                    {
                        // reader.Align(0x4, templatePosition);
                        var str = reader.ReadString(Encoding.UTF8, size, true);
                        return str;
                    }
                    else
                    {
                        var str = reader.ReadBytes(size);
                        return str;
                    }
                case "Single":
                    reader.Align(4, 0);
                    return reader.ReadSingle();
                case "Boolean":
                    return reader.ReadByte() != 0;
                case "Int16":
                case "UInt16":
                    reader.Align(2, 0);
                    return fieldType == "Int16" ? (object)reader.ReadInt16() : (object)reader.ReadUInt16();
                case "Int32":
                case "UInt32":
                    reader.Align(4, 0);
                    return fieldType == "Int32" ? (object)reader.ReadInt32() : (object)reader.ReadUInt32();
                case "Int64":
                case "UInt64":
                    reader.Align(8, 0);
                    return fieldType == "Int64" ? (object)reader.ReadInt64() : (object)reader.ReadUInt64();
                case "List`1":
                    reader.Align(8, 0);
                    if (field.IsGenericType && field.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        Type itemType = field.GetGenericArguments()[0];
                        if (itemType == typeof(NMSTemplate))
                            return DeserializeGenericList(reader, templatePosition, parent);
                        else
                        {
                            // todo: get rid of this nastiness
                            MethodInfo method = typeof(NMSTemplate).GetMethod("DeserializeList", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                                                         .MakeGenericMethod(new Type[] { itemType });
                            var list = method.Invoke(null, new object[] { reader, fieldInfo, settings, templatePosition, parent });
                            return list;
                        }
                    }
                    return null;
                case "NMSTemplate":
                    reader.Align(8, 0);
                    long startPos = reader.BaseStream.Position;
                    long offset = reader.ReadInt64();
                    string name = reader.ReadString(Encoding.ASCII, 0x40, true);
                    long endPos = reader.BaseStream.Position;
                    NMSTemplate val = null;
                    if (offset != 0 && !String.IsNullOrEmpty(name))
                    {
                        reader.BaseStream.Position = startPos + offset;
                        val = DeserializeBinaryTemplate(reader, name);
                        if (val == null)
                            throw new Exception("Failed to deserialize template " + name + "!");
                    }
                    reader.BaseStream.Position = endPos;
                    return val;
                default:
                    if (fieldType == "Colour") // unsure if this is needed?
                        reader.Align(0x10, 0);
					if (fieldType == "VariableStringSize" || fieldType == "GcRewardProduct")
						reader.Align(0x4, 0);
                    // todo: align for VariableSizeString?
                    if (field.IsArray)
                    {
                        var arrayType = field.GetElementType();
                        Array array = Array.CreateInstance(arrayType, settings.Size);
                        for (int i = 0; i < settings.Size; ++i)
                        {
                            array.SetValue(DeserializeValue(reader, field.GetElementType(), settings, templatePosition, fieldInfo, parent), i);
                        }
                        return array;
                    }
                    else
                    {
                        var data = DeserializeBinaryTemplate(reader, fieldType);
                        return data;
                    }
            }
        }

        public static NMSTemplate DeserializeBinaryTemplate(BinaryReader reader, string templateName)
        {
            if (templateName.StartsWith("c") && templateName.Length > 1)
                templateName = templateName.Substring(1);

            NMSTemplate obj = TemplateFromName(templateName);
            
            /*using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"T:\mbincompiler_debug.txt", true))
            {
                file.WriteLine("Deserializing Template: " + templateName);
            }*/

            //Console.WriteLine("Gk Hack: " + "Deserializing Template: " + templateName);
            
            if (obj == null)
                return null;

            long templatePosition = reader.BaseStream.Position;
            if(PrintToDebug) Debug.WriteLine($"{templateName} position: 0x{templatePosition:X}");

            if (templateName == "VariableSizeString")
            {
                long stringPos = reader.ReadInt64();
                int stringLength = reader.ReadInt32();
                int unkC = reader.ReadInt32();
                reader.BaseStream.Position = templatePosition + stringPos;
                ((VariableSizeString)obj).Value = reader.ReadString(Encoding.UTF8, stringLength).TrimEnd('\x00');
                reader.BaseStream.Position = templatePosition + 0x10;
                return obj;
            }

            var type = obj.GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                field.SetValue(obj, DeserializeValue(reader, field.FieldType, settings, templatePosition, field, obj));
                //Console.WriteLine("Gk Hack: " + templateName + " Deserialized Value: " + field.Name + " value: " + field.GetValue(obj));
                //Console.WriteLine($"{templateName} position: 0x{reader.BaseStream.Position:X}");
                /*using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"D:\mbincompiler_debug.txt", true))
                {
                    file.WriteLine(" Deserialized Value: " + field.Name + " value: " + field.GetValue(obj));
                    file.WriteLine($"{templateName} position: 0x{reader.BaseStream.Position:X}");
                }*/
            }

            
            obj.FinishDeserialize();

            if (PrintToDebug) Debug.WriteLine($"{templateName} end position: 0x{reader.BaseStream.Position:X}");

            return obj;
        }

        public static List<NMSTemplate> DeserializeGenericList(BinaryReader reader, long templateStartOffset, NMSTemplate parent)
        {
            long listPosition = reader.BaseStream.Position;
            if (PrintToDebug) Debug.WriteLine($"DeserializeGenericList start 0x{listPosition:X}");

            long templateNamesOffset = reader.ReadInt64();
            int numTemplates = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if ((listMagic & 0xFF) != 1)
                throw new Exception($"Invalid generic list read, magic {listMagic:X8} expected xxxxxx01");

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + templateNamesOffset;
            var list = new List<NMSTemplate>();
            if (numTemplates > 0)
            {
                //Dictionary<long, string> templates = new Dictionary<long, string>();
                List < KeyValuePair < long, String >> templates = new List<KeyValuePair<long, String>>();
                for (int i = 0; i < numTemplates; i++)
                {
                    long nameOffset = reader.BaseStream.Position;
                    long templateOffset = reader.ReadInt64();
                    var name = reader.ReadString(Encoding.UTF8, 0x40, true);

                    if (templateOffset == 0)
                    {
                        // sometimes there are lists which have n values, but less than n actual structs in them. We replace the empty thing with EmptyNode
                        templates.Add(new KeyValuePair<long, string>(nameOffset + templateOffset, "EmptyNode"));
                    }
                    else
                    {
                        templates.Add(new KeyValuePair<long, string>(nameOffset + templateOffset, name));
                    }
                }

                long pos = reader.BaseStream.Position;

                foreach (KeyValuePair<long, string> templateInfo in templates)
                {
                    reader.BaseStream.Position = templateInfo.Key;
                    var template = DeserializeBinaryTemplate(reader, templateInfo.Value);
                    if (template == null)
                        throw new Exception($"Failed to deserialize template {templateInfo.Value}!");

                    list.Add(template);
                }
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x8, 0);

            return list;
        }

        public static List<T> DeserializeList<T>(BinaryReader reader, FieldInfo field, NMSAttribute settings, long templateStartOffset, NMSTemplate parent)
        {
            long listPosition = reader.BaseStream.Position;
            if (PrintToDebug) Debug.WriteLine($"DeserializeList start 0x{listPosition:X}");

            long listStartOffset = reader.ReadInt64();
            int numEntries = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if ((listMagic & 0xFF) != 1)
                throw new Exception($"Invalid list read, magic {listMagic:X8} expected xxxxxx01");

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + listStartOffset;
            var list = new List<T>();
            for (int i = 0; i < numEntries; i++)
            {
                // todo: get rid of DeserializeGenericList? this seems like it would work fine with List<NMSTemplate>
                var template = DeserializeValue(reader, field.FieldType.GetGenericArguments()[0], settings, templateStartOffset, field, parent);
                if (template == null)
                    throw new Exception($"Failed to deserialize type {typeof(T).Name}!");
                if(template.GetType().BaseType == typeof(NMSTemplate))
                {
                    ((NMSTemplate)template).FinishDeserialize();
                }
                list.Add((T)template);
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x8, 0);

            return list;
        }

        public void SerializeValue(BinaryWriter writer, Type fieldType, object fieldData, NMSAttribute settings, FieldInfo field, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex, int structLength = 0, UInt32 listEnding = 0xAAAAAA01)
        {
            if (CustomSerialize(writer, fieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex))
                return;
            switch (fieldType.Name)
            {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;
                    MarshalAsAttribute legacySettings = field?.GetCustomAttribute<MarshalAsAttribute>();
                    if (legacySettings != null)
                    {
                        size = legacySettings.SizeConst;
                    }

                    if (fieldType.Name == "String")
                    {
                        writer.WriteString((string)fieldData, Encoding.UTF8, size);
                    }
                    else
                    {
                        byte[] bytes = (byte[])fieldData;
                        Array.Resize(ref bytes, size);
                        writer.Write(bytes);
                    }
                    break;
                case "Byte":
                    writer.Write((Byte)fieldData);
                    break;
                case "Single":
                    writer.Align(4, 0);
                    writer.Write((Single)fieldData);
                    break;
                case "Boolean":
                    var value = (bool)fieldData;
                    writer.Write(value ? (byte)1 : (byte)0);
                    break;
                case "Int16":
                case "UInt16":
                    writer.Align(2, 0);
                    if (fieldType.Name == "Int16")
                        writer.Write((Int16)fieldData);
                    else
                        writer.Write((UInt16)fieldData);
                    break;
                case "Int32":
                case "UInt32":
                    writer.Align(4, 0);
                    if (fieldType.Name == "Int32")
                        writer.Write((Int32)fieldData);
                    else
                        writer.Write((UInt32)fieldData);
                    break;
                case "Int64":
                case "UInt64":
                    writer.Align(8, 0);
                    if (fieldType.Name == "Int64")
                        writer.Write((Int64)fieldData);
                    else
                        writer.Write((UInt64)fieldData);
                    break;
                case "List`1":
                    writer.Align(8, 0);
                    if (field != null && field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        // write empty list header
                        long listPos = writer.BaseStream.Position;
                        writer.Write((Int64)0); // listPosition
                        writer.Write((Int32)0); // listCount
                        writer.Write(listEnding);

                        var data = new Tuple<long, object>( listPos, (IList) fieldData );
                        if (additionalData.Count == additionalData.Capacity) {
                            additionalData.Add( data );
                        } else {
                            additionalData.Insert( addtDataIndex, data );
                        }
                        addtDataIndex++;
                    }

                    break;
                case "EmptyNode":
                    break;

                case "NMSTemplate":
                    writer.Align(8, 0);
                    long refPos = writer.BaseStream.Position;
                    
                    var template = (NMSTemplate)fieldData;
                    if (template == null || template.GetType().Name == "EmptyNode")
                    {
                        writer.Write((Int64)0); // listPosition
                        writer.WriteString("", Encoding.UTF8, 0x40);
                    }
                    else
                    {
                        writer.Write((Int64)0);      // default value to be overridden later anyway
                        writer.WriteString("c" + template.GetType().Name, Encoding.UTF8, 0x40);
                        var data = new Tuple<long, object>( refPos, template );
                        if (additionalData.Count == additionalData.Capacity) {
                            additionalData.Add( data );
                        } else {
                            additionalData.Insert(addtDataIndex++, data );
                        }

                    }
                    break;
                case "Dictionary`2":
                    // have something defined so that it just ignores it
                    break;
                default:
                    if (fieldType.Name == "Colour") // unsure if this is needed?
                        writer.Align(0x10, 0);

                    // todo: align for VariableSizeString?
                    if (fieldType.Name == "VariableSizeString")
                    {
                        // write empty DynamicString header
                        long fieldPos = writer.BaseStream.Position;
                        writer.Write((Int64)0); // listPosition
                        writer.Write((Int32)0); // listCount
                        writer.Write(listEnding);

                        var fieldValue = (VariableSizeString)fieldData;
                        additionalData.Insert(addtDataIndex++, new Tuple<long, object>(fieldPos, fieldValue));
                    }
                    else if (fieldType.IsArray)
                    {
                        var arrayType = fieldType.GetElementType();
                        Array array = (Array)fieldData;
                        if (array == null)
                            array = Array.CreateInstance(arrayType, (int)settings.Size);

                        foreach (var obj in array)
                        {
                            var realObj = obj;
                            if (realObj == null)
                                realObj = Activator.CreateInstance(arrayType);

                            SerializeValue(writer, realObj.GetType(), realObj, settings, field, ref additionalData, ref addtDataIndex);
                        }
                    }
                    else
                    {
                        if (fieldType.BaseType == typeof(NMSTemplate))
                        {
                            var realData = (NMSTemplate)fieldData;
                            if (realData == null)
                                realData = (NMSTemplate)Activator.CreateInstance(fieldType);

                            realData.AppendToWriter(writer, ref additionalData, ref addtDataIndex, GetType(), listEnding);
                        }
                        else
                            throw new Exception($"[C] Unknown type {fieldType} not NMSTemplate" + (field != null ? $" for {field.Name}" : ""));
                    }

                    break;
            }
        }

        public void AppendToWriter(BinaryWriter writer, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex, Type parent, UInt32 listEnding = 0xAAAAAA01)
        {
            long templatePosition = writer.BaseStream.Position;
            if (PrintToDebug) Debug.WriteLine($"[C] writing {GetType().Name} to offset 0x{templatePosition:X} (parent: {parent.Name})");
            var type = GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            // todo: remove struct length?? Not needed any more I think...
            NMSAttribute attribute = type.GetCustomAttribute<NMSAttribute>();
            // If the class has no size associate with it, just ignore it
            int structLength = (attribute != null) ? attribute.Size : 0;

            //var entryOffsetNamePairs = new Dictionary<long, string>();
            //List<KeyValuePair<long, String>> entryOffsetNamePairs = new List<KeyValuePair<long, String>>();

            if (type.Name != "EmptyNode")
            {
                foreach (var field in fields)
                {
                    var fieldAddr = writer.BaseStream.Position - templatePosition;
                    var fieldData = field.GetValue(this);
                    if (field.FieldType.Name == "NMSTemplate")
                    {
                        NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                        SerializeValue(writer, field.FieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex, structLength);
                    }
                    else
                    {
                        NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                        SerializeValue(writer, field.FieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex, structLength);
                    }
                }
            }
            else
            {
                SerializeValue(writer, type, null, null, null, ref additionalData, ref addtDataIndex, structLength);
            }
            /*foreach (var entry in entryOffsetNamePairs)
            {
                Console.WriteLine(entry);
                var template = TemplateFromName(entry.Value);
                //var template = (NMSTemplate)entry.Value;
                template.AppendToWriter(writer, ref additionalData, ref addtDataIndex, GetType());
            }*/
        }

        public void SerializeGenericList(BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex, UInt32 listEnding)
        // This serialises a List of NMSTemplate objects
        {
            writer.Align(0x8, 0);       // Make sure that all c~ names are offset at 0x8.
            long listPosition = writer.BaseStream.Position;

            if (PrintToDebug) Debug.WriteLine($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if (list.Count > 0)
            {
                //Console.WriteLine($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");
                writer.Write(listPosition - listHeaderPosition);
            }
            else
                writer.Write((long)0); // lists with 0 entries have offset set to 0

            writer.Write((Int32)list.Count);
            writer.Write(listEnding);

            // reserve space for list offsets+names
            writer.BaseStream.Position = listPosition;
            writer.Write(new byte[list.Count * 0x48]);              // this seems to need to be reserved even if there are no elements (check?)

            int addtDataIndexThis = 0;

            //var entryOffsetNamePairs = new Dictionary<long, string>();
            List<KeyValuePair<long, String>> entryOffsetNamePairs = new List<KeyValuePair<long, String>>();
            foreach (var entry in list)
            {
                int alignment = entry.GetType().GetCustomAttribute<NMSAttribute>()?.Alignment ?? 0x4;

                writer.Align(alignment, 0);
                //Console.WriteLine($"pos 0x{writer.BaseStream.Position:X}");
                //Console.WriteLine(entry.GetType().Name);
                entryOffsetNamePairs.Add(new KeyValuePair<long, string>(writer.BaseStream.Position, entry.GetType().Name));

                var template = (NMSTemplate)entry;
                var listObjects = new List <Tuple<long, object>>();     // new list of objects so that this data is serialised first
                var addtData = new Dictionary<long, object>();
                if (PrintToDebug) Debug.WriteLine($"[C] writing {template.GetType().Name} to offset 0x{writer.BaseStream.Position:X}");
                //Console.WriteLine($"[C] writing {template.GetType().Name} to offset 0x{writer.BaseStream.Position:X}");
                // pass the new listObject object in place of additionalData so that this branch is serialised before the whole layer
                template.AppendToWriter(writer, ref listObjects, ref addtDataIndexThis, GetType());
                for (int i = 0; i < listObjects.Count; i++)
                {
                    var data = listObjects[i];
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates
                    writer.Align(0x8, 0); // todo: check if this alignment is correct
                    long origPos = writer.BaseStream.Position;
                    if (data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof(List<>))
                    {
                        //Console.WriteLine("blahblah");
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                        
                        if (itemType == typeof(NMSTemplate))
                        {
                            SerializeGenericList(writer, (IList)data.Item2, data.Item1, ref listObjects, i + 1, listEnding);
                        }
                        else
                        {
                            SerializeList(writer, (IList)data.Item2, data.Item1, ref listObjects, i + 1, listEnding);
                        }
                    }
                    else
                    {
                        //Console.WriteLine("this is it!!!");
                        //Console.WriteLine($"0x{origPos:X}");
                        // first, write the correct offset at the correct location
                        long headerPos = data.Item1;
                        writer.BaseStream.Position = headerPos;
                        long offset = origPos - headerPos;
                        writer.Write(offset);
                        writer.BaseStream.Position = origPos;
                        var GenericObject = data.Item2;
                        int newDataIndex = i+1;
                        SerializeValue(writer, GenericObject.GetType(), GenericObject, null, null, ref listObjects, ref newDataIndex);
                    }
                }
                
            }

            long dataEndOffset = writer.BaseStream.Position;

            writer.BaseStream.Position = listPosition;
            foreach (KeyValuePair<long, string> kvp in entryOffsetNamePairs)
            {
                // Iterate through the list headers and write the correct data
                if (kvp.Value != "EmptyNode")
                {
                    //long tempPos = writer.BaseStream.Position;
                    writer.Align(0x8, 0);
                    //long correction = writer.BaseStream.Position - tempPos;
                    // in this case, we have an actual non-empty header.
                    long position = writer.BaseStream.Position;
                    long offset = kvp.Key - position; // get offset of this entry from the current offset
                    writer.Write(offset);
                    //Console.WriteLine(kvp.Value);
                    writer.WriteString("c" + kvp.Value, Encoding.UTF8, 0x40);
                    //Console.WriteLine(kvp.Value);
                    //Console.WriteLine(offset);
                }

                else
                {
                    // this is called when the header 0x48 bytes is empty because it is an empty node.
                    writer.WriteString("", Encoding.UTF8, 0x48);
                }
            }

            writer.BaseStream.Position = dataEndOffset;
        }

        public void SerializeList(BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex, UInt32 ListEnding = (UInt32)0xAAAAAA01)
        {
            // first thing we want to do is align the writer with the location of the first element of the list
            if (list.Count != 0)
            {
                // if the class has no alignment value associated with it, set a default value
                int alignment = alignment = list[0].GetType().GetCustomAttribute<NMSAttribute>()?.Alignment ?? 0x8;

                writer.Align(alignment, 0);
            }

            long listPosition = writer.BaseStream.Position;
            if (PrintToDebug) Debug.WriteLine($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if (list.Count > 0)
                writer.Write(listPosition - listHeaderPosition);
            else
                writer.Write((long)0); // lists with 0 entries have offset set to 0
            writer.Write((Int32)list.Count);
            writer.Write(ListEnding);       // this is where the 4bytes at the end of a list are written

            writer.BaseStream.Position = listPosition;

            var listObjects = new List<Tuple<long, object>>();     // new list of objects so that this data is serialised first

            int addtDataIndexThis = addtDataIndex;

            foreach (var entry in list)
            {
                if (PrintToDebug) Debug.WriteLine($"[C] writing {entry.GetType().Name} to offset 0x{writer.BaseStream.Position:X}");
                SerializeValue(writer, entry.GetType(), entry, null, null, ref additionalData, ref addtDataIndexThis);
            }

            if (list.GetType().GetGenericArguments()[0] == typeof(TkAnimNodeFrameData))
            {
                writer.Write(0xFEFEFEFEFEFEFEFE);
            }
        }

        public byte[] SerializeBytes()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.ASCII))
            {
                var additionalData = new List<Tuple<long, object>>();

                UInt32 listEnding = 0xAAAAAA01;

                if (GetType() == typeof(TkAnimMetadata))
                {
                    listEnding = 0xFEFEFE01;
                }

                int i = 0;
                // write primary template + any embedded templates
                AppendToWriter(writer, ref additionalData, ref i, GetType(), listEnding);

                // now write values of lists etc
                for (i = 0; i < additionalData.Count; i++)
                {
                    var data = additionalData[i];
                    //Console.WriteLine($"Current i: {i}");
                    //Console.WriteLine(data);
                    //System.Threading.Thread.Sleep(1000);
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates
                    long origPos = writer.BaseStream.Position;
                    //Console.WriteLine(origPos);
                    //Console.WriteLine(data.Item2.GetType());
                    //Console.WriteLine(data.Item2.GetType());
                    //Console.WriteLine(typeof(GcRewardSubstance));

                    // get the custom alignment value from the class if it has one
                    // If the class has no alignment value associated with it, just set as default value of 4
                    int alignment = data.Item2.GetType().GetCustomAttribute<NMSAttribute>()?.Alignment ?? 0x4;

                    // if we have an empty list we do not want to do alignment otherwise it can put off other things
                    if (data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof( List<> )) {
                        IList lst = (IList) data.Item2;
                        if (lst.Count != 0) writer.Align( alignment, 0 );
                    } else {
                        writer.Align( alignment, 0 );
                    }

                    //Console.WriteLine("hi");

                    if (data.Item2.GetType() == typeof(VariableSizeString))
                    {
                        //Console.WriteLine(alignment);
                        writer.BaseStream.Position = origPos; // no alignment for dynamicstrings

                        var str = (VariableSizeString)data.Item2;

                        var stringPos = writer.BaseStream.Position;
                        writer.WriteString(str.Value, Encoding.UTF8, null, true);
                        var stringEndPos = writer.BaseStream.Position;

                        writer.BaseStream.Position = data.Item1;
                        writer.Write(stringPos - data.Item1);
                        writer.Write((Int32)(stringEndPos - stringPos));
                        writer.Write(listEnding);

                        writer.BaseStream.Position = stringEndPos;
                    }
                    else if (data.Item2.GetType().BaseType == typeof(NMSTemplate))
                    {
                        var pos = writer.BaseStream.Position;
                        var template = (NMSTemplate)data.Item2;
                        int i2 = i + 1;
                        template.AppendToWriter(writer, ref additionalData, ref i2, GetType(), listEnding);
                        var endPos = writer.BaseStream.Position;
                        writer.BaseStream.Position = data.Item1;
                        writer.Write(pos - data.Item1);
                        writer.WriteString("c" + template.GetType().Name, Encoding.UTF8, 0x40);
                        writer.BaseStream.Position = endPos;
                    }
                    else if (data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof(List<>))
                    {
                        // this will serialise a dynamic length list of either a generic type, or a specific type
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                        if (itemType == typeof(NMSTemplate))
                        {
                            // this is serialising a list of generic type
                            SerializeGenericList(writer, (IList)data.Item2, data.Item1, ref additionalData, i + 1, listEnding);
                        }
                        else
                        {
                            // this is serialising a list if a particular type
                            SerializeList(writer, (IList)data.Item2, data.Item1, ref additionalData, i + 1, listEnding);
                        }
                    }
                    else
                        throw new Exception($"[C] Unknown type {data.Item2.GetType()} in additionalData list!");
                }

                return stream.ToArray();
            }
        }
        public EXmlBase SerializeEXmlValue(Type fieldType, FieldInfo field, NMSAttribute settings, object value)
        {
            string t = fieldType.Name;
            int i = 0;
            string valueString = String.Empty;

            switch (fieldType.Name)
            {
                case "String":
                case "Boolean":
                case "Int16":
                case "UInt16":
                case "Int32":
                case "UInt32":
                case "Int64":
                case "UInt64":
                    valueString = value.ToString();
                    if (fieldType.Name != "Int32")
                        break;
                    
                    var valuesMethod = GetType().GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
                    var dictData = GetType().GetMethod(field.Name + "Dict");
                    if (dictData != null)
                    {
                        if (((int)value) == -1)
                            valueString = "";
                        else
                        {
                            Dictionary<int, string> dataDict = (Dictionary<int, string>)dictData.Invoke(this, null);
                            valueString = dataDict[(int)value];
                        }
                    }
                    if (valuesMethod != null)
                    {
                        if (((int)value) == -1)
                            valueString = "";
                        else
                        {
                            string[] values = (string[])valuesMethod.Invoke(this, null);
                            valueString = values[(int)value];
                        }
                    }/*
                    else if (settings?.EnumValue != null)
                    {
                        if (((int)value) == -1)
                            valueString = "";
                        else
                            valueString = settings.EnumValue[(int)value];
                    }*/
                    break;
                case "Single":
                    valueString = ((float)value).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    break;
                case "Double":
                    valueString = ((double)value).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    break;
                case "Byte[]":
                    valueString = value == null ? null : Convert.ToBase64String((byte[])value);
                    break;
                case "List`1":
                    var listType = field.FieldType.GetGenericArguments()[0];
                    EXmlProperty listProperty = new EXmlProperty
                    {
                        Name = field.Name
                    };

                    IList templates = (IList)value;
                    i = 0;
                    foreach (var template in templates)
                    {
                        EXmlBase data = SerializeEXmlValue(listType, field, settings, template);
                        if (settings?.EnumValue != null)
                        {
                            data.Name = settings.EnumValue[i];
                            i++;
                        }
                        else
                            data.Name = null;

                        listProperty.Elements.Add(data);
                    }

                    return listProperty;
                case "NMSTemplate":
                    if (value != null)
                    {
                        NMSTemplate template = (NMSTemplate)value;

                        var templateXmlData = template.SerializeEXml(true);
                        templateXmlData.Name = field.Name;

                        return templateXmlData;
                    }
                    return null;
                default:
                    if (fieldType.BaseType.Name == "NMSTemplate")
                    {
                        NMSTemplate template = (NMSTemplate)value;

                        var templateXmlData = template.SerializeEXml(true);
                        templateXmlData.Name = field.Name;

                        return templateXmlData;
                    }
                    else if (fieldType.IsArray)
                    {
                        var arrayType = field.FieldType.GetElementType();
                        EXmlProperty arrayProperty = new EXmlProperty
                        {
                            Name = field.Name
                        };

                        Array array = (Array)value;
                        i = 0;
                        foreach (var template in array)
                        {
                            EXmlBase data = SerializeEXmlValue(arrayType, field, settings, template);
                            if (settings?.EnumValue != null)
                            {
                                data.Name = settings.EnumValue[i];
                                i++;
                            }
                            else
                                data.Name = null;

                            arrayProperty.Elements.Add(data);
                        }

                        return arrayProperty;
                    }
                    else
                    {
                        throw new Exception(string.Format("Unable to encode {0} to EXml!", field));
                    }
            }

            return new EXmlProperty
            {
                Name = field.Name,
                Value = valueString
            };
        }

        public EXmlBase SerializeEXml(bool isChildTemplate)
        {
            Type type = GetType();
            EXmlBase xmlData = new EXmlProperty
            {
                Value = type.Name + ".xml"
            };
            if (!isChildTemplate)
            {
                xmlData = new EXmlData
                {
                    Template = type.Name
                };
            }

            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach (var field in fields)
            {
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                if (settings == null)
                {
                    settings = new NMSAttribute();
                }
                if (settings.Ignore)
                    continue;
                xmlData.Elements.Add(SerializeEXmlValue(field.FieldType, field, settings, field.GetValue(this)));
            }

            return xmlData;
        }

        public static object DeserializeEXmlValue(NMSTemplate template, Type fieldType, FieldInfo field, EXmlProperty xmlProperty, Type templateType, NMSAttribute settings)
        {
            switch (fieldType.Name)
            {
                case "String":
                    return xmlProperty.Value;
                case "Single":
                    return float.Parse(xmlProperty.Value);
                case "Boolean":
                    return bool.Parse(xmlProperty.Value);
                case "Int16":
                    return short.Parse(xmlProperty.Value);
                case "UInt16":
                    return ushort.Parse(xmlProperty.Value);
                case "Int32":
                    var valuesMethod = templateType.GetMethod(field.Name + "Values");
                    var dictData = templateType.GetMethod(field.Name + "Dict");
                    if (dictData != null)
                    {
                        if (String.IsNullOrEmpty(xmlProperty.Value))
                            return -1;
                        else
                        {
                            Dictionary<int, string>  dataDict = (Dictionary<int, string>)dictData.Invoke(template, null);
                            int key = dataDict.Where(kvp => kvp.Value == xmlProperty.Value).Select(kvp => kvp.Key).FirstOrDefault();
                            return key;
                        }
                    }
                    if (valuesMethod != null)
                    {
                        if (String.IsNullOrEmpty(xmlProperty.Value))
                            return -1;
                        else
                        {
                            string[] values = (string[])valuesMethod.Invoke(template, null);
                            return Array.FindIndex(values, v => v == xmlProperty.Value);
                        }
                    }/*
                    else if (settings?.EnumValue != null)
                    {
                        if (String.IsNullOrEmpty(xmlProperty.Value))
                            return -1;
                        else
                            return Array.FindIndex(settings.EnumValue, v => v == xmlProperty.Value);
                    }*/
                    else
                    {
                        return int.Parse(xmlProperty.Value);
                    }
                case "UInt32":
                    return uint.Parse(xmlProperty.Value);
                case "Int64":
                    return long.Parse(xmlProperty.Value);
                case "UInt64":
                    return ulong.Parse(xmlProperty.Value);
                case "Byte[]":
                    return xmlProperty.Value == null ? null : Convert.FromBase64String(xmlProperty.Value);
                case "List`1":
                    Type elementType = fieldType.GetGenericArguments()[0];
                    Type listType = typeof(List<>).MakeGenericType(elementType);
                    IList list = (IList)Activator.CreateInstance(listType);
                    foreach (var innerXmlData in xmlProperty.Elements) // child templates
                    {
                        object element = null;
                        if (innerXmlData.GetType() == typeof(EXmlData) || (innerXmlData.GetType() == typeof(EXmlProperty) && ((EXmlProperty)innerXmlData).Value.EndsWith(".xml")))
                            element = DeserializeEXml(innerXmlData); // child template if <Data> tag or <Property> tag with value ending in .xml (todo: better way of finding <Property> child templates)
                        else if (innerXmlData.GetType() == typeof(EXmlProperty))
                            element = DeserializeEXmlValue(template, elementType, field, (EXmlProperty)innerXmlData, templateType, settings);
                        else if (innerXmlData.GetType() == typeof(EXmlMeta))
                            Console.WriteLine(((EXmlMeta)innerXmlData).Comment);
                        if (element == null)
                            throw new Exception("element == null ??!");

                        list.Add(element);
                    }
                    return list;
                default:
                    if (field.FieldType.IsArray && field.FieldType.GetElementType().BaseType.Name == "NMSTemplate")
                    {
                        Array array = Array.CreateInstance(field.FieldType.GetElementType(), settings.Size);
                        //var data = xmlProperty.Elements.OfType<EXmlProperty>().ToList();
                        List<EXmlBase> data = xmlProperty.Elements.ToList();
                        int numMeta = 0;
                        foreach (EXmlBase entry in data)
                        {
                            if (entry.GetType() == typeof(EXmlMeta))
                            {
                                numMeta += 1;
                            }
                        }
                        if (data.Count - numMeta != settings.Size)
                        {
                            // todo: add a comment in the XML to indicate arrays (+ their size), also need to do the same for showing valid enum values
                            var error = $"{field.Name}: XML array size {data.Count - numMeta} doesn't match expected array size {settings.Size}";
                            Console.WriteLine($"Error: {error}!");
                            Console.WriteLine("You might have added/removed an item from an array field");
                            Console.WriteLine("(arrays can't be shortened or extended as they're a fixed size set by the game)");
                            throw new Exception(error);
                        }
                        for (int i = 0; i < data.Count; ++i)
                        {
                            if (data[i].GetType() == typeof(EXmlProperty))
                            {
                                NMSTemplate element = DeserializeEXml(data[i]);
                                array.SetValue(element, i - numMeta);
                            }
                            else if (data[i].GetType() == typeof(EXmlMeta))
                            {
                                Console.WriteLine(((EXmlMeta)data[i]).Comment);     // don't need to worry about nummeta here since it is already counted above...
                            }
                        }

                        return array;
                    }
                    else if (field.FieldType.IsArray)
                    {
                        Array array = Array.CreateInstance(field.FieldType.GetElementType(), settings.Size);
                        //List<EXmlProperty> data = xmlProperty.Elements.OfType<EXmlProperty>().ToList();
                        List<EXmlBase> data = xmlProperty.Elements.ToList();
                        int numMeta = 0;
                        for (int i = 0; i < data.Count; ++i)
                        {
                            if (data[i].GetType() == typeof(EXmlProperty))
                            {
                                object element = DeserializeEXmlValue(template, field.FieldType.GetElementType(), field, (EXmlProperty)data[i], templateType, settings);
                                array.SetValue(element, i - numMeta);
                            }
                            else if (data[i].GetType() == typeof(EXmlMeta))
                            {
                                Console.WriteLine(((EXmlMeta)data[i]).Comment);
                                numMeta += 1;           // increment so that the actual data is still placed at the right spot
                            }
                        }

                        return array;
                    }
                    else
                    {
                        return fieldType.IsValueType ? Activator.CreateInstance(fieldType) : null;
                    }
            }
        }

        public static NMSTemplate DeserializeEXml(EXmlBase xmlData)      // this is the inital code that is run when converting exml to mbin.
        // this code is run to parse over the exml file and put it into a data structure that is processed by SerializeValue() (I think...)
        {
            NMSTemplate template = null;

            //Console.WriteLine(xmlData.Name);
            //Console.WriteLine(xmlData.GetType().ToString());

            if (xmlData.GetType() == typeof(EXmlData))
                template = TemplateFromName(((EXmlData)xmlData).Template);
            else if (xmlData.GetType() == typeof(EXmlProperty))
                template = TemplateFromName(((EXmlProperty)xmlData).Value.Replace(".xml", ""));
            else if (xmlData.GetType() == typeof(EXmlMeta))
                Console.WriteLine(((EXmlMeta)xmlData).Comment);

            /*
            Console.WriteLine("Getting types");
            foreach (var property in xmlData.Elements)
            {
                Console.WriteLine(property.GetType());
            }*/

            if (template == null)
                return null;

            Type templateType = template.GetType();
            var templateFields = templateType.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach (var templateField in templateFields)
            {
                // check to see if the object has a default value in the struct
                NMSAttribute settings = templateField.GetCustomAttribute<NMSAttribute>();
                if (settings?.DefaultValue != null)
                    templateField.SetValue(template, settings.DefaultValue);
            }

            foreach (var xmlElement in xmlData.Elements)
            {
                if (xmlElement.GetType() == typeof(EXmlProperty))
                {
                    EXmlProperty xmlProperty = (EXmlProperty)xmlElement;
                    FieldInfo field = templateType.GetField(xmlProperty.Name);
                    object fieldValue = null;
                    if (field.FieldType == typeof(NMSTemplate) || field.FieldType.BaseType == typeof(NMSTemplate))
                    {
                        fieldValue = DeserializeEXml(xmlProperty);
                    }
                    else
                    {
                        Type fieldType = field.FieldType;
                        NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                        fieldValue = DeserializeEXmlValue(template, fieldType, field, xmlProperty, templateType, settings);
                    }
                    field.SetValue(template, fieldValue);
                }
                else if (xmlElement.GetType() == typeof(EXmlData))
                {
                    EXmlData innerXmlData = (EXmlData)xmlElement;
                    FieldInfo field = templateType.GetField(innerXmlData.Name);
                    NMSTemplate innerTemplate = DeserializeEXml(innerXmlData);
                    field.SetValue(template, innerTemplate);
                }
                else if (xmlElement.GetType() == typeof(EXmlMeta))
                {
                    EXmlMeta xmlMeta = (EXmlMeta)xmlElement;
                    string comment = xmlMeta.Comment;
                    Console.WriteLine(comment);
                }
            }
            /*
            foreach (var xmlProperty in xmlData.Elements.OfType<EXmlProperty>())
            {
                FieldInfo field = templateType.GetField(xmlProperty.Name);
                object fieldValue = null;
                if (field.FieldType == typeof(NMSTemplate) || field.FieldType.BaseType == typeof(NMSTemplate))
                {
                    fieldValue = DeserializeEXml(xmlProperty);
                }
                else
                {
                    Type fieldType = field.FieldType;
                    NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                    fieldValue = DeserializeEXmlValue(template, fieldType, field, xmlProperty, templateType, settings);
                }
                field.SetValue(template, fieldValue);
            }

            foreach (EXmlData innerXmlData in xmlData.Elements.OfType<EXmlData>())
            {
                FieldInfo field = templateType.GetField(innerXmlData.Name);
                NMSTemplate innerTemplate = DeserializeEXml(innerXmlData);
                field.SetValue(template, innerTemplate);
            }

            foreach (var xmlProperty in xmlData.Elements.OfType<EXmlMeta>())
            {
                Console.WriteLine("Hello!!!");
                string comment = xmlProperty.Comment;
                Console.WriteLine(comment);
            }*/

            return template;
        }

        // func thats run after template is deserialized, can be used for checks etc
        public void FinishDeserialize()
        {
#if DEBUG
            // check enums are valid
            var fields = GetType().GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                var fieldType = field.FieldType.Name;
                if (fieldType != "Int32")
                    continue;

                var valuesMethod = GetType().GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
                if (valuesMethod == null)
                    continue;

                int value = (int)field.GetValue(this);
                if (value == -1)
                    continue;

                string[] values = (string[])valuesMethod.Invoke(this, null);
                try
                {
                    string valueStr = values[(int)value];
                }
                catch (IndexOutOfRangeException e){
                    Console.WriteLine("Values index out of Range. Struct: " + GetType() + " field: " + field.Name);
                    throw new Exception("Error");
                }
                
            }
#endif
        }

        public virtual object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            return null;
        }

        public virtual bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            return false;
        }
    }
}

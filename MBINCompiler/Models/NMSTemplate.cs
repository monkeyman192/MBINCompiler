using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

using MBINCompiler.Models.Structs;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models
{
    public class NMSTemplate
    {
        internal static readonly Dictionary<string, Type> NMSTemplateMap = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(NMSTemplate))
                .ToDictionary(t => t.Name);

        internal static bool PrintToDebug = true; // disable this when doing things in debug mode (tests etc) for a nice speedup

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

            Console.WriteLine("Gk Hack: " + "Deserializing Template: " + templateName);
            
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
                ((VariableSizeString)obj).Value = reader.ReadString(Encoding.UTF8, stringLength);
                reader.BaseStream.Position = templatePosition + 0x10;
                return obj;
            }

            var type = obj.GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                field.SetValue(obj, DeserializeValue(reader, field.FieldType, settings, templatePosition, field, obj));
                Console.WriteLine("Gk Hack: " + templateName + " Deserialized Value: " + field.Name + " value: " + field.GetValue(obj));
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
                Dictionary<long, string> templates = new Dictionary<long, string>();
                for (int i = 0; i < numTemplates; i++)
                {
                    long nameOffset = reader.BaseStream.Position;
                    long templateOffset = reader.ReadInt64();
                    var name = reader.ReadString(Encoding.UTF8, 0x40, true);
                    if (templateOffset == 0)
                        continue; // wtf? seen in METADATA\UI\HUD\WEAPONS\LASER.MBIN @ 0x2A8, numTemplates = 4 but only 1 is set?

                    templates.Add(nameOffset + templateOffset, name);
                }

                long pos = reader.BaseStream.Position;

                foreach (var templateInfo in templates)
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

        public void SerializeValue(BinaryWriter writer, Type fieldType, object fieldData, NMSAttribute settings, FieldInfo field, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
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
                        writer.Write((UInt32)0xAAAAAA01);

                        var list = (IList)fieldData;
                        additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, list));
                        addtDataIndex++;
                    }

                    break;
                case "NMSTemplate":
                    writer.Align(8, 0);
                    long refPos = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    var template = (NMSTemplate)fieldData;
                    if (template == null)
                    {
                        writer.WriteString("", Encoding.UTF8, 0x40);
                    }
                    else
                    {
                        writer.WriteString("c" + template.GetType().Name, Encoding.UTF8, 0x40);
                        additionalData.Insert(addtDataIndex++, new Tuple<long, object>(refPos, template));
                    }
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
                        writer.Write((UInt32)0xAAAAAA01);

                        var fieldValue = (VariableSizeString)fieldData;
                        additionalData.Insert(addtDataIndex++, new Tuple<long, object>(fieldPos, fieldValue));
                    }
                    else if (fieldType.IsArray)
                    {
                        var arrayType = fieldType.GetElementType();
                        Array array = (Array)fieldData;
                        if (array == null)
                            array = Array.CreateInstance(arrayType, settings.Size);

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

                            realData.AppendToWriter(writer, ref additionalData, ref addtDataIndex, GetType());
                        }
                        else
                            throw new Exception($"[C] Unknown type {fieldType} not NMSTemplate" + (field != null ? $" for {field.Name}" : ""));
                    }

                    break;
            }
        }

        public void AppendToWriter(BinaryWriter writer, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex, Type parent)
        {
            long templatePosition = writer.BaseStream.Position;
            if (PrintToDebug) Debug.WriteLine($"[C] writing {GetType().Name} to offset 0x{templatePosition:X} (parent: {parent.Name})");

            var type = GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            
            foreach (var field in fields)
            {
                var fieldAddr = writer.BaseStream.Position - templatePosition;
                var fieldData = field.GetValue(this);
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                SerializeValue(writer, field.FieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex);
            }
        }

        public void SerializeGenericList(BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex)
        {
            long listPosition = writer.BaseStream.Position;
            if (PrintToDebug) Debug.WriteLine($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if (list.Count > 0)
                writer.Write(listPosition - listHeaderPosition);
            else
                writer.Write((long)0); // lists with 0 entries have offset set to 0

            writer.Write((Int32)list.Count);
            writer.Write((UInt32)0xAAAAAA01);

            // reserve space for list offsets+names
            writer.BaseStream.Position = listPosition;
            writer.Write(new byte[list.Count * 0x48]);
            writer.Align(0x10, 0); // why

            int addtDataIndexThis = addtDataIndex;

            var entryOffsetNamePairs = new Dictionary<long, string>();
            foreach (var entry in list)
            {
                entryOffsetNamePairs.Add(writer.BaseStream.Position, entry.GetType().Name);
                var template = (NMSTemplate)entry;
                var addtData = new Dictionary<long, object>();
                if (PrintToDebug) Debug.WriteLine($"[C] writing {template.GetType().Name} to offset 0x{writer.BaseStream.Position:X}");
                template.AppendToWriter(writer, ref additionalData, ref addtDataIndexThis, GetType());
            }

            long dataEndOffset = writer.BaseStream.Position;

            writer.BaseStream.Position = listPosition;
            foreach (var entry in entryOffsetNamePairs)
            {
                var position = writer.BaseStream.Position;
                var offset = entry.Key - position; // get offset of this entry from the current offset
                writer.Write(offset);
                writer.WriteString("c" + entry.Value, Encoding.UTF8, 0x40);
            }

            writer.BaseStream.Position = dataEndOffset;
        }

        public void SerializeList(BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex)
        {
            long listPosition = writer.BaseStream.Position;
            if (PrintToDebug) Debug.WriteLine($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if (list.Count > 0)
                writer.Write(listPosition - listHeaderPosition);
            else
                writer.Write((long)0); // lists with 0 entries have offset set to 0
            writer.Write((Int32)list.Count);
            writer.Write((UInt32)0xAAAAAA01);

            writer.BaseStream.Position = listPosition;

            int addtDataIndexThis = addtDataIndex;

            foreach (var entry in list)
            {
                if (PrintToDebug) Debug.WriteLine($"[C] writing {entry.GetType().Name} to offset 0x{writer.BaseStream.Position:X}");
                SerializeValue(writer, entry.GetType(), entry, null, null, ref additionalData, ref addtDataIndexThis);
            }
        }

        public byte[] SerializeBytes()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.ASCII))
            {
                var additionalData = new List<Tuple<long, object>>();

                int i = 0;
                // write primary template + any embedded templates
                AppendToWriter(writer, ref additionalData, ref i, GetType());

                // now write values of lists etc
                for (i = 0; i < additionalData.Count; i++)
                {
                    var data = additionalData[i];
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates
                    long origPos = writer.BaseStream.Position;
                    writer.Align(0x8, 0); // todo: check if this alignment is correct

                    if (data.Item2.GetType() == typeof(VariableSizeString))
                    {
                        writer.BaseStream.Position = origPos; // no alignment for dynamicstrings

                        var str = (VariableSizeString)data.Item2;

                        var stringPos = writer.BaseStream.Position;
                        writer.WriteString(str.Value, Encoding.UTF8, null, true);
                        var stringEndPos = writer.BaseStream.Position;

                        writer.BaseStream.Position = data.Item1;
                        writer.Write(stringPos - data.Item1);
                        writer.Write((Int32)(stringEndPos - stringPos) - 1); // -1 for null terminator
                        writer.Write((UInt32)0xAAAAAA01);

                        writer.BaseStream.Position = stringEndPos;
                    }
                    else if (data.Item2.GetType().BaseType == typeof(NMSTemplate))
                    {
                        var pos = writer.BaseStream.Position;
                        var template = (NMSTemplate)data.Item2;
                        int i2 = i + 1;
                        template.AppendToWriter(writer, ref additionalData, ref i2, GetType());
                        var endPos = writer.BaseStream.Position;
                        writer.BaseStream.Position = data.Item1;
                        writer.Write(pos - data.Item1);
                        writer.WriteString("c" + template.GetType().Name, Encoding.UTF8, 0x40);
                        writer.BaseStream.Position = endPos;
                    }
                    else if (data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof(List<>))
                    {
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                        if (itemType == typeof(NMSTemplate))
                            SerializeGenericList(writer, (IList)data.Item2, data.Item1, ref additionalData, i + 1);
                        else
                            SerializeList(writer, (IList)data.Item2, data.Item1, ref additionalData, i + 1);
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
                    if (valuesMethod != null)
                    {
                        if (((int)value) == -1)
                            valueString = "";
                        else
                        {
                            string[] values = (string[])valuesMethod.Invoke(this, null);
                            valueString = values[(int)value];
                        }
                    }
                    else if (settings?.EnumValue != null)
                    {
                        if (((int)value) == -1)
                            valueString = "";
                        else
                            valueString = settings.EnumValue[(int)value];
                    }
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
                    if (valuesMethod != null)
                    {
                        if (String.IsNullOrEmpty(xmlProperty.Value))
                            return -1;
                        else
                        {
                            string[] values = (string[])valuesMethod.Invoke(template, null);
                            return Array.FindIndex(values, v => v == xmlProperty.Value);
                        }
                    }
                    else if (settings?.EnumValue != null)
                    {
                        if (String.IsNullOrEmpty(xmlProperty.Value))
                            return -1;
                        else
                            return Array.FindIndex(settings.EnumValue, v => v == xmlProperty.Value);
                    }
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
                        if(innerXmlData.GetType() == typeof(EXmlData) || (innerXmlData.GetType() == typeof(EXmlProperty) && ((EXmlProperty)innerXmlData).Value.EndsWith(".xml")))
                            element = DeserializeEXml(innerXmlData); // child template if <Data> tag or <Property> tag with value ending in .xml (todo: better way of finding <Property> child templates)
                        else if(innerXmlData.GetType() == typeof(EXmlProperty))
                            element = DeserializeEXmlValue(template, elementType, field, (EXmlProperty)innerXmlData, templateType, settings);
                        if (element == null)
                            throw new Exception("element == null ??!");

                        list.Add(element);
                    }
                    return list;
                default:
                    if (field.FieldType.IsArray && field.FieldType.GetElementType().BaseType.Name == "NMSTemplate")
                    {
                        Array array = Array.CreateInstance(field.FieldType.GetElementType(), settings.Size);
                        var data = xmlProperty.Elements.OfType<EXmlProperty>().ToList();
                        if(data.Count != settings.Size)
                        {
                            // todo: add a comment in the XML to indicate arrays (+ their size), also need to do the same for showing valid enum values
                            var error = $"{field.Name}: XML array size {data.Count} doesn't match expected array size {settings.Size}";
                            Console.WriteLine($"Error: {error}!");
                            Console.WriteLine("You might have added/removed an item from an array field");
                            Console.WriteLine("(arrays can't be shortened or extended as they're a fixed size set by the game)");
                            throw new Exception(error);
                        }
                        for (int i = 0; i < data.Count; ++i)
                        {
                            NMSTemplate element = DeserializeEXml(data[i]);
                            array.SetValue(element, i);
                        }

                        return array;
                    }
                    else if (field.FieldType.IsArray)
                    {
                        Array array = Array.CreateInstance(field.FieldType.GetElementType(), settings.Size);
                        List<EXmlProperty> data = xmlProperty.Elements.OfType<EXmlProperty>().ToList();
                        for (int i = 0; i < data.Count; ++i)
                        {
                            object element = DeserializeEXmlValue(template, field.FieldType.GetElementType(), field, data[i], templateType, settings);
                            array.SetValue(element, i);
                        }

                        return array;
                    }
                    else
                    {
                        return fieldType.IsValueType ? Activator.CreateInstance(fieldType) : null;
                    }
            }
        }

        public static NMSTemplate DeserializeEXml(EXmlBase xmlData)
        {
            NMSTemplate template = null;

            if (xmlData.GetType() == typeof(EXmlData))
                template = TemplateFromName(((EXmlData)xmlData).Template);
            else if (xmlData.GetType() == typeof(EXmlProperty))
                template = TemplateFromName(((EXmlProperty)xmlData).Value.Replace(".xml", ""));

            if (template == null)
                return null;

            Type templateType = template.GetType();
            var templateFields = templateType.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach (var templateField in templateFields)
            {
                NMSAttribute settings = templateField.GetCustomAttribute<NMSAttribute>();
                if (settings?.DefaultValue != null)
                    templateField.SetValue(template, settings.DefaultValue);
            }

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

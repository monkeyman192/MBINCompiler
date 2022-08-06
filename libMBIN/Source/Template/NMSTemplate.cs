// These defines require that the project is set to the 'Debug' configuration, not Release.
// They will always be disabled/ignored in Release builds.

// Uncomment to enable debug logging of the template de/serialization.
//#define DEBUG_TEMPLATE

// Uncomment to enable debug logging of XML comments
//#define DEBUG_COMMENTS

// Uncomment to enable debug logging of MBIN field names
//#define DEBUG_FIELD_NAMES

// Uncomment to enable debug logging of XML property names
//#define DEBUG_PROPERTY_NAMES


using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace libMBIN
{
    public class NMSTemplate
    {
        internal static readonly Dictionary<string, Type> NMSTemplateMap = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(NMSTemplate))
                .ToDictionary(t => t.Name);

        #region DebugLog
        // Conditionally compile methods for Release optimization.
        //
        // DEBUG is automatically defined if the project is set to the 'Debug' build configuration.
        // If the project is set to the 'Release' configuration, then DEBUG will not be defined.
        // 
        // Use the NMSTEMPLATE_* defines at the top of this file to enable/disable debug logging.

        // TODO: static could be problematic for threading?
        internal static bool isDebugLogTemplateEnabled = true;

        [Conditional( "DEBUG" )]
        internal static void DebugLogTemplate( string msg ) {
            #if DEBUG_TEMPLATE
                if (isDebugLogTemplateEnabled) Logger.LogDebug( msg );
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogComment( string msg ) {
            #if DEBUG_COMMENTS
                Logger.LogDebug( msg );
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogFieldName( string msg ) {
            #if DEBUG_FIELD_NAMES
                Logger.LogDebug( msg );
            #endif
        }

        [Conditional( "DEBUG" )]
        internal static void DebugLogPropertyName( string msg ) {
            #if DEBUG_PROPERTY_NAMES
                Logger.LogDebug( msg );
            #endif
        }

        #endregion

        public static Type GetTemplateType(string name) {
            Type type = null;
            if ( NMSTemplateMap.TryGetValue( name, out type ) ) return type;
            return null;
        }

        public static NMSTemplate TemplateFromName(string templateName) {
            Type type = GetTemplateType( templateName );
            if ( type != null) return Activator.CreateInstance( type ) as NMSTemplate;
            return null; // Template type doesn't exist
        }

        public int GetDataSize() {
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                var addt = new List<Tuple<long, object>>();
                int addtIdx = 0;

                var prevState = isDebugLogTemplateEnabled;
                isDebugLogTemplateEnabled = false;
                AppendToWriter(bw, ref addt, ref addtIdx, GetType());
                isDebugLogTemplateEnabled = prevState;

                return ms.ToArray().Length;
            }
        }

        public int OffsetOf(string field) {
            return OffsetOf(GetType(), field);
        }

        public static int OffsetOf(string className, string fieldName) {
            return OffsetOf(NMSTemplateMap[className], fieldName);
        }

        /// <summary>
        /// Get the relative offset within the class of the given field name.
        /// </summary>
        /// <param name="type">
        /// The type of the class that contains the specified field.
        /// </param>
        /// <param name="fieldName">
        /// The name of the field to find the offset of. This must be a field of this class itself, not a child class.
        /// </param>
        /// <exception cref="System.ArgumentException">Thrown when the fieldName value isn't a valid field of the specified class.</exception>
        /// <returns></returns>
        public static int OffsetOf(Type type, string fieldName)
        {
            var fields = type.GetFields().OrderBy(field => field.MetadataToken);
            int offset = 0;
            foreach (var field in fields)
            {
                int alignment = AlignOf(field.FieldType);
                // Make sure the alignment is taken into consideration.
                if (offset % alignment != 0) {
                    offset += alignment - (offset % alignment);
                }
                // Now check to see if the field name matches.
                if (fieldName == field.Name) {
                    return offset;
                }
                // If not, then add the size of the current field and continue.
                offset += SizeOf(field);
            }

            // If we get here then we have an issue. Throw an exception
            throw new ArgumentException($"{type.Name} has no field called {fieldName}", fieldName);
        }

        public static int GetTemplateDataSize(string templateName) {
            var template = TemplateFromName(templateName);
            if (template == null) return 0;

            return template.GetDataSize();
        }

        public static int SizeOf(FieldInfo field) {
            // Get the base size of the field.
            int size;
            // If the field is an array, we need to multiply this base size by the number of elements
            if (field.FieldType.IsArray) {
                size = SizeOf(field.FieldType.GetElementType());
                size *= field.GetCustomAttribute<NMSAttribute>()?.Size ?? 0;
            } else if (field.FieldType.Name == "String") {
                // The length of a string is an attribute.
                size = field.GetCustomAttribute<NMSAttribute>()?.Size ?? 0;
            } else {
                size = SizeOf(field.FieldType);
            }
            return size;
        }


        public static int SizeOf(Type type) {
            int size = 0;

            switch (type.Name)
            {
                case "Boolean":
                case "Byte":
                case "String":
                    size = 0x1;
                    break;

                case "Int16":
                case "UInt16":
                    size = 0x2;
                    break;

                case "Single":
                case "Int32":
                case "UInt32":
                    size = 0x4;
                    break;

                case "Int64":
                case "UInt64":
                    size = 0x8;
                    break;

                case "VariableSizeString":
                case "List`1":
                    size = 0x10;
                    break;

                case "NMSTemplate":
                    size = 0x50;
                    break;

                default:
                    if (type.IsEnum) {
                        size = SizeOf(Enum.GetUnderlyingType(type));
                        break;
                    }

                    NMSAttribute settings = type.GetCustomAttribute<NMSAttribute>();
                    if (settings != null && settings.Size > 0) {
                        size = settings.Size;
                        break;
                    }

                    // For a class which inherits from the NMSTemplate, iterate over
                    // the fields and get the total size by adding up the sizes of the
                    // fields.
                    int max_alignment = 1;
                    int alignment = 1;
                    foreach (FieldInfo field in type.GetFields()) {
                        alignment = AlignOf(field.FieldType);
                        // If the current size doesn't match the alignment of the current field,
                        // then align it.
                        if (size % alignment != 0) {
                            size += (alignment - (size % alignment));
                        }
                        size += SizeOf(field);
                        // Update the max alignment.
                        if (alignment > max_alignment) {
                            max_alignment = alignment;
                        }
                    }
                    // Finally, ensure that the total size is a multiple of the max alignment.
                    if (size % max_alignment != 0) {
                        size += (max_alignment - (size % max_alignment));
                    }
                    // If the size is still 0 after this then it means that we got a class derived
                    // from NMSTemplate which has no fields. We still give this a nominal size of 1.
                    if (size == 0) {
                        size = 1;
                    }
                    break;
            }

            if (size != 0) { return size; }
            // If we have got here then we have got a type which we cannot determine the size of. Raise an error.
            throw new ArgumentException($"{type.Name} has an unknown size.");
        }

        private static ConcurrentDictionary<Type,int> AlignmentMap = new ConcurrentDictionary<Type,int>();

        public static int AlignOf(Type type) {
            int alignment;

            if (AlignmentMap.TryGetValue(type, out alignment)) {
                return alignment;
            }

            switch (type.Name) {
                case "Boolean":
                case "Byte":
                case "String":
                    alignment = 0x1;
                    break;

                case "Int16":
                case "UInt16":
                    alignment = 0x2;
                    break;

                case "Single":
                case "Int32":
                case "UInt32":
                    alignment = 0x4;
                    break;

                case "Int64":
                case "UInt64":
                case "List`1":
                case "NMSTemplate":
                case "VariableSizeString":
                    alignment = 0x8;
                    break;

                default:
                    if (type.IsArray) {
                        alignment = AlignOf(type.GetElementType());
                        break;
                    }

                    if (type.IsEnum) {
                        alignment = 0x4;
                        break;
                    }

                    NMSAttribute settings = type.GetCustomAttribute<NMSAttribute>();
                    if (settings != null && settings.Alignment > 0) {
                        alignment = settings.Alignment;
                        break;
                    }

                    if (type.BaseType == typeof(NMSTemplate)) {
                        alignment = 1;

                        foreach (FieldInfo field in type.GetFields()) {
                            int align = AlignOf(field.FieldType);
                            if (align > alignment) {
                                alignment = align;
                                if (alignment >= 0x10) break;
                            }
                        }

                        break;
                    }

                    throw new UnknownTypeException( type );
            }

            AlignmentMap[type] = alignment;
            return alignment;
        }

        public static object DeserializeValue(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo, NMSTemplate parent) {
            //Logger.LogDebug( $"{fieldInfo?.DeclaringType.Name}.{fieldInfo?.Name}\ttype:\t{field.Name}\tpos:\t0x{templatePosition:X}" );

            object template = parent.CustomDeserialize( reader, field, settings, fieldInfo );
            if (template != null) return template;

            // TODO: change fieldType to fieldName...
            var fieldType = field.Name;
            switch (fieldType) {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;

                    if (fieldType == "String") {
                        // reader.Align(0x4, templatePosition);
                        return reader.ReadString(Encoding.UTF8, size, true);
                    } else {
                        return reader.ReadBytes(size);
                    }
                case "Single":
                    reader.Align( 4 );
                    return reader.ReadSingle();
                case "Boolean":
                    return reader.ReadByte() != 0;
                case "Byte":
                    return reader.ReadByte();
                case "Int16":
                case "UInt16":
                    reader.Align( 2 );
                    return fieldType == "Int16" ? (object)reader.ReadInt16() : (object)reader.ReadUInt16();
                case "Int32":
                case "UInt32":
                    reader.Align( 4 );
                    return fieldType == "Int32" ? (object)reader.ReadInt32() : (object)reader.ReadUInt32();
                case "Int64":
                case "UInt64":
                    reader.Align( 8 );
                    return fieldType == "Int64" ? (object)reader.ReadInt64() : (object)reader.ReadUInt64();
                case "List`1":
                    reader.Align( 8 );
                    if (field.IsGenericType && field.GetGenericTypeDefinition() == typeof(List<>)) {
                        Type itemType = field.GetGenericArguments()[0];
                        if ( itemType == typeof( NMSTemplate ) ) {
                            return DeserializeGenericList( reader, parent );
                        } else {
                            // todo: get rid of this nastiness
                            MethodInfo method = typeof( NMSTemplate ).GetMethod( "DeserializeList", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic )
                                                         .MakeGenericMethod( new Type[] { itemType } );
                            var list = method.Invoke( null, new object[] { reader, fieldInfo, settings, templatePosition, parent } );
                            return list;
                        }
                    }
                    return null;
                case "NMSTemplate":
                    reader.Align( 8 );
                    long startPos = reader.BaseStream.Position;
                    long offset = reader.ReadInt64();
                    string name = reader.ReadString(Encoding.ASCII, 0x40, true);
                    ulong NameHash = reader.ReadUInt64();
                    if ( name.Length > 0 ) {
                        var templateName = name;
                        if ( name.StartsWith( "c" ) && name.Length > 1 ) {
                            templateName = name.Substring( 1 );
                        }
                        ulong expected_NameHash = GetTemplateType( templateName )?.GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0;
                        if ( NameHash != expected_NameHash ) {
                            Logger.LogMessage( "NameHash", $"{templateName} has the wrong NameHash" );
                        }
                    }

                    long endPos = reader.BaseStream.Position;
                    template = null;
                    if (offset != 0 && !String.IsNullOrEmpty(name)) {
                        reader.BaseStream.Position = startPos + offset;
                        template = DeserializeBinaryTemplate(reader, name);
                        if (template == null) throw new DeserializeTemplateException( name );
                    }
                    reader.BaseStream.Position = endPos;
                    return template;
                default:
                    if ( fieldType == "VariableStringSize") {
                        reader.Align( 0x8 );
                    }

                    if (field.IsEnum) {
                        reader.Align( 4 );
                        return fieldType == "Int32" ? (object)reader.ReadInt32() : (object)reader.ReadUInt32();
                    }

                    if (field.IsArray) {
                        var arrayType = field.GetElementType();
                        var length = GetEnumNames( fieldInfo.Name, settings ).Length;
                        Array array = Array.CreateInstance(arrayType, length);
                        for (int i = 0; i < length; ++i) {
                            object val = DeserializeValue( reader, field.GetElementType(), settings, templatePosition, fieldInfo, parent );
                            array.SetValue(val, i);
                        }
                        return array;
                    } else {
                        reader.Align( AlignOf(field) );
                        return DeserializeBinaryTemplate(reader, fieldType);
                    }
            }
        }

        public static NMSTemplate DeserializeBinaryTemplate(BinaryReader reader, string templateName)
        {
            if (templateName.StartsWith("c") && templateName.Length > 1) templateName = templateName.Substring(1);

            NMSTemplate obj = TemplateFromName(templateName);
            
            //DebugLog("Gk Hack: " + "Deserializing Template: " + templateName);
            
            if (obj == null) return null;

            long templatePosition = reader.BaseStream.Position;
            DebugLogTemplate($"{templateName}\t0x{templatePosition:X4}");
            using ( var indentScope = new Logger.IndentScope() ) {

                if ( templateName == "VariableSizeString" ) {
                    long stringPos = reader.ReadInt64();
                    int stringLength = reader.ReadInt32();
                    int unkC = reader.ReadInt32();
                    reader.BaseStream.Position = templatePosition + stringPos;
                    ((NMS.VariableSizeString) obj).Value = reader.ReadString( Encoding.UTF8, stringLength ).TrimEnd( '\x00' );
                    reader.BaseStream.Position = templatePosition + 0x10;
                    return obj;
                }

                var type = obj.GetType();
                var fields = type.GetFields().OrderBy( field => field.MetadataToken ); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
                foreach ( var field in fields ) {
                    NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                    if ( field.FieldType.IsEnum ) {
                        field.SetValue( obj, Enum.ToObject( field.FieldType, DeserializeValue( reader, field.FieldType, settings, templatePosition, field, obj ) ) );
                    } else {
                        field.SetValue( obj, DeserializeValue( reader, field.FieldType, settings, templatePosition, field, obj ) );
                    }
                    DebugLogFieldName( $"{templateName}\t0x{reader.BaseStream.Position:X4}\t{field.Name}\t{field.GetValue( obj )}" );
                }
                reader.Align( AlignOf(type) ); // This is to remove the need for end padding
                
                obj.FinishDeserialize();

            }
            DebugLogTemplate($"{templateName}\t0x{reader.BaseStream.Position:X4}");

            return obj;
        }

        public static List<NMSTemplate> DeserializeGenericList( BinaryReader reader, NMSTemplate parent ) {
            long listPosition = reader.BaseStream.Position;
            DebugLogTemplate( $"DeserializeGenericList\tstart\t0x{listPosition:X}" );

            long templateNamesOffset = reader.ReadInt64();
            int numTemplates = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if ( (listMagic & 0xFF) != 1 ) throw new InvalidListException( listMagic, reader.BaseStream.Position );

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + templateNamesOffset;
            var list = new List<NMSTemplate>();
            if ( numTemplates > 0 ) {
                //Dictionary<long, string> templates = new Dictionary<long, string>();
                List<KeyValuePair<long, String>> templates = new List<KeyValuePair<long, String>>();
                for ( int i = 0; i < numTemplates; i++ ) {
                    long nameOffset = reader.BaseStream.Position;
                    long templateOffset = reader.ReadInt64();
                    var name = reader.ReadString( Encoding.UTF8, 0x40, true );
                    ulong NameHash = reader.ReadUInt64();
                    // Make sure we have a valid template name
                    if ( name.Length > 0 ) {
                        var templateName = name;
                        if ( name.StartsWith( "c" ) && name.Length > 1 ) {
                            templateName = name.Substring( 1 );
                        }
                        ulong expected_NameHash = GetTemplateType( templateName )?.GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0;
                        if ( NameHash != expected_NameHash ) {
                            Logger.LogMessage( "NameHash", $"{templateName} has the wrong NameHash" );
                        }
                    }

                    // sometimes there are lists which have n values, but less than n actual structs in them. We replace the empty thing with EmptyNode
                    name = (templateOffset == 0) ? "EmptyNode" : name;

                    templates.Add( new KeyValuePair<long, string>( nameOffset + templateOffset, name ) );
                }

                long pos = reader.BaseStream.Position;

                foreach ( KeyValuePair<long, string> templateInfo in templates ) {
                    reader.BaseStream.Position = templateInfo.Key;
                    var template = DeserializeBinaryTemplate( reader, templateInfo.Value );
                    if ( template == null ) throw new DeserializeTemplateException( templateInfo.Value );

                    list.Add( template );
                }
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align( 0x8 );

            return list;
        }

        public static List<T> DeserializeList<T>( BinaryReader reader, FieldInfo field, NMSAttribute settings, long templateStartOffset, NMSTemplate parent ) {
            long listPosition = reader.BaseStream.Position;
            DebugLogTemplate( $"DeserializeList\tstart\t0x{listPosition:X}" );

            long listStartOffset = reader.ReadInt64();
            int numEntries = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if ( (listMagic & 0xFF) != 1 ) throw new InvalidListException( listMagic, reader.BaseStream.Position );

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + listStartOffset;
            var list = new List<T>();
            for ( int i = 0; i < numEntries; i++ ) {
                // todo: get rid of DeserializeGenericList? this seems like it would work fine with List<NMSTemplate>
                var template = DeserializeValue( reader, field.FieldType.GetGenericArguments()[0], settings, templateStartOffset, field, parent );
                if ( template == null ) throw new DeserializeTypeException( typeof( T ) );

                var type = template.GetType().BaseType;
                if ( type == typeof( NMSTemplate ) ) ((NMSTemplate) template).FinishDeserialize();

                list.Add( (T) template );
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align( 0x8 );

            return list;
        }

        public void SerializeValue( BinaryWriter writer, Type fieldType, object fieldData, NMSAttribute settings, FieldInfo field, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex, UInt32 listEnding = 0xAAAAAA01 ) {
            //Logger.LogDebug( $"{field?.DeclaringType.Name}.{field?.Name}\ttype:\t{fieldType.Name}\tadditionalData.Count:\t{additionalData?.Count ?? 0}\taddtDataIndex:\t{addtDataIndex}" );

            if (CustomSerialize(writer, fieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex)) return;

            if ( settings?.DefaultValue != null ) fieldData = settings.DefaultValue;
            switch ( fieldType.Name ) {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;
                    byte stringPadding = settings?.Padding ?? 0;
                    bool ignore = settings?.Ignore ?? false;

                    if ( fieldType.Name == "String" ) {
                        writer.WriteString( (string) fieldData, Encoding.UTF8, size, false, stringPadding );
                    } else {
                        byte[] bytes = (byte[]) fieldData;
                        if (ignore != true) size = bytes?.Length ?? 0;
                        Array.Resize( ref bytes, size);
                        writer.Write( bytes );
                    }
                    break;
                case "Single":
                    writer.Align( 4, field?.Name ?? fieldType.Name );
                    writer.Write( (Single) fieldData );
                    break;
                case "Boolean":
                    var value = (bool) fieldData;
                    writer.Write( value ? (byte) 1 : (byte) 0 );
                    break;
                case "Byte":
                    writer.Write( (Byte) fieldData );
                    break;
                case "Int16":
                case "UInt16":
                    writer.Align( 2, field?.Name ?? fieldType.Name );
                    if ( fieldType.Name == "Int16" ) {
                        writer.Write( (Int16) fieldData );
                    } else {
                        writer.Write( (UInt16) fieldData );
                    }
                    break;
                case "Int32":
                case "UInt32":
                    writer.Align( 4, field?.Name ?? fieldType.Name );
                    if ( fieldType.Name == "Int32" ) {
                        writer.Write( (Int32) fieldData );
                    } else {
                        writer.Write( (UInt32) fieldData );
                    }
                    break;
                case "Int64":
                case "UInt64":
                    writer.Align( 8, field?.Name ?? fieldType.Name );
                    if ( fieldType.Name == "Int64" ) {
                        writer.Write( (Int64) fieldData );
                    } else {
                        writer.Write( (UInt64) fieldData );
                    }
                    break;
                case "List`1":
                    writer.Align( 8, field?.Name ?? fieldType.Name );
                    if ( field != null && field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof( List<> ) ) {
                        // write empty list header
                        long listPos = writer.BaseStream.Position;
                        writer.Write( (Int64) 0 ); // listPosition
                        writer.Write( (Int32) 0 ); // listCount
                        writer.Write( listEnding );
                        IList listData = (IList) fieldData;

                        if ( listData == null ) break;
                        if ( listData.Count == 0 ) break;

                        var data = new Tuple<long, object>( listPos, listData );
                        if ( addtDataIndex >= additionalData.Count ) {
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
                    writer.Align( 8, field?.Name ?? fieldType.Name );
                    long refPos = writer.BaseStream.Position;

                    var template = (NMSTemplate) fieldData;
                    if ( template == null || template.GetType().Name == "EmptyNode" ) {
                        writer.Write( (Int64) 0 ); // listPosition
                        writer.WriteString( "", Encoding.UTF8, 0x40 );
                        writer.Write((Int64)0); // NameHash
                    } else {
                        writer.Write( (Int64) 0 );      // default value to be overridden later anyway
                        writer.WriteString( "c" + template.GetType().Name, Encoding.UTF8, 0x40 );
                        ulong NameHash = template.GetType().GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0;
                        if (NameHash != 0) {
                            writer.Write(NameHash);
                        } else {
                            throw new InvalidGUIDException(template);
                        }

                        var data = new Tuple<long, object>( refPos, template );
                        if ( addtDataIndex >= additionalData.Count ) {
                            additionalData.Add( data );
                        } else {
                            additionalData.Insert( addtDataIndex, data );
                        }
                        addtDataIndex++;
                    }
                    break;
                // TODO: remove
                case "Dictionary`2":
                    // have something defined so that it just ignores it
                    break;
                default:
                    if ( fieldType.Name == "VariableSizeString" ) {
                        writer.Align( 0x8, field?.Name ?? fieldType.Name );
                        // write empty DynamicString header
                        long fieldPos = writer.BaseStream.Position;
                        writer.Write( (Int64) 0 ); // listPosition
                        writer.Write( (Int32) 0 ); // listCount
                        writer.Write( listEnding );

                        var fieldValue = (NMS.VariableSizeString) fieldData;
                        additionalData.Insert( addtDataIndex++, new Tuple<long, object>( fieldPos, fieldValue ) );

                    } else if ( fieldType.IsArray ) {
                        var arrayType = fieldType.GetElementType();
                        Array array = (Array) fieldData;
                        int length = GetEnumNames( field.Name, settings ).Length;
                        if ( array == null ) array = Array.CreateInstance( arrayType, length );

                        foreach ( var obj in array ) {
                            long fieldPos = writer.BaseStream.Position;
                            var realObj = obj;
                            if ( realObj == null ) realObj = Activator.CreateInstance( arrayType );

                            SerializeValue( writer, realObj.GetType(), realObj, realObj.GetType().GetCustomAttribute<NMSAttribute>(), field, ref additionalData, ref addtDataIndex, listEnding );
                        }
                    } else if ( fieldType.IsEnum ) {
                        writer.Align(4, field?.Name ?? fieldType.Name );
                        Type enumType = Enum.GetUnderlyingType(field.FieldType);
                        if (enumType.Name == "UInt32") {
                            writer.Write((uint)Enum.Parse(field.FieldType, fieldData.ToString()));
                        }
                        else {
                            writer.Write((int)Enum.Parse(field.FieldType, fieldData.ToString()));
                        }

                    } else if ( fieldType.BaseType == typeof( NMSTemplate ) ) {
                        var realData = (NMSTemplate) fieldData;
                        if ( realData == null ) realData = (NMSTemplate) Activator.CreateInstance( fieldType );
                        writer.Align( AlignOf(realData.GetType()), field?.Name ?? fieldType.Name );
                        realData.AppendToWriter( writer, ref additionalData, ref addtDataIndex, GetType(), listEnding );

                    } else {
                        throw new UnknownTypeException( fieldType, field?.Name );
                    }
                    break;
            }
        }

        public void AppendToWriter( BinaryWriter writer, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex, Type parent, UInt32 listEnding = 0xAAAAAA01 ) {
            long templatePosition = writer.BaseStream.Position;
            //Logger.LogDebug( $"[C] writing {GetType().Name} to offset 0x{templatePosition:X} (parent: {parent.Name})" );
            var type = GetType();
            var fields = type.GetFields().OrderBy( field => field.MetadataToken ); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            //var entryOffsetNamePairs = new Dictionary<long, string>();
            //List<KeyValuePair<long, String>> entryOffsetNamePairs = new List<KeyValuePair<long, String>>();

            if ( type.Name != "EmptyNode" ) {
                foreach ( var field in fields ) {
                    var fieldAddr = writer.BaseStream.Position - templatePosition;      // location of the data within the struct
                    //Logger.LogDebug($"fieldAddr: 0x{fieldAddr:X}, templatePos: 0x{templatePosition:X}, name: {field.FieldType.Name}, value: {field.GetValue(this)}");
                    NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                    var fieldData = field.GetValue(this);
                    SerializeValue( writer, field.FieldType, fieldData, settings, field, ref additionalData, ref addtDataIndex, listEnding );
                }
                writer.Align( AlignOf(type), type.Name ); // This is to remove the need for end padding
            } else {
                SerializeValue( writer, type, null, null, null, ref additionalData, ref addtDataIndex, listEnding );
            }
        }

        public void SerializeGenericList( BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex, UInt32 listEnding )
        // This serialises a List of NMSTemplate objects
        {
            writer.Align( 0x8, list.GetType().Name );       // Make sure that all c~ names are offset at 0x8.     // make rel to listHeaderPosition?
            long listPosition = writer.BaseStream.Position;

            DebugLogTemplate( $"SerializeList\tstart:\t{$"0x{listPosition:X},",-10}\theader:\t{$"0x{listHeaderPosition:X},",-10}\tcount:\t{list.Count}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if ( list.Count > 0 ) {
                //DebugLog($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");
                writer.Write( listPosition - listHeaderPosition );
            } else {
                writer.Write( (long) 0 ); // lists with 0 entries have offset set to 0
            }

            writer.Write( (Int32) list.Count );
            writer.Write( listEnding );

            // reserve space for list offsets+names + NameHash's
            writer.BaseStream.Position = listPosition;
            writer.Write( new byte[list.Count * 0x50] );              // this seems to need to be reserved even if there are no elements (check?)

            int addtDataIndexThis = 0;

            //var entryOffsetNamePairs = new Dictionary<long, string>();
            List<KeyValuePair<long, String>> entryOffsetNamePairs = new List<KeyValuePair<long, String>>();
            foreach ( var entry in list ) {
                string entryName = entry.GetType().Name;
                writer.Align( AlignOf(entry.GetType()), entryName );
                //Logger.LogDebug($"pos 0x{writer.BaseStream.Position:X}");
                //Logger.LogDebug(entry.GetType().Name);
                entryOffsetNamePairs.Add( new KeyValuePair<long, string>( writer.BaseStream.Position, entryName) );

                var template = (NMSTemplate) entry;
                var listObjects = new List<Tuple<long, object>>();     // new list of objects so that this data is serialised first
                var addtData = new Dictionary<long, object>();
                //Logger.LogDebug( $"[C] writing {template.GetType().Name} to offset 0x{writer.BaseStream.Position:X}" );
                // pass the new listObject object in place of additionalData so that this branch is serialised before the whole layer
                template.AppendToWriter( writer, ref listObjects, ref addtDataIndexThis, GetType() );
                for ( int i = 0; i < listObjects.Count; i++ ) {
                    var data = listObjects[i];
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates
                    if ( data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof( List<> ) ) {
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];

                        if ( itemType == typeof( NMSTemplate ) ) {
                            SerializeGenericList( writer, (IList) data.Item2, data.Item1, ref listObjects, i + 1, listEnding );
                        } else {
                            SerializeList( writer, (IList) data.Item2, data.Item1, ref listObjects, i + 1, listEnding );
                        }
                    } else {
                        writer.Align( AlignOf(data.Item2.GetType()), data.Item2.GetType().Name );
                        long origPos = writer.BaseStream.Position;
                        //DebugLog("this is it!!!");
                        //DebugLog($"0x{origPos:X}");
                        // first, write the correct offset at the correct location
                        long headerPos = data.Item1;
                        writer.BaseStream.Position = headerPos;
                        long offset = origPos - headerPos;
                        writer.Write( offset );
                        writer.BaseStream.Position = origPos;
                        var GenericObject = data.Item2;
                        int newDataIndex = i + 1;
                        SerializeValue( writer, GenericObject.GetType(), GenericObject, null, null, ref listObjects, ref newDataIndex, listEnding );
                    }
                }

            }

            long dataEndOffset = writer.BaseStream.Position;

            writer.BaseStream.Position = listPosition;
            foreach ( KeyValuePair<long, string> kvp in entryOffsetNamePairs ) {
                // Iterate through the list headers and write the correct data
                if ( kvp.Value != "EmptyNode" ) {
                    //long tempPos = writer.BaseStream.Position;
                    writer.Align( 0x8, kvp.Value.GetType().Name );
                    //long correction = writer.BaseStream.Position - tempPos;
                    // in this case, we have an actual non-empty header.
                    long position = writer.BaseStream.Position;
                    long offset = kvp.Key - position; // get offset of this entry from the current offset
                    writer.Write( offset );
                    //DebugLog(kvp.Value);
                    writer.WriteString( "c" + kvp.Value, Encoding.UTF8, 0x40 );
                    // Get the NameHash
                    ulong NameHash = GetTemplateType(kvp.Value)?.GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0;
                    if ( NameHash != 0 ) {
                        writer.Write( NameHash );
                    } else {
                        throw new InvalidGUIDException( TemplateFromName( kvp.Value ) );
                    }
                    //DebugLog(kvp.Value);
                    //DebugLog(offset);
                } else {
                    // this is called when the header 0x50 bytes is empty because it is an empty node.
                    writer.WriteString( "", Encoding.UTF8, 0x50 );
                }
            }

            writer.BaseStream.Position = dataEndOffset;
        }

        public void SerializeList( BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData, int addtDataIndex, UInt32 listEnding = (UInt32) 0xAAAAAA01 ) {
            // first thing we want to do is align the writer with the location of the first element of the list
            if ( list.Count != 0 ) {
                writer.Align( AlignOf(list[0].GetType()), list[0].GetType().Name );
            }

            long listPosition = writer.BaseStream.Position;
            //Logger.LogDebug( $"SerializeList\tstart:\t{$"0x{listPosition:X},",-10}\theader:\t{$"0x{listHeaderPosition:X},",-10}\tcount:\t{list.Count}" );

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if ( list.Count > 0 ) {
                writer.Write( listPosition - listHeaderPosition );
            } else {
                writer.Write( (long) 0 ); // lists with 0 entries have offset set to 0
            }
            writer.Write( (Int32) list.Count );
            writer.Write( listEnding );       // this is where the 4bytes at the end of a list are written

            writer.BaseStream.Position = listPosition;

            var listObjects = new List<Tuple<long, object>>();     // new list of objects so that this data is serialised first

            int addtDataIndexThis = addtDataIndex;

            foreach ( var entry in list ) {
                DebugLogTemplate( $"[C] writing {entry.GetType().Name} to offset 0x{writer.BaseStream.Position:X}" );
                SerializeValue( writer, entry.GetType(), entry, null, null, ref additionalData, ref addtDataIndexThis, listEnding );
            }
        }

        public byte[] SerializeBytes() {
            using ( var stream = new MemoryStream() )
            using ( var writer = new BinaryWriter( stream, Encoding.ASCII ) ) {
                var additionalData = new List<Tuple<long, object>>();

                UInt32 listEnding = 0xAAAAAA01;

                if ( GetType() == typeof( NMS.Toolkit.TkAnimMetadata ) ) {
                    listEnding = 0xFEFEFE01;
                } else if ( GetType() == typeof( NMS.Toolkit.TkGeometryStreamData ) || GetType() == typeof( NMS.Toolkit.TkGeometryData ) ) {
                    listEnding = 0x00000001;
                }

                int i = 0;
                // write primary template + any embedded templates
                AppendToWriter( writer, ref additionalData, ref i, GetType(), listEnding );

                // now write values of lists etc
                for ( i = 0; i < additionalData.Count; i++ ) {
                    var data = additionalData[i];
                    //DebugLog($"Current i: {i}");
                    //DebugLog(data);
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates

                    if ( data.Item2 == null ) {
                        SerializeList( writer, new List<int>(), data.Item1, ref additionalData, i + 1, listEnding );  // pass an empty list. Data type doesn't matter...
                        continue;
                    }

                    NMSAttribute settings = data.Item2?.GetType().GetCustomAttribute<NMSAttribute>();

                    if ( data.Item2.GetType() == typeof( NMS.VariableSizeString ) ) {
                        var str = (NMS.VariableSizeString) data.Item2;

                        var stringPos = writer.BaseStream.Position;
                        writer.WriteString( str.Value, Encoding.UTF8, null, true );
                        var stringEndPos = writer.BaseStream.Position;

                        writer.BaseStream.Position = data.Item1;
                        writer.Write( stringPos - data.Item1 );
                        writer.Write( (Int32) (stringEndPos - stringPos) );
                        writer.Write( listEnding );

                        writer.BaseStream.Position = stringEndPos;

                    } else if ( data.Item2.GetType().BaseType == typeof( NMSTemplate ) ) {
                        writer.Align( AlignOf(data.Item2.GetType()), data.Item2.GetType().Name );
                        var pos = writer.BaseStream.Position;
                        var template = (NMSTemplate) data.Item2;
                        int i2 = i + 1;
                        template.AppendToWriter( writer, ref additionalData, ref i2, GetType(), listEnding );
                        var endPos = writer.BaseStream.Position;
                        writer.BaseStream.Position = data.Item1;
                        writer.Write( pos - data.Item1 );
                        writer.WriteString( "c" + template.GetType().Name, Encoding.UTF8, 0x40 );
                        ulong NameHash = settings?.NameHash ?? 0;
                        if (NameHash != 0) {
                            writer.Write(NameHash);
                        }
                        else {
                            throw new InvalidGUIDException(template);
                        }
                        writer.BaseStream.Position = endPos;

                    } else if ( data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof( List<> ) ) {
                        // this will serialise a dynamic length list of either a generic type, or a specific type
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                        if ( itemType == typeof( NMSTemplate ) ) {
                            // this is serialising a list of generic type
                            SerializeGenericList( writer, (IList) data.Item2, data.Item1, ref additionalData, i + 1, listEnding );
                        } else {
                            // this is serialising a list if a particular type
                            SerializeList( writer, (IList) data.Item2, data.Item1, ref additionalData, i + 1, listEnding );
                        }

                    } else if ( data.Item2.GetType() == typeof( byte[] ) ) {
                        // write the offset in the list header
                        long dataPosition = writer.BaseStream.Position;
                        writer.BaseStream.Position = data.Item1;
                        writer.Write( dataPosition - data.Item1 );
                        writer.BaseStream.Position = dataPosition;
                        SerializeValue( writer, data.Item2.GetType(), data.Item2, settings, null, ref additionalData, ref i );     // passing i here *should* be fine as we will only be writing bytes which can't affect i

                    } else {
                        throw new UnknownTypeException( data.Item2.GetType() );

                    }

                }

                return stream.ToArray();
            }
        }
        public EXmlBase SerializeEXmlValue(Type fieldType, FieldInfo field, NMSAttribute settings, object value, bool isField = true)
        {
            string t = fieldType.Name;
            int i = 0;
            string valueString = String.Empty;

            if ( settings?.DefaultValue != null ) {
                value = settings.DefaultValue;
            }

            switch (fieldType.Name)
            {
                case "String":
                case "Boolean":
                case "Byte":
                case "Int16":
                case "UInt16":
                case "Int32":
                case "UInt32":
                case "Int64":
                case "UInt64":
                    valueString = value?.ToString() ?? "";
                    if (fieldType.Name != "Int32") break;

                    if ((int) value == -1 ) break;
                    var dictData = GetType().GetMethod(field.Name + "Dict");
                    if ( dictData != null ) {
                        Dictionary<int, string> dataDict = (Dictionary<int, string>) dictData.Invoke( this, null );
                        valueString = dataDict[(int) value];
                    }

                    break;
                case "Single":
                    // prefer the default, short-form string format
                    valueString = ((float) value).ToString( System.Globalization.CultureInfo.InvariantCulture);
                    if ( float.Parse( valueString ) != (float) value ) { // the default string format may not be accurate
                        // if it's not accurate enough, then use the full-precision format
                        valueString = ((float) value).ToString( "G9", System.Globalization.CultureInfo.InvariantCulture );
                    }
                    break;
                case "Double":
                    // prefer the default, short-form string format
                    valueString = ((double) value).ToString( System.Globalization.CultureInfo.InvariantCulture);
                    if ( double.Parse( valueString ) != (double) value ) { // the default string format may not be accurate
                        // if it's not accurate enough, then use the full-precision format
                        valueString = ((double) value).ToString( "G17", System.Globalization.CultureInfo.InvariantCulture );
                    }
                    break;
                case "Byte[]":
                    valueString = value == null ? null : Convert.ToBase64String((byte[])value);
                    break;
                case "List`1":
                    var listType = field.FieldType.GetGenericArguments()[0];
                    EXmlProperty listProperty = new EXmlProperty {
                        Name = field.Name
                    };

                    IList templates = (IList)value;
                    if ( templates != null ) {
                        i = 0;
                        foreach ( var template in templates ) {
                            EXmlBase data = SerializeEXmlValue( listType, field, settings, template, false );
                            data.Name = null;

                            listProperty.Elements.Add( data );
                        }
                    }

                    return listProperty;
                case "NMSTemplate":
                    if ( value != null ) {
                        NMSTemplate template = (NMSTemplate) value;

                        var templateXmlData = template.SerializeEXml( true );
                        templateXmlData.Name = field.Name;

                        return templateXmlData;
                    }
                    return null;
                default:
                    if( typeof(NMS.INMSString).IsAssignableFrom(fieldType) && isField)
                    {
                        // We will shortcut the deserialization by simply assigning the value
                        valueString = ((NMS.INMSString)value).StringValue();
                        break;
                    }
                    if ( fieldType.BaseType.Name == "NMSTemplate" ) {
                        NMSTemplate template;
                        if ( value is null ) {
                            template = TemplateFromName( fieldType.Name );
                        } else {
                            template = (NMSTemplate) value;
                        }

                        var templateXmlData = template.SerializeEXml( true );
                        templateXmlData.Name = field.Name;

                        return templateXmlData;
                    } else if ( fieldType.IsArray ) {
                        var arrayType = field.FieldType.GetElementType();
                        EXmlProperty arrayProperty = new EXmlProperty {
                            Name = field.Name
                        };

                        Array array = (Array) value;
                        string[] names = GetEnumNames( field.Name, array.Length, settings );

                        i = 0;
                        foreach ( var template in array ) {
                            EXmlBase data = SerializeEXmlValue( arrayType, field, settings, template, false );
                            data.Name = names[i++];

                            arrayProperty.Elements.Add( data );
                        }

                        return arrayProperty;
                    } else if ( fieldType.IsEnum ) {
                        // output MaterialFlagEnum as UberFlagEnum
                        if ( field.FieldType == typeof( NMS.Toolkit.TkMaterialFlags.MaterialFlagEnum ) ) {
                            valueString = ((NMS.Toolkit.TkMaterialFlags.UberFlagEnum) value).ToString();
                        } else {
                            valueString = value?.ToString();
                        }
                        break;
                    } else {
                        throw new UnknownTypeException( field.FieldType, field.Name );
                    }
            }

            return new EXmlProperty {
                Name = field.Name,
                Value = valueString
            };
        }

        /// <summary>
        /// Gets an array of named indices for an EnumArray.
        /// If the field is not an EnumArray, the names of the indices will be null.
        /// </summary>
        private static string[] GetEnumNames( string fieldName, NMSAttribute settings ) {
            return GetEnumNames( fieldName, settings?.Size ?? 0, settings );
        }

        /// <summary>
        /// Gets an array of named indices for an EnumArray.
        /// If the field is not an EnumArray, the names of the indices will be null.
        /// </summary>
        private static string[] GetEnumNames( string fieldName, int arrayLength, NMSAttribute settings ) {
            // TODO: refactor this once EnumValue is no longer used.

            // handle EnumArray names
            string[] names = new string[arrayLength]; // default is all nulls

            Type enumType = settings?.EnumType;
            string[] enumValues = settings?.EnumValue;
            int length = enumValues?.Length ?? 0; // TODO: deprecated
            if ( enumType != null ) { // has EnumType setting
                if ( !enumType.IsEnum ) {
                    throw new APIException( $"Invalid type: {enumType}\n" +
                                            $"The EnumType attribute for {fieldName} must be an Enum type!" );
                }
                names = Enum.GetNames( enumType );
                length = names.Length;

            // TODO: deprecated
            } else if ( length != 0 ) { // has EnumValue setting
                length = Math.Min( names.Length, length ); // make sure we don't go out of bounds
                for ( int i = 0; i < length; i++ ) names[i] = enumValues[i];
            }

            if ( (length == 0) && (arrayLength == 0) ) { // invalid, can't determine array size
                throw new APIException( $"The array {fieldName} must have an NMSAttribute with a Size or EnumType setting" );

            } else if ( length != 0 ) { // is EnumArray
                // validate that length matches, unless arrayLength is 0 (auto/don't care)
                if ( (arrayLength != 0) && (arrayLength != length) ) {
                    string enumTypeName = enumType?.ToString() ?? "EnumValue";
                    EmitWarning( $"The defined Size for {fieldName} does not match the length of {enumTypeName}!\n" +
                                            $"{"0x" + arrayLength.ToString("X")} != {"0x" + length.ToString("X")}" );
                }

                // if the field has both an EnumType and EnumValue setting, then make sure they match
                if ( (enumType != null) && (enumValues != null)) {
                    var enumTypeNames  = Enum.GetNames( enumType );
                    if ( enumTypeNames.Length != enumValues.Length ) {
                        EmitWarning( $"{fieldName}: The length of EnumType != EnumValue.Length!" );
#if DEBUG
                    } else {
                        throw new APIException( $"{fieldName}: EnumType and EnumValue match. Remove EnumValue" );
#endif
                    }

                    for ( int i = 0; i < enumValues.Length; i++ ) {
                        if ( enumTypeNames[i] != enumValues[i] ) EmitWarning( $"{fieldName}: EnumType does not match EnumValue!" );
                    }
                }
            }

            return names;
        }

        private static void EmitWarning( string msg ) {
            #if DEBUG
                throw new APIException( msg );
            #else
                Logger.LogWarning( msg + "\nThis is NOT an issue with your MBIN or EXML file and can be ignored.\nIf you are seeing this message however, please report it.");
            #endif
        }

        private static int GetArrayLength( string fieldName, NMSAttribute settings ) {
            return GetEnumNames( fieldName, settings ).Length;
        }

        public EXmlBase SerializeEXml(bool isChildTemplate) {
            Type type = GetType();
            string typeName = type.Name != "NMSString0x20A" ? type.Name : "NMSString0x20";
            EXmlBase xmlData = new EXmlProperty { Value = typeName + ".xml" };

            if ( !isChildTemplate ) {
                xmlData = new EXmlData { Template = type.Name };
            }

            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach ( var field in fields ) {

                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                if ( settings == null ) settings = new NMSAttribute();
                if ( settings.Ignore ) continue;

                xmlData.Elements.Add( SerializeEXmlValue( field.FieldType, field, settings, field.GetValue( this ) ) );
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
                case "Byte":
                    return byte.Parse(xmlProperty.Value);
                case "Int16":
                    return short.Parse(xmlProperty.Value);
                case "UInt16":
                    return ushort.Parse(xmlProperty.Value);
                case "Int32":
                    var valuesMethod = templateType.GetMethod(field.Name + "Values");
                    // TODO: remove this dictionary stuff
                    var dictData = templateType.GetMethod(field.Name + "Dict");

                    if ( dictData != null ) {
                        if ( String.IsNullOrEmpty( xmlProperty.Value ) ) return -1;

                        Dictionary<int, string> dataDict = (Dictionary<int, string>) dictData.Invoke( template, null );
                        int key = dataDict.Where( kvp => kvp.Value == xmlProperty.Value ).Select( kvp => kvp.Key ).FirstOrDefault();
                        return key;
                    }

                    if ( valuesMethod != null ) {
                        if ( String.IsNullOrEmpty( xmlProperty.Value ) ) return -1;

                        string[] values = (string[]) valuesMethod.Invoke( template, null );
                        return Array.FindIndex( values, v => v == xmlProperty.Value );
                    //} else if (settings?.EnumValue != null) {
                    //    if (String.IsNullOrEmpty(xmlProperty.Value)) return -1;
                    //    return Array.FindIndex(settings.EnumValue, v => v == xmlProperty.Value);
                    } else {
                        return int.Parse( xmlProperty.Value );
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

                        var type = innerXmlData.GetType();
                        var data = innerXmlData as EXmlProperty;
                        if (typeof(NMS.INMSString).IsAssignableFrom(elementType) && elementType.Name == "NMSString0x20A") {
                            // If the data is actually a NMSString0x20A, then make sure we try and serialize it as such.
                            data.Value = "NMSString0x20A.xml";
                        }
                        type = (data?.Value.EndsWith( ".xml" ) ?? false) ? typeof( EXmlData ) : type;

                        if (type == typeof(EXmlProperty)) {
                            element = DeserializeEXmlValue(template, elementType, field, (EXmlProperty)innerXmlData, templateType, settings);
                        }  else if (type == typeof(EXmlData)) {
                            element = DeserializeEXml(innerXmlData); // child template if <Data> tag or <Property> tag with value ending in .xml (todo: better way of finding <Property> child templates)
                        } else if (type == typeof(EXmlMeta)) {
                            DebugLogComment(((EXmlMeta)innerXmlData).Comment);
                        }

                        if ( element == null) throw new TemplateException( "element == null ??!" );

                        list.Add(element);
                    }
                    return list;
                default:
                    if (typeof(NMS.INMSString).IsAssignableFrom(fieldType))
                    {
                        object stringObj = (NMS.INMSString)Activator.CreateInstance(fieldType);
                        FieldInfo valueField = stringObj.GetType().GetField("Value");
                        valueField.SetValue(stringObj, xmlProperty.Value);
                        return stringObj;
                    }
                    if (field.FieldType.IsArray && field.FieldType.GetElementType().BaseType.Name == "NMSTemplate") {
                        int length = GetArrayLength( field.Name, settings );
                        Array array = Array.CreateInstance(field.FieldType.GetElementType(), length);
                        //var data = xmlProperty.Elements.OfType<EXmlProperty>().ToList();
                        List<EXmlBase> data = xmlProperty.Elements.ToList();
                        int numMeta = 0;
                        foreach (EXmlBase entry in data) {
                            if (entry.GetType() == typeof(EXmlMeta)) numMeta++;
                        }

                        if ( (data.Count - numMeta) != length ) {
                            // todo: add a comment in the XML to indicate arrays (+ their size), also need to do the same for showing valid enum values
                            throw new ArraySizeException( field.Name, (data.Count - numMeta), length );
                        }

                        for (int i = 0; i < data.Count; ++i) {
                            if (data[i].GetType() == typeof(EXmlProperty)) {
                                NMSTemplate element = DeserializeEXml(data[i]);
                                array.SetValue(element, i - numMeta);
                            } else if (data[i].GetType() == typeof(EXmlMeta)) {
                                DebugLogComment(((EXmlMeta)data[i]).Comment);     // don't need to worry about nummeta here since it is already counted above...
                            }
                        }

                        return array;
                    } else if (field.FieldType.IsArray) {
                        int length = GetArrayLength( field.Name, settings );
                        Array array = Array.CreateInstance(field.FieldType.GetElementType(), length);
                        //List<EXmlProperty> data = xmlProperty.Elements.OfType<EXmlProperty>().ToList();
                        List<EXmlBase> data = xmlProperty.Elements.ToList();
                        int numMeta = 0;
                        for (int i = 0; i < data.Count; ++i) {
                            if (data[i].GetType() == typeof(EXmlProperty)) {
                                object element = DeserializeEXmlValue(template, field.FieldType.GetElementType(), field, (EXmlProperty)data[i], templateType, settings);
                                array.SetValue(element, i - numMeta);
                            } else if (data[i].GetType() == typeof(EXmlMeta)) {
                                DebugLogComment(((EXmlMeta)data[i]).Comment);
                                numMeta += 1;           // increment so that the actual data is still placed at the right spot
                            }
                        }

                        return array;
                    } else if (field.FieldType.IsEnum) {
                        try {
                            Type enumType = Enum.GetUnderlyingType(field.FieldType);
                            if (enumType.Name == "UInt32") {
                                return (uint)Enum.Parse(field.FieldType, xmlProperty.Value);
                            } else {
                                return (int)Enum.Parse(field.FieldType, xmlProperty.Value);
                            }
                        } catch (ArgumentException) {
                            // material flags can have a custom suffix
                            if ( field.FieldType == typeof( libMBIN.NMS.Toolkit.TkMaterialFlags.MaterialFlagEnum ) ) {
                                // if we got here, then we know that Value is an identifier and not an integer
                                // trim the custom suffix
                                return (int) Enum.Parse( field.FieldType, xmlProperty.Value.Substring( 0, 5 ) ); // "_FXX_"
                            } else {
                                throw new InvalidEnumValueException(xmlProperty.Value.ToString(), field);
                            }
                        }
                    } else {
                        return fieldType.IsValueType ? Activator.CreateInstance(fieldType) : null;
                    }
            }
        }

        public static NMSTemplate DeserializeEXml( EXmlBase xmlData ) {    // this is the inital code that is run when converting exml to mbin.
        // this code is run to parse over the exml file and put it into a data structure that is processed by SerializeBytes() (I think...)

            NMSTemplate template = null;

            //DebugLog(xmlData.Name);
            //DebugLog(xmlData.GetType().ToString());

            if ( xmlData.GetType() == typeof( EXmlData ) ) {
                template = TemplateFromName( ((EXmlData) xmlData).Template );
            } else if ( xmlData.GetType() == typeof( EXmlProperty ) ) {
                template = TemplateFromName( ((EXmlProperty) xmlData).Value.Replace( ".xml", "" ) );
            } else if ( xmlData.GetType() == typeof( EXmlMeta ) ) {
                DebugLogComment( ((EXmlMeta) xmlData).Comment );
            }

            /*
            DebugLog("Getting types");
            foreach (var property in xmlData.Elements)
            {
                DebugLog(property.GetType());
            }*/

            if (template == null) return null;

            Type templateType = template.GetType();
            var templateFields = templateType.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach (var templateField in templateFields) {
                // check to see if the object has a default value in the struct
                NMSAttribute settings = templateField.GetCustomAttribute<NMSAttribute>();
                if (settings?.DefaultValue != null) templateField.SetValue(template, settings.DefaultValue);
            }

            using ( var indentScope = new Logger.IndentScope() ) {

                foreach ( var xmlElement in xmlData.Elements ) {
                    if ( xmlElement.GetType() == typeof( EXmlProperty ) ) {
                        EXmlProperty xmlProperty = (EXmlProperty) xmlElement;
                        FieldInfo field = templateType.GetField( xmlProperty.Name );
                        object fieldValue = null;
                        DebugLogPropertyName( xmlProperty.Name );
                        if ((field.FieldType == typeof( NMSTemplate ) || field.FieldType.BaseType == typeof( NMSTemplate ))
                            && !typeof(NMS.INMSString).IsAssignableFrom(field.FieldType)) {
                            fieldValue = DeserializeEXml( xmlProperty );
                        } else {
                            Type fieldType = field.FieldType;
                            NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                            fieldValue = DeserializeEXmlValue( template, fieldType, field, xmlProperty, templateType, settings );
                        }
                        field.SetValue( template, fieldValue );
                    } else if ( xmlElement.GetType() == typeof( EXmlData ) ) {
                        EXmlData innerXmlData = (EXmlData) xmlElement;
                        FieldInfo field = templateType.GetField( innerXmlData.Name );
                        NMSTemplate innerTemplate = DeserializeEXml( innerXmlData );
                        field.SetValue( template, innerTemplate );
                    } else if ( xmlElement.GetType() == typeof( EXmlMeta ) ) {
                        EXmlMeta xmlMeta = (EXmlMeta) xmlElement;
                        string comment = xmlMeta.Comment;
                        DebugLogComment( comment );
                    }
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
                DebugLog("Hello!!!");
                string comment = xmlProperty.Comment;
                DebugLog(comment);
            }*/

            return template;
        }
        
        /// <summary>
        /// Serialises the NMSTemplate object to a .mbin file with default header information.
        /// </summary>
        /// <param name="outputpath">The location to write the .mbin file.</param>
        public void WriteToMbin(string outputpath)
        {
            using (var file = new MBINFile(outputpath))
            {
                file.Header = new MBINHeader();
                var type = this.GetType();
                file.Header.SetDefaults(type);
                file.SetData(this);
                file.Save();
            }
        }

        /// <summary>
        /// Writes the NMSTemplate object to an .exml file.
        /// </summary>
        /// <param name="outputpath">The location to write the .exml file.</param>
        public void WriteToExml(string outputpath) => WriteToExml(outputpath, false);
        /// <summary>
        /// Writes the NMSTemplate object to an .exml file.
        /// </summary>
        /// <param name="outputpath">The location to write the .exml file.</param>
        /// <param name="hideVersionInfo">If true, version info is not written to the EXML file.</param>
        public void WriteToExml(string outputpath, bool hideVersionInfo)
        {
            var data = EXmlFile.WriteTemplate(this, hideVersionInfo);
            File.WriteAllText(outputpath, data);
        }

        public string GetID()
        {
            string ID = null;
            var type = GetType();
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                if (settings?.IDField ?? false)
                {
                    ID = field.GetValue(this).ToString();
                    return ID;
                }
            }
            return ID;
        }

        // func thats run after template is deserialized, can be used for checks etc
        public void FinishDeserialize() { }

        public virtual object CustomDeserialize( BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo ) {
            return null;
        }

        public virtual bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
        {
            return false;
        }
    }
}

using System;
using System.Reflection;

namespace libMBIN {

    /// <summary>
    /// The base class for all template-related exceptions in the de/serializer.
    /// </summary>
    public class TemplateException : APIException {
        private const string DEFAULT_MESSAGE = "An unknown exception has been encountered while processing a template.";
        public TemplateException()                                           : base( DEFAULT_MESSAGE ) { }
        public TemplateException( string message )                           : base( message ) { } 
        public TemplateException(                 Exception innerException ) : base( DEFAULT_MESSAGE, innerException ) { }
        public TemplateException( string message, Exception innerException ) : base( message, innerException ) { }
    }

    public class UnknownTypeException : TemplateException {
        public UnknownTypeException()                         : base( GetString() ) { }
        public UnknownTypeException( Type type )              : base( GetString( type ) ) { }
        public UnknownTypeException( Type type, string name ) : base( GetString( type, name ) ) { }

        private static string GetString( Type type = null, string name = null ) {
            return $"Unknown type {((type != null) ? $" {type}" : "")}{(( ( name ?? "" ) != "" ) ? $" for {name}" : "")}.";
        }
    }

    public class InvalidEnumValueException : TemplateException
    {
        public InvalidEnumValueException(string badValue, FieldInfo field) : base($"The enum value \"{badValue}\" is not a valid value for {field.Name}.") { }
    }

    public class InvalidGUIDException : TemplateException {
        public InvalidGUIDException(NMSTemplate template) : base($"The template {template.GetType().Name} has no provided NameHash. Please raise an issue on GitHub!") { }
    }

    public class GUIDMismatchException : TemplateException {
        public GUIDMismatchException(ulong readGUID, ulong expectedGUID, NMSTemplate template) : base( GetString(readGUID, expectedGUID, template) ) { }

        private static string GetString (ulong readGUID, ulong expectedGUID, NMSTemplate template)
        {
            return $"Mismatch between GUID for struct {template.GetType().Name}.\n" +
                   $"GUID read: {readGUID.ToString()}, expected GUID: {expectedGUID.ToString()}.";
        }
    }

    public class InvalidListException : TemplateException {
        public InvalidListException( uint magic, long pos ) : base( $"Invalid list read, magic {magic:X8} expected xxxxxx01 at 0x{pos:X}" ) { }
    }

    public class DeserializeTemplateException : TemplateException {
        public DeserializeTemplateException( string name ) : base( $"Failed to deserialize template {name}!" ) { }
    }

    public class DeserializeTypeException : TemplateException {
        public DeserializeTypeException( string name ) : base( $"Failed to deserialize type {name}!" ) { }
        public DeserializeTypeException( Type type )   : this( type.Name ) { }
    }

    public class NullDataException : TemplateException {
        public NullDataException( string dataTypeName ) : base( $"{dataTypeName} data was null!" ) { }
    }

    public class ArraySizeException : TemplateException {
        public ArraySizeException( string fieldName, int actualSize, int expectedSize ) : base( GetString( fieldName, actualSize, expectedSize ) ) { }

        private static string GetString( string fieldName, int actualSize, int expectedSize ) {
            return $"{fieldName}: XML array size {actualSize} doesn't match expected array size {expectedSize}\n" +
                    "You might have added/removed an item from an array field\n" +
                    "(arrays can't be shortened or extended as they're a fixed size set by the game)";
        }
    }

    public class MbinException : TemplateException
    {
        public MbinException(string fieldName, Exception innerException, string fileName) : base(GetString(fieldName, fileName), innerException) {}

        private static string GetString( string fieldName, string fileName)
        {
            return $"Failed to read {fieldName} from {fileName}";
        }
    }
}

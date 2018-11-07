using System;

namespace libMBIN {

    /// <summary>
    /// The base class for all template-related exceptions in the de/serializer.
    /// </summary>

    [Serializable]
    public class TemplateException : APIException {
        private const string DEFAULT_MESSAGE = "An unknown exception has been encountered while processing a template.";
        public TemplateException()                                           : base( DEFAULT_MESSAGE ) { }
        public TemplateException( string message )                           : base( message ) { } 
        public TemplateException(                 Exception innerException ) : base( DEFAULT_MESSAGE, innerException ) { }
        public TemplateException( string message, Exception innerException ) : base( message, innerException ) { }
    }

    [Serializable]
    public class UnknownTypeException : TemplateException {
        public UnknownTypeException()                         : base( GetString() ) { }
        public UnknownTypeException( Type type )              : base( GetString( type ) ) { }
        public UnknownTypeException( Type type, string name ) : base( GetString( type, name ) ) { }

        private static string GetString( Type type = null, string name = null ) {
            return $"Unknown type {((type != null) ? $" {type}" : "")}{(( ( name ?? "" ) != "" ) ? $" for {name}" : "")}.";
        }
    }

    [Serializable]
    public class InvalidListException : TemplateException {
        public InvalidListException( uint magic ) : base( $"Invalid list read, magic {magic:X8} expected xxxxxx01" ) { }
    }

    [Serializable]
    public class DeserializeTemplateException : TemplateException {
        public DeserializeTemplateException( string name ) : base( $"Failed to deserialize template {name}!" ) { }
    }
    
    [Serializable]
    public class DeserializeTypeException : TemplateException {
        public DeserializeTypeException( string name ) : base( $"Failed to deserialize type {name}!" ) { }
        public DeserializeTypeException( Type type )   : this( type.Name ) { }
    }

    [Serializable]
    public class NullDataException : TemplateException {
        public NullDataException( string dataTypeName ) : base( $"{dataTypeName} data was null!" ) { }
    }

    [Serializable]
    public class ArraySizeException : TemplateException {
        public ArraySizeException( string fieldName, int actualSize, int expectedSize ) : base( GetString( fieldName, actualSize, expectedSize ) ) { }

        private static string GetString( string fieldName, int actualSize, int expectedSize ) {
            return $"{fieldName}: XML array size {actualSize} doesn't match expected array size {expectedSize}\n" +
                    "You might have added/removed an item from an array field\n" +
                    "(arrays can't be shortened or extended as they're a fixed size set by the game)";
        }
    }

    [Serializable]
    public class MbinException : TemplateException
    {
        public MbinException(string fieldName, Exception innerException, string fileName) : base(GetString(fieldName, fileName), innerException) {}

        private static string GetString( string fieldName, string fileName)
        {
            return $"Failed to read {fieldName} from {fileName}";
        }
    }
}

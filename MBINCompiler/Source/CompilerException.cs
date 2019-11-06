using System;

using libMBIN;

namespace MBINCompiler {

    internal class AppException : Exception {
        private const string DEFAULT_MESSAGE = "An unknown application exception has occurred!";

        public AppException()                                           : this( DEFAULT_MESSAGE, null           ) { }
        public AppException( string message                           ) : this( message        , null           ) { }
        public AppException(                 Exception innerException ) : this( DEFAULT_MESSAGE, innerException ) { }
        public AppException( string message, Exception innerException ) : base( message        , innerException ) { }
    }

    internal class SecurityException : AppException {
        private const string DEFAULT_MESSAGE = "MBINCompiler must be run as administrator.";

        public SecurityException()                                           : this( DEFAULT_MESSAGE, null           ) { }
        public SecurityException( string message )                           : this( message        , null           ) { }
        public SecurityException(                 Exception innerException ) : this( DEFAULT_MESSAGE, innerException ) { }
        public SecurityException( string message, Exception innerException ) : base( message        , innerException ) { }
    }

    internal class CompilerException : AppException {
        private const string DEFAULT_MESSAGE = "An unknown compiler exception has occurred!";

        public string FileName { get; private set; }

        public CompilerException()                                                            : this( DEFAULT_MESSAGE, null          , ""       ) { }
        public CompilerException( string message )                                            : this( message        , null          , ""       ) { }
        public CompilerException(                 Exception innerException )                  : this( DEFAULT_MESSAGE, innerException, ""       ) { }
        public CompilerException( string message, Exception innerException )                  : this( message        , innerException, ""       ) { }
        public CompilerException(                 Exception innerException, string fileName ) : this( DEFAULT_MESSAGE, innerException, fileName ) { }
        public CompilerException( string message, Exception innerException, string fileName ) : base( message        , innerException           ) {
            this.FileName = fileName;
        }
    }

    internal class MbinException : CompilerException {
        private const string DEFAULT_MESSAGE = "An MBIN exception has occurred!";

        public MBINFile Mbin { get; private set; }

        public MbinException()                                                                           : this( DEFAULT_MESSAGE, null          , ""      , null ) { }
        public MbinException( string message )                                                           : this( message        , null          , ""      , null ) { }
        public MbinException(                 Exception innerException )                                 : this( DEFAULT_MESSAGE, innerException, ""      , null ) { }
        public MbinException( string message, Exception innerException )                                 : this( message        , innerException, ""      , null ) { }
        public MbinException( string message,                           string fileName )                : this( message        , null          , fileName, null ) { }
        public MbinException( string message,                                            MBINFile mbin ) : this( message        , null          , ""      , mbin ) { }
        public MbinException( string message,                           string fileName, MBINFile mbin ) : this( message        , null          , fileName, mbin ) { }
        public MbinException(                 Exception innerException, string fileName )                : this( DEFAULT_MESSAGE, innerException, fileName, null ) { }
        public MbinException(                 Exception innerException,                  MBINFile mbin ) : this( DEFAULT_MESSAGE, innerException, ""      , mbin ) { }
        public MbinException(                 Exception innerException, string fileName, MBINFile mbin ) : this( DEFAULT_MESSAGE, innerException, fileName, mbin ) { }
        public MbinException( string message, Exception innerException, string fileName )                : this( message        , innerException, fileName, null ) { }
        public MbinException( string message, Exception innerException,                  MBINFile mbin ) : this( message        , innerException, ""      , mbin ) { }
        public MbinException( string message, Exception innerException, string fileName, MBINFile mbin ) : base( message        , innerException, fileName       ) {
            this.Mbin = mbin;
        }
    }

    internal class ExmlException : CompilerException {
        private const string DEFAULT_MESSAGE = "An EXML exception has occurred!";

        public new NMSTemplate Data { get; private set; }

        public ExmlException()                                                                              : this( DEFAULT_MESSAGE, null          , ""      , null ) { }
        public ExmlException( string message )                                                              : this( message        , null          , ""      , null ) { }
        public ExmlException(                 Exception innerException )                                    : this( DEFAULT_MESSAGE, innerException, ""      , null ) { }
        public ExmlException( string message, Exception innerException )                                    : this( message        , innerException, ""      , null ) { }
        public ExmlException( string message,                           string fileName )                   : this( message        , null          , fileName, null ) { }
        public ExmlException( string message,                                            NMSTemplate data ) : this( message        , null          , ""      , data ) { }
        public ExmlException( string message,                           string fileName, NMSTemplate data ) : this( message        , null          , fileName, null ) { }
        public ExmlException(                 Exception innerException, string fileName )                   : this( DEFAULT_MESSAGE, innerException, fileName, null ) { }
        public ExmlException(                 Exception innerException,                  NMSTemplate data ) : this( DEFAULT_MESSAGE, innerException, ""      , data ) { }
        public ExmlException(                 Exception innerException, string fileName, NMSTemplate data ) : this( DEFAULT_MESSAGE, innerException, fileName, data ) { }
        public ExmlException( string message, Exception innerException, string fileName )                   : this( message        , innerException, fileName, null ) { }
        public ExmlException( string message, Exception innerException,                  NMSTemplate data ) : this( message        , innerException, ""      , data ) { }
        public ExmlException( string message, Exception innerException, string fileName, NMSTemplate data ) : base( message        , innerException, fileName       ) {
            this.Data = data;
        }
    }

}

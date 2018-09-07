using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libMBIN;
using libMBIN.Models;

namespace MBINCompiler {

    internal class CompilerException : Exception {
        private const string DEFAULT_MESSAGE = "An unknown compiler exception has occurred!";

        public string FileName { get; private set; }

        public CompilerException()                                                            : this( DEFAULT_MESSAGE                           ) { }
        public CompilerException( string message )                                            : base( message                                   ) { }
        public CompilerException(                 Exception innerException )                  : this( DEFAULT_MESSAGE, innerException           ) { }
        public CompilerException( string message, Exception innerException )                  : base( message,         innerException           ) { }
        public CompilerException(                 Exception innerException, string fileName ) : this( DEFAULT_MESSAGE, innerException, fileName ) { }
        public CompilerException( string message, Exception innerException, string fileName ) : this( message,         innerException           ) {
            this.FileName = fileName;
        }
    }

    internal class MbinException : CompilerException {
        private const string DEFAULT_MESSAGE = "An MBIN exception has occurred!";

        public MBINFile Mbin { get; private set; }

        public MbinException()                                                                           : this( DEFAULT_MESSAGE                 ) { }
        public MbinException( string message )                                                           : base( message                         ) { }
        public MbinException(                 Exception innerException )                                 : base( DEFAULT_MESSAGE, innerException ) { }
        public MbinException( string message, Exception innerException )                                 : base( message,         innerException ) { }
        public MbinException( string message,                           string fileName )                : base( message,         null,           fileName       ) { }
        public MbinException( string message,                                            MBINFile mbin ) : this( message,         null,           "",       mbin ) { }
        public MbinException( string message,                           string fileName, MBINFile mbin ) : base( message,         null,           fileName       ) { }
        public MbinException(                 Exception innerException, string fileName )                : base( DEFAULT_MESSAGE, innerException, fileName       ) { }
        public MbinException(                 Exception innerException,                  MBINFile mbin ) : this( DEFAULT_MESSAGE, innerException, "",       mbin ) { }
        public MbinException(                 Exception innerException, string fileName, MBINFile mbin ) : this( DEFAULT_MESSAGE, innerException, fileName, mbin ) { }
        public MbinException( string message, Exception innerException, string fileName )                : base( message,         innerException, fileName       ) { }
        public MbinException( string message, Exception innerException,                  MBINFile mbin ) : this( message,         innerException, "",       mbin ) { }
        public MbinException( string message, Exception innerException, string fileName, MBINFile mbin ) : base( message,         innerException, fileName       ) {
            this.Mbin = mbin;
        }
    }

    internal class ExmlException : CompilerException {
        private const string DEFAULT_MESSAGE = "An EXML exception has occurred!";

        public NMSTemplate Data { get; private set; }

        public ExmlException()                                                                              : this( DEFAULT_MESSAGE                 ) { }
        public ExmlException( string message )                                                              : base( message                         ) { }
        public ExmlException(                 Exception innerException )                                    : base( DEFAULT_MESSAGE, innerException ) { }
        public ExmlException( string message, Exception innerException )                                    : base( message,         innerException ) { }
        public ExmlException( string message,                           string fileName )                   : base( message,         null,           fileName       ) { }
        public ExmlException( string message,                                            NMSTemplate data ) : this( message,         null,           "",       data ) { }
        public ExmlException( string message,                           string fileName, NMSTemplate data ) : base( message,         null,           fileName       ) { }
        public ExmlException(                 Exception innerException, string fileName )                   : base( DEFAULT_MESSAGE, innerException, fileName       ) { }
        public ExmlException(                 Exception innerException,                  NMSTemplate data ) : this( DEFAULT_MESSAGE, innerException, "",       data ) { }
        public ExmlException(                 Exception innerException, string fileName, NMSTemplate data ) : this( DEFAULT_MESSAGE, innerException, fileName, data ) { }
        public ExmlException( string message, Exception innerException, string fileName )                   : base( message,         innerException, fileName       ) { }
        public ExmlException( string message, Exception innerException,                  NMSTemplate data ) : this( message,         innerException, "",       data ) { }
        public ExmlException( string message, Exception innerException, string fileName, NMSTemplate data ) : base( message,         innerException, fileName       ) {
            this.Data = data;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN {

    /// <summary>
    /// The base class for all libMBIN-specific exceptions.
    /// </summary>
    public class APIException : System.Exception {
        private const string DEFAULT_MESSAGE = "An unknown API exception has occured!";
        public APIException()                                           : base( DEFAULT_MESSAGE                 ) { }
        public APIException( string message )                           : base( message                         ) { }
        public APIException(                 Exception innerException ) : base( DEFAULT_MESSAGE, innerException ) { }
        public APIException( string message, Exception innerException ) : base( message,         innerException ) { }
    }

}

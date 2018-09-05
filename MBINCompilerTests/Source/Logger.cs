using System.Diagnostics;
using System.IO;

namespace MBINCompilerTests {

    internal static class Logger {

        public enum DebugLevel { None, Error, Info }
        public static DebugLevel Level { get; set; }

        public static void DebugLog( string msg )      { if ( (int) Level != (int) DebugLevel.None  ) Debug.WriteLine( msg ); }
        public static void DebugLogError( string msg ) { if ( (int) Level >= (int) DebugLevel.Error ) DebugLog( msg ); }
        public static void DebugLogInfo( string msg )  { if ( (int) Level >= (int) DebugLevel.Info  ) DebugLog( msg ); }

        public static string GetLogPath( string path ) {
            return Utils.RelativeToAbsolutePath( RunSettings.LogResultsDir, path );
        }

        public static void LogMessage( StreamWriter streamOut, string msg ) {
            streamOut?.WriteLine( msg );
            Logger.DebugLogInfo( msg );
        }

    }

}

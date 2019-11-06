using System;
using System.IO;

using libMBIN;

namespace MBINCompiler {

    using static CommandLineOptions;
    using Commands;

    public enum ErrorCode {
        Success =  0,
        Unknown,
        CommandLine,
        FileNotFound,
        FileExists,
        FileInvalid,
    }

    internal class Program
    {

        public static int Main( string[] args )
        {

            CommandLine.Initialize();

            Logger.Open( Path.ChangeExtension( Utils.GetExecutablePath(), ".log" ) );
            Logger.EnableTraceLogging = true;

            Logger.LogMessage( "VERSION", $"MBINCompiler v{Version.GetVersionStringCompact()}" );
            Logger.LogMessage( "ARGS", $"\"{string.Join( "\" \"", args )}\"\n" );
            using ( var indent = new Logger.IndentScope() ) {
                Logger.LogMessage( "If you encounter any errors, please submit a bug report and include this log file.\n" +
                                   "Please check that there isn't already a similar issue open before creating a new one.\n" +
                                   "https://github.com/monkeyman192/MBINCompiler/issues\n" );
            }

            var options = new CommandLineParser( args );
            options.AddOptions( null,         OPTIONS_GENERAL   );
            options.AddOptions( "help",       OPTIONS_HELP      );
            options.AddOptions( "version",    OPTIONS_VERSION   );
            options.AddOptions( "convert",    OPTIONS_CONVERT   );
            options.AddOptions( "list",       OPTIONS_LIST      );
            options.AddOptions( "register",   OPTIONS_REGISTER  );
            options.AddOptions( "unregister", OPTIONS_UNREGISTER);

            // save the error state
            bool invalidArguments = !options.Parse( "convert" );

            // get the Quiet option first, before we emit anything
            Quiet = options.GetOptionSwitch( "quiet" );
            if ( Quiet ) {
                Console.SetOut( new StreamWriter( Stream.Null ) );
                Console.SetError( Console.Out );
            }

            // now we can emit an error if we need to
            if ( invalidArguments ) return CommandLine.ShowInvalidCommandLineArg( options );

            // initialize remaining global options
            DebugMode = options.GetOptionSwitch( "debug" );

            // execute the appropriate mode
            try {
                switch (options.Verb) {
                    case "help":       return HelpCommand.Execute( options );
                    case "version":    return VersionCommand.Execute( options );
                    case "register":   return RegisterCommand.Execute( options );
                    case "unregister": return RegisterCommand.Execute( options );
                    case "list":       return ListCommand.Execute( options );
                    default:           return ConvertCommand.Execute( options );
                }
            } catch ( System.Exception e ) {
                return CommandLine.ShowException( e );
            }

        }

    }
}

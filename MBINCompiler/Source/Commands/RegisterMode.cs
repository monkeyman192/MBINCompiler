using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using Microsoft.Win32;

namespace MBINCompiler.Commands {

    internal class RegisterCommand : Command<RegisterCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            var isRegisterMode = options.Verb.Equals( "register" );

            libMBIN.Logger.LogInfo( $"{(isRegisterMode ? "Registering" : "Unregistering")} Windows system settings for MBINCompiler.\n" );
            libMBIN.Logger.LogMessage( "INFO", $"Running as Admin: {IsAdministrator()}\n" ); // only output to log file

            try {
                if ( isRegisterMode ) {
                    var fileParams = options.GetFileParams();
                    if ( fileParams.Count > 1 ) return CommandLine.ShowInvalidCommandLineArg( fileParams[1] );
                    Register( (fileParams.Count > 0) ? fileParams[0] : null );
                } else {
                    Unregister();
                }

            } catch ( System.Security.SecurityException ) {
                var exe  = Utils.GetExecutablePath();
                var log = Path.ChangeExtension( exe, ".log" );

                var argv = options.CommandLineArgs;
                for (int i = 0; i < argv.Count; i++) argv[i] = $"\"{argv[i]}\"";
                var args = string.Join( " ", argv );

                libMBIN.Logger.LogWarning( $"Administrator permissions are required. Invoking elevated process.\n\"{exe}\" {args}" );

                // If the log file is already locked by this process, the new process will fail to open the log for writing.
                // So temporarily close the log file for this process. (Avoid calls to the logger until it is reinstated.)
                libMBIN.Logger.LogStream.Flush();
                libMBIN.Logger.Close();

                // The new process will overwrite the log, so make a backup of the current log first.
                File.Copy( log, $"{log}~", true );

                // Start a new, elevated process.
                var startInfo = new System.Diagnostics.ProcessStartInfo( exe, args );
                startInfo.UseShellExecute = true;
                startInfo.Verb = "runas";
                System.Diagnostics.Process.Start( startInfo ).WaitForExit();

                // Append the log for the new process to the log for this process.
                using ( var sw = new StreamWriter( $"{log}~", true ) ) {
                    sw.WriteLine();
                    sw.WriteLine( "  ------------------------------------------------------------------------------" );
                    sw.WriteLine( "  >");
                    using ( var sr = new StreamReader( $"{log}" ) ) {
                        while (!sr.EndOfStream) sw.WriteLine( $"  > {sr.ReadLine()}" );
                    }
                    sw.WriteLine( "  >");
                    sw.WriteLine( "  ------------------------------------------------------------------------------" );
                    sw.WriteLine();
                }

                // Restore the combined log.
                File.Delete( log );
                File.Move( $"{log}~", log );

                // Reinstate the logger stream.
                libMBIN.Logger.Open( new StreamWriter( log, true ) );
            }

            return CommandLine.ShowSuccess();
        }

        private static bool IsAdministrator() {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal( identity );
            return principal.IsInRole( WindowsBuiltInRole.Administrator );
        }

        private void Register( string iconDirectory ) {
            RegisterSystemPath( Utils.GetExecutableDirectory() );

            RegisterSystemFileAssociations( iconDirectory );
            System.Diagnostics.Process.Start( "ie4uinit", "-ClearIconCache" ).WaitForExit();

            libMBIN.Logger.LogInfo( "MBINCompiler successfully registered to the Windows system.\n\nA reboot may be required for the changes to take full effect." );
        }

        private void Unregister() {
            UnregisterSystemPath( Utils.GetExecutableDirectory() );

            UnregisterSystemFileAssociations();
            System.Diagnostics.Process.Start( "ie4uinit", "-ClearIconCache" ).WaitForExit();

            libMBIN.Logger.LogInfo( "MBINCompiler successfully unregistered from the Windows system.\n\nA reboot may be required for the changes to take full effect." );
        }

        private void RegisterSystemPath( string path ) {
            var paths = GetSystemPaths();

            // only add if it's not already registered
            if ( !paths.Contains( path ) ) paths.Add( path );

            SetSystemPaths( paths );
        }

        private void UnregisterSystemPath( string path ) {
            var paths = GetSystemPaths();

            // it's possible there is more than one occurence of path in paths, so loop until Remove returns false.
            while ( paths.Remove( path ) ) ;

            SetSystemPaths( paths );
        }

        // Get/set the system PATH variable as a list of strings
        private List<string> GetSystemPaths()                     => new List<string>( GetSystemPathVariable().Split( ';' ) );
        private void         SetSystemPaths( List<string> paths ) => SetSystemPathVariable( string.Join( ";", paths ) );

        // Get/set the system PATH variable as a string delimited with semicolons
        private string GetSystemPathVariable()             => Environment.GetEnvironmentVariable( "PATH" );
        private void   SetSystemPathVariable( string val ) => Environment.SetEnvironmentVariable( "PATH", val, EnvironmentVariableTarget.Machine );

        private void RegisterSystemFileAssociations( string iconDirectory ) {
            var key = Registry.ClassesRoot.OpenSubKey( "SystemFileAssociations", true );

            var defaultIconDirectory = Path.Combine( Utils.GetExecutableDirectory(), "Icons" );
            iconDirectory = Path.GetFullPath( iconDirectory ?? defaultIconDirectory );

            var exmlIconPath = Path.Combine( iconDirectory, "exml.ico" );
            var mbinIconPath = Path.Combine( iconDirectory, "mbin.ico" );

            if ( !File.Exists( exmlIconPath ) ) exmlIconPath = Path.Combine( defaultIconDirectory, "exml.ico" );
            if ( !File.Exists( mbinIconPath ) ) mbinIconPath = Path.Combine( defaultIconDirectory, "mbin.ico" );

            RegisterSystemFileAssociation( key, ".exml", exmlIconPath, "Convert to MBIN" );
            RegisterSystemFileAssociation( key, ".mbin", mbinIconPath, "Convert to EXML" );
        }

        private void UnregisterSystemFileAssociations() {
            var key = Registry.ClassesRoot.OpenSubKey( "SystemFileAssociations", true );

            key?.DeleteSubKeyTree( ".exml", false );
            key?.DeleteSubKeyTree( ".mbin", false );
        }

        private void RegisterSystemFileAssociation( RegistryKey systemKey, string fileType, string iconPath, string commandName ) {
            var fileKey = systemKey.CreateSubKey( fileType );
            SetSubKey( fileKey, @"shell\convert"        , commandName );
            SetSubKey( fileKey, @"shell\convert\command", $"\"{Utils.GetExecutablePath()}\" \"%1\"" );
            if ( !File.Exists( iconPath ) ) return;
            SetSubKey( fileKey, @"DefaultIcon"          , $"\"{iconPath}\"" );
        }

        private void SetSubKey( RegistryKey key, string subKeyPath, string subKeyValue ) {
            var subKey = key.CreateSubKey( subKeyPath );
            if ( subKeyValue != null ) subKey.SetValue( null, subKeyValue );
        }


    }

}

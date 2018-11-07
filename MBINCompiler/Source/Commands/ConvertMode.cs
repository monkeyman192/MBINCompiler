using System;
using System.IO;
using System.Collections.Generic;

using libMBIN;

namespace MBINCompiler.Commands {

    using static CommandLineOptions;

    internal class ConvertCommand : Command<ConvertCommand> {

        public override int ExecuteCommand( CommandLineParser options ) {
            var paths = options.GetFileParams();

            if ( !GetOverwriteOption( options ) ) return (int) ErrorCode.CommandLine;

            IgnoreErrors = options.GetOptionSwitch( "force" );
            UseThreads   = !options.GetOptionSwitch( "no-threads" );
            var arg = options.GetOptionArg( "format-version" );
            if ( arg != null ) {
                MBINHeader.Format version;
                if ( !Enum.TryParse( arg.value, out version ) ) return CommandLine.ShowInvalidCommandLineArg( $"{arg.name}={arg.value}" );
                FormatVersion = version;
            }

            if ( paths.Count < 1 ) return CommandLine.ShowHelp( ErrorCode.CommandLine );
            var inputDir = paths[0];
            var outputDir = options.GetOptionArg( "output-dir" )?.value;
            if ( outputDir != null ) {
                if ( paths.Count > 1 ) return CommandLine.ShowInvalidCommandLineArg( paths[1] );
                outputDir = Path.GetFullPath( outputDir );
            }
            if ( File.Exists( inputDir ) ) inputDir = Path.GetDirectoryName( inputDir );
            inputDir = Path.GetFullPath( Path.Combine( inputDir, "." ) );

            var optFormatI = options.GetOptionArg( "input-format" );
            var optFormatO = options.GetOptionArg( "output-format" );

            var optIncludes = options.GetOptionArg( "include" );
            var optExcludes = options.GetOptionArg( "exclude" );

            var formatI = optFormatI?.value.ToUpper();
            var formatO = optFormatO?.value.ToUpper();

            // handle --input-format and --output-format options
            // and set the default include filters accordingly
            var defaultInclude = "*";
            bool autoFormat = (formatI == null) && (formatO == null);
            if ( autoFormat ) {
                defaultInclude = "*.MBIN;*.MBIN.PC;*.EXML";
            } else {
                if ( !SetFormatOptions( formatI, formatO ) ) return (int) ErrorCode.CommandLine;
                defaultInclude = (InputFormat == FormatType.MBIN) ? "*.MBIN;*.MBIN.PC" : "*.EXML";
            }

            var defaultExclude = @"LANGUAGE\*;*.GEOMETRY.*";

            //#if DEBUG
            //defaultExclude = "";
            //#endif

            IncludeFilters = new List<string>((optIncludes?.value ?? defaultInclude).Split(';'));
            ExcludeFilters = new List<string>((optExcludes?.value ?? defaultExclude).Split(';'));

            // if not auto-detecting then OutputFormat can be excluded
            if ( !autoFormat ) ExcludeFilters.Add( $"*.{OutputFormat}" );

            // generate a filtered file listing of the combined paths
            if ( !GetFileList( paths, out var fileList ) ) return (int) ErrorCode.CommandLine;

            // auto detect the input format if necessary
            if ( autoFormat && !AutoDetectFormat( ref fileList ) ) return (int) ErrorCode.Unknown;

            return (int) Convert.ConvertFileList( inputDir, outputDir, fileList, IgnoreErrors );
        }

        private static bool GetOverwriteOption( CommandLineParser options ) {
            var optO = options.GetOptionArg( "overwrite" );
            var optK = options.GetOptionArg( "keep" );
            bool isO = (optO != null);
            bool isK = (optK != null);
            if ( isO && isK ) {
                CommandLine.ShowCommandLineError( $"The {optO.name} and {optK.name} options cannot be used together." );
                return false;
            }

            Overwrite = isO ? OverwriteMode.Always : isK ? OverwriteMode.Never : OverwriteMode.Prompt;
            return true;
        }

        private static bool SetFormatOptions( string formatI, string formatO ) {
            if ( formatI != null ) {
                InputFormat = (formatI == "MBIN") ? FormatType.MBIN : InputFormat;
                InputFormat = (formatI == "EXML") ? FormatType.EXML : InputFormat;
                if ( InputFormat == FormatType.Unknown ) {
                    CommandLine.ShowCommandLineError( $"Invalid format specified: {formatI}" );
                    return false;
                }
            }

            if ( formatO != null ) {
                OutputFormat = (formatO == "MBIN") ? FormatType.MBIN : OutputFormat;
                OutputFormat = (formatO == "EXML") ? FormatType.EXML : OutputFormat;
                if ( OutputFormat == FormatType.Unknown ) {
                    CommandLine.ShowCommandLineError( $"Invalid format specified: {formatO}" );
                    return false;
                }
            }

            if ( formatI == null ) InputFormat = (OutputFormat == FormatType.MBIN) ? FormatType.EXML : FormatType.MBIN;
            if ( formatO == null ) OutputFormat = (InputFormat == FormatType.MBIN) ? FormatType.EXML : FormatType.MBIN;

            if ( InputFormat == OutputFormat ) {
                CommandLine.ShowCommandLineError( "--input-format and --output-format cannot be the same type!" );
                return false;
            }

            return true;
        }

        private static bool GetFileList( List<string> paths, out List<string> fileList ) {
            fileList = new List<string>();
            foreach ( var path in paths ) {
                var fullpath = Path.GetFullPath( path );
                if ( File.Exists( fullpath ) ) {
                    fileList.Add( fullpath );
                } else if ( Directory.Exists( fullpath ) ) {
                    fileList.AddRange( GetFilteredFiles( fullpath ) );
                } else {
                    CommandLine.ShowCommandLineError( $"Invalid path.\n\"{path}\"" );
                    return false;
                }
            }

            return true;
        }

        private static List<string> GetFilteredFiles( string path ) {
            var files = new List<string>();

            var includeFiles = new List<string>();
            var excludeFiles = new List<string>();
            foreach ( var filter in IncludeFilters ) {
                includeFiles.AddRange( GetDirectoryFiles( path, filter ) );
            }
            foreach ( var filter in ExcludeFilters ) {
                excludeFiles.AddRange( GetDirectoryFiles( path, filter ) );
            }

            // add the filtered files to fileList
            foreach ( var file in includeFiles ) {
                if ( !excludeFiles.Contains( file ) ) files.Add( file );
            }

            return files;
        }

        private static string[] GetDirectoryFiles( string path, string filter ) {
            try {
                return Directory.GetFiles( path, filter, SearchOption.AllDirectories );
            } catch ( DirectoryNotFoundException ) { }
            return new string[] { };
        }

        private static string DetectFormat( string file, ref bool foundMBIN, ref bool foundEXML ) {
            if ( Path.HasExtension( file ) ) {
                var ext = Path.GetExtension( file ).ToUpper();
                foundMBIN |= (ext == ".MBIN") || (ext == ".PC");
                foundEXML |= (ext == ".EXML");
            }
            return file;
        }

        private static bool AutoDetectFormat( ref List<string> fileList ) {
            // detect what types of file formats are found
            bool foundMBIN = false;
            bool foundEXML = false;

            foreach ( var file in fileList ) DetectFormat( file, ref foundMBIN, ref foundEXML );

            // TODO: this should be handled better
            if ( !foundMBIN && !foundEXML ) {
                if ( (fileList.Count == 1) && File.Exists( fileList[0] ) ) {
                    FileStream fIn = null;
                    MBINFile mbin = null;
                    try
                    {
                        fIn = new FileStream(fileList[0], FileMode.Open);
                        // possibly MBIN? check for a valid header
                        mbin = new MBINFile(fIn, true);
                        foundMBIN = mbin.Load() && mbin.Header.IsValid;
                        if (!foundMBIN)
                        { // possibly EXML? check for a valid xml tag
                            var xmlTag = "<?xml version=\"1.0\" encoding=\"utf-8\"?>".ToLower();
                            var bytes = new byte[xmlTag.Length];
                            // TODO: handle potential leading whitespace?
                            if (fIn.Read(bytes, 0, xmlTag.Length) == xmlTag.Length)
                            {
                                var txt = System.Text.Encoding.ASCII.GetString(bytes).ToLower();
                                foundEXML = (txt == xmlTag);
                            }
                        }
                    }
                    finally
                    {
                        if (mbin != null)
                            mbin.Dispose();
                        else if (fIn != null)
                            fIn.Dispose();
                    }
                }
            }

            if ( foundMBIN && foundEXML ) {
                const string msg = "Unable to automatically determine the --input-format type.";
                if ( Quiet ) return (CommandLine.ShowError( msg ) == (int) ErrorCode.Success);
                CommandLine.ShowWarning( msg );
                Console.Out.WriteLine( "Both MBIN and EXML file types were detected!\n" );
                InputFormat = Utils.PromptInputFormat();
                Console.WriteLine();
            } else if ( foundMBIN ) {
                Logger.LogInfo( "Auto-Detected --input-format=MBIN" );
                InputFormat = FormatType.MBIN;
            } else if ( foundEXML ) {
                Logger.LogInfo( "Auto-Detected --input-format=EXML" );
                InputFormat = FormatType.EXML;
            } else {
                CommandLine.ShowError( "No valid files found!" );
                return false;
            }

            OutputFormat = (InputFormat == FormatType.MBIN) ? FormatType.EXML : FormatType.MBIN;
            Logger.LogMessage( "INFO", $"--input-format={InputFormat} --output-format={OutputFormat}" );

            // exclude any files that don't match InputFormat
            for (int i = fileList.Count - 1; i >= 0; i--) {
                var ext = Path.GetExtension(fileList[i]).ToUpper();
                if (ext == ".PC") {
                    ext = Path.GetExtension(Path.ChangeExtension(fileList[i], null)).ToUpper();
                }
                if (ext.Substring(1) != InputFormat.ToString()) fileList.RemoveAt(i);
            }

            return true;
        }

    }

}

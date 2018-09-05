using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using libMBIN;
using libMBIN.Models;
using libMBIN.Models.Structs;

namespace MBINCompiler {

    // TODO: (GH) needs more refactoring
    class Program {

        static System.Version MBINCompilerVersion => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        // TODO: (GH) not used
        static void ScanMBINs( string path, ref List<string> types ) {
            foreach (var file in Directory.GetFiles( path, "*.mbin*" )) {
                var mbin = new MBINFile( file );
                mbin.Load();
                types.Add( $"{file} : {mbin.Header.GetXMLTemplateName()}" );
            }
            foreach (var folder in Directory.GetDirectories( path )) {
                ScanMBINs( folder, ref types );
            }
        }

        static void DecompileFile( string inputPath, string outputPath, bool getVersion = false, bool verbose = false ) {
            outputPath = String.IsNullOrEmpty( outputPath ) ? inputPath : outputPath;

            if (Path.GetExtension(outputPath) == ".PC")
                outputPath = Path.GetFileNameWithoutExtension(outputPath);  // remove the ".PC"

            outputPath = Path.ChangeExtension( outputPath, ".exml" ); // emoose XML, because there's no way this XML format is compatible with MXML

            if (File.Exists( outputPath )) {
                File.Delete( outputPath ); // todo: ask for confirmation?
            }

            // no error checking ^^ (todo: error checking)
            var file = new MBINFile( inputPath );
            file.Load( );

            if (getVersion) {
                ShowMBINVersion(file, verbose);

            } else {
                var data = file.GetData();
                if (data == null) {
                    Console.WriteLine( $"Failed to deserialize template \"{file.Header.GetXMLTemplateName()}\", has the structure been mapped yet?" );
                    return;
                }

                var xmlString = EXmlFile.WriteTemplate( data );
                if (string.IsNullOrEmpty( xmlString )) {
                    Console.WriteLine( $"Error serializing template \"{file.Header.GetXMLTemplateName()}\" to XML!" );
                    return;
                }
                File.WriteAllText( outputPath, xmlString );
                Console.WriteLine( $"XML data written to \"{outputPath}\" successfully?" );
            }
        }

        static void CompileFile( string inputPath, string outputPath ) {
            outputPath = String.IsNullOrEmpty( outputPath ) ? inputPath : outputPath;

            outputPath = Path.ChangeExtension( outputPath, ".MBIN" );

            var data = EXmlFile.ReadTemplate( inputPath );
            if (data == null) {
                Console.WriteLine( "Failed to deserialize EXML file, is it formatted correctly?" );
                return;
            }

            if (data.GetType() == typeof( TkGeometryData )) {
                outputPath = Path.ChangeExtension( outputPath, ".MBIN.PC" );
            }

            if (File.Exists( outputPath )) {
                File.Delete( outputPath ); // todo: ask for confirmation?
            }

            using (var file = new MBINFile( outputPath )) {
                file.Header = new MBINHeader();
                file.Header.SetDefaults();
                if (data.GetType() == typeof( TkGeometryData ))
                    file.Header.Magic = 0xDDDDDDDD; // only used by TkGeometryData / .MBIN.PC files, maybe used to signal the file is PC only?
                if (data.GetType() == typeof( TkAnimMetadata )) {
                    file.Header.Tag = 0xFFFFFFFFFFFFFFFF;
                    file.Header.MbinVersion = 0x9B251350AE1ABCA7;
                    file.Header.EndPadding = 0xFEFEFEFEFEFEFEFE;
                }

                file.SetData( data );       // this will also get the length of the data

                if (data.GetType() != typeof(TkAnimMetadata))
                {
                    file.Header.EndPadding = file.FileLength;
                }

                file.Save();
            }

            Console.WriteLine( $"MBIN data written to \"{outputPath}\" successfully?" );
        }

        static void DecompileFolder( string inputPath, string outputPath ) {
            outputPath = string.IsNullOrEmpty( outputPath ) ? inputPath : outputPath;

            foreach (var file in Directory.GetFiles( inputPath, "*.mbin*" )) {
                if (!IsFileType( file, "mbin" )) continue;

                var output = file.Replace( inputPath, outputPath );
                if (!Directory.Exists( Path.GetDirectoryName( output ) )) {
                    Directory.CreateDirectory( Path.GetDirectoryName( output ) );
                }

                try {
                    DecompileFile( file, output );
                // } catch {
                    // TODO: (GH) handle exceptions!
                } finally {
                    // nothing to do
                }
            }

            foreach (var dir in Directory.GetDirectories( inputPath )) {
                string outDirPath = dir.Replace( inputPath, outputPath );
                DecompileFolder( dir, outDirPath );
            }
        }

        static void CompileFolder( string inputPath, string outputPath ) {
            if (!ValidateOutputPath( outputPath )) return;

            foreach (var file in Directory.GetFiles( inputPath, "*.exml" )) {
                if (!IsFileType( file, "exml" )) continue;

                var output = file.Replace( inputPath, outputPath );
                if (!Directory.Exists( Path.GetDirectoryName( output ) )) {
                    Directory.CreateDirectory( Path.GetDirectoryName( output ) );
                }

                try {
                    CompileFile( file, output );
                // } catch {
                    // TODO: (GH) handle exceptions!
                } finally {
                    // nothing to do
                }
            }

            foreach (var dir in Directory.GetDirectories( inputPath )) {
                string outDirPath = dir.Replace( inputPath, outputPath );
                CompileFolder( dir, outDirPath );
            }
        }

        static bool ValidateOutputPath( string outputPath ) {
            if (!string.IsNullOrEmpty( outputPath )) return true;
            Console.WriteLine( "Output folder not specified. Bulk compile aborted." );
            return false;
        }

        static bool IsFileType( string filePath, string extType ) {
            if (filePath.EndsWith( $".{extType}", StringComparison.OrdinalIgnoreCase )) return true;
            if (filePath.EndsWith( $".{extType}.pc", StringComparison.OrdinalIgnoreCase )) return true;
            return false;
        }

        static void WaitForKeypress() {
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static void ShowMBINVersion(MBINFile file, bool verbose = false) {
            System.Version mbinVersion = file.Header.GetMBINVersion();
            string versionString = mbinVersion.ToString();

            if (verbose) {
                if (versionString != "0.0.0.0") {
                    versionString = "Compiled with MBINCompiler v" + versionString;
                } else {
                    versionString = "Unknown MBIN version!\nNot compiled by MBINCompiler.";
                }
            }
            Console.WriteLine( versionString );
        }

        static void ShowVersionStringVerbose() {
            Console.WriteLine( $"MBINCompiler v{MBINCompilerVersion}" );
            Console.WriteLine( $"libMBIN v{libMBIN.Version.AssemblyVersion}" );
        }

        static void ShowVersionStringCompact() {
            Console.WriteLine( libMBIN.Version.AssemblyVersion );
        }

        /// <summary>
        /// Show the version string.
        /// </summary>
        /// <returns>Always returns 0 (exit code = success)</returns>
        static int ShowVersion( bool verbose = true ) {
            if (verbose) {
                ShowVersionStringVerbose();
            } else {
                ShowVersionStringCompact();
            }
            return 0;
        }

        /// <summary>
        /// Display the help info.
        /// </summary>
        /// <returns>Always returns 0 (exit code = success)</returns>
        static int ShowHelp() {
            ShowVersionStringVerbose();
            Console.WriteLine();

            // TODO: (GH) show general description
            // TODO: (GH) show full syntax

            Console.WriteLine( @"Usage: MBINCompiler [Input File or Folder]" );
            Console.WriteLine( @"Will write decompiled output to [Input File].exml or [Input Folder]\*.exml" );
            Console.WriteLine();
            Console.WriteLine( @"Usage: MBINCompiler [Input Folder] [Output Folder]" );
            Console.WriteLine( @"Will write decompiled & recompiled files from [Input Folder] and write them to [Output Folder]" );

            WaitForKeypress();
            return 0;
        }

        /// <summary>
        /// Display an error message and optionally display the help info.
        /// </summary>
        /// <param name="msg">The error message to display.</param>
        /// <param name="showHelp">If true, also calls <see cref="ShowHelp()"/>.</param>
        /// <param name="exitCode">The value to return, unless <paramref name="showHelp"/> is true.</param>
        /// <returns>Returns 1 if <paramref name="showHelp"/> is true, otherwise <paramref name="exitCode"/>.</returns>
        /// <summary>
        static int ShowError(string msg, bool showHelp = false, int exitCode = 2) {
            Console.WriteLine( $"ERROR: {msg}\n" );
            if (showHelp) {
                ShowHelp();
            } else {
                WaitForKeypress();
            }
            return showHelp ? 1 : exitCode;
        }

        /// <summary>
        /// <see cref="ShowError(string, bool, int)"/>
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="exitCode"></param>
        /// <returns></returns>
        static int ShowError(string msg, int exitCode) {
            return ShowError( msg, false, exitCode );
        }

        static void ShowWarning(string msg) {
            Console.WriteLine( $"WARNING: {msg}" );
        }

        static int Main( string[] args ) {
            string inputPath, outputPath;
            bool getVer = false;
            bool versionVerbose = false;

            if (args.Length == 0)    return ShowHelp();

            // there's at least 1 arg

            if (args[0] == "/?")     return ShowHelp();
            if (args[0] == "/help")  return ShowHelp();
            if (args[0] == "--help") return ShowHelp();
            if (args[0] == "-h")     return ShowHelp();

            if (args[0] == "--version") return ShowVersion( true );
            if (args[0] == "-v") return ShowVersion( false );

            // at least the first argument is an input param

            // if there is 2 args, is the 2nd arg a version switch?
            if (args.Length > 1) {
                getVer |= (args[1] == "--version");
                versionVerbose |= getVer;
                getVer |= (args[1] == "-v");
            }

            try {
                // get the absolute paths
                inputPath = Path.GetFullPath( args[0] );
                outputPath = String.Empty;
                if (!getVer && (args.Length > 1)) outputPath = Path.GetFullPath( args[1] );
            } catch (Exception e) {
                return ShowError( e.Message, true );
            }

            try {
                if (Directory.Exists( inputPath )) {
                    DecompileFolder( inputPath, outputPath );
                    CompileFolder( inputPath, outputPath );
                } else if (IsFileType( inputPath, "exml" )) {
                    CompileFile( inputPath, outputPath );
                } else { // assume MBIN
                    bool isMBin = true;

                    isMBin = IsFileType( inputPath, "mbin" );
                    if (!isMBin) {
                        if (File.Exists( inputPath ) && new FileInfo( inputPath ).Length > 0x60) {
                            using (var stream = File.OpenRead( inputPath )) {
                                using (var reader = new BinaryReader( stream )) {
                                    // MBINs start with
                                    //    CC CC CC CC C4 09 00 00
                                    // or DD DD DD DD C4 09 00 00
                                    var magic = reader.ReadUInt32();
                                    var unk4 = reader.ReadUInt32();
                                    isMBin = (magic == 0xCCCCCCCC || magic == 0xDDDDDDDD);
                                    isMBin &= (unk4 == 2500);
                                }
                            }
                        }

                        if (!isMBin) {
                            return ShowError( $"Unknown/Unsupported file type! Expected EXML or MBIN format.\nFilePath: {inputPath}" );
                        }

                        string ext = Path.GetExtension( inputPath ) ?? String.Empty;
                        ShowWarning( $"MBIN format detected in file with unrecognized extension. Attempting to decompile.\n"
                                   + $"FilePath: {inputPath}\n" );
                    }

                    DecompileFile( inputPath, outputPath, getVer, versionVerbose );
                }

            } catch (Exception e) {
                return ShowError( "An unknown exception occurred!\n" + e.Message + "\nStacktrace:\n" + e.StackTrace );
            }

            //WaitForKeypress();
            return 0;
        }

    }
}

// Configure conditional compilation symbols in the Project properties Build page.
//
// Debug configurations default to DISABLE_THREADS.
// Add ENABLE_THREADS to the compilation symbols to enable threading.
//
// Release configurations default to ENABLE_THREADS.
// Add DISABLE_THREADS to the compilation symbols to disable threading.

// don't change
#if !ENABLE_THREADS && !DISABLE_THREADS
    #if DEBUG
        #define DISABLE_THREADS
    #else
        #define ENABLE_THREADS
    #endif
#endif

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

using libMBIN;

namespace MBINCompiler.Commands {
    using System.Linq;
    using static CommandLineOptions;
    using Async = libMBIN.Common.Async;

    internal static class Convert {

        private static int currentIndent = 0;

        private static object errorLock = new object();
        private static Task   errorTask = null;

        private static object fileModeLock = new object();
        private static Task   fileModeTask = null;

        private static List<string>    failedFiles = new List<string>();
        private static List<Exception> exceptions  = new List<Exception>();

        private static List<string>    warnedFiles = new List<string>();
        private static List<string>    warnings    = new List<string>();

        // we use a bool here and not a cancellation token to avoid creating more exceptions
        private static volatile bool   thrown;

        public static ErrorCode ConvertFileList( string inputDir, string outputDir, List<string> fileList, bool force ) {
            var errorCode = ErrorCode.Success;

            var timer = new Stopwatch();
            timer.Start();

            var tasks = new List<Task>();
            currentIndent = Logger.IndentLevel;
            thrown = false;
            foreach ( var fileIn in fileList ) {
                var path = fileIn;
                if ( outputDir != null ) path = fileIn.Substring( inputDir.Length + 1 );
                string fileOut = fileIn;
                if ( outputDir != null ) fileOut = fileOut.Replace( inputDir, outputDir );
                RunTask( tasks, () => {
                    fileModeTask?.Wait(); // block tasks while waiting for overwrite prompt. if not threaded, this is a nop
                    errorTask?.Wait();    // block tasks while waiting for error message to be logged. if not threaded, this is a nop
                    if ( thrown ) return;
                    try {
                        Logger.IndentLevel = currentIndent; // we need to reset the indent level for each thread otherwise it will accumulate
                        //EmitInfo( $"Converting {path}" );
                        ConvertFile( path, fileIn, fileOut, InputFormat, OutputFormat );

                    } catch ( System.Exception e ) {
                        if ( !force ) {
                            thrown = true;
                            throw;
                        }
                        Async.SynchronizeTask( errorLock, ref errorTask, () => {
                            failedFiles.Add( path );
                            exceptions.Add( e );
                            Logger.LogMessage( false, Console.Out, null, "" );
                            errorCode = (ErrorCode) CommandLine.ShowException( e, false );
                            Logger.LogMessage( false, Console.Out, null, "" );
                        } );
                    }
                } );
            }
            WaitForTasks( tasks );
            EmitSummary( fileList, timer.ElapsedMilliseconds / 1e3f );
            return errorCode;
        }

        private static void RunTask( List<Task> tasks, Action action ) {
            #if ENABLE_THREADS
                if (UseThreads) { tasks.Add( Task.Factory.StartNew( action ) ); return; }
            #endif
            action();
        }

        [Conditional( "ENABLE_THREADS" )]
        private static void WaitForTasks( List<Task> tasks ) { if (UseThreads) Task.WaitAll( tasks.ToArray() ); }

        private static void EmitInfo( string text ) {
            Async.SynchronizeTask( errorLock, ref errorTask, () => {
                #if DEBUG
                    Logger.LogInfo( text );
                #else
                    Logger.LogMessage( false, Console.Out, null, text );
                #endif
            } );
        }

        private static void EmitSummary( List<string> fileList, float elapsedSeconds ) {
            Async.SynchronizeTask( errorLock, ref errorTask, () => {
                Logger.LogInfo( $"\n{fileList.Count - failedFiles.Count} files converted.\n" );

                EmitSummaryResults( true, failedFiles, exceptions.Select( e => {
                    if ( e.GetType() == typeof( CompilerException ) ) e = e?.InnerException ?? e;
                    return e.Message;
                } ).ToList() );

                EmitSummaryResults( false, warnedFiles, warnings );

                //#if DEBUG
                    Logger.LogInfo( "TIME: {0} seconds", elapsedSeconds );
                //#endif
            } );
        }

        private static void EmitSummaryResults( bool error, List<string> files, List<string> results ) {
            if ( files.Count > 0 ) {
                Logger.LogInfo( $"{files.Count} {(error ? "FILES FAILED" : "WARNINGS")}.\n" );
                EmitResults( error, files, results );
            }
        }

        private static void EmitResults( bool error, List<string> files, List<string> results ) {
        //#if !DEBUG
            using ( var indentScope = new Logger.IndentScope( ) ) {
                for ( int i = 0; i < files.Count; i++ ) {
                    if ( error ) {
                        Logger.LogError( "{0}", results[i] );
                    } else {
                        Logger.LogWarning( "{0}", results[i] );
                    }
                    Logger.LogMessage( Console.Out, "", "[FILE]: {0}\n", files[i] );
                }
            }
        //#endif
        }
        
        public static void ConvertFile( string inputPath, string fileIn, string fileOut, FormatType inputFormat, FormatType outputFormat ) {
            fileOut = ChangeFileExtension( fileOut, outputFormat );
            Logger.LogMessage(null, "INFO", inputPath);

            try {
                using ( var fIn = new FileStream( fileIn, FileMode.Open, FileAccess.Read ) )
                using ( var ms = new MemoryStream() ) {

                    if ( inputFormat == FormatType.MBIN ) {
                        fileOut = ConvertMBIN( inputPath, fIn, ms, fileOut );
                    } else if ( inputFormat == FormatType.EXML ) {
                        fileOut = ConvertEXML( inputPath, fIn, ms, fileOut );
                    }
                    if (!(StreamToConsole && inputFormat == FormatType.MBIN)) {
                        ms.Flush();

                        FileMode fileMode;
                        if (!GetFileMode(fileOut, out fileMode)) return;

                        Directory.CreateDirectory(Path.GetDirectoryName(fileOut));
                        using (var fOut = new FileStream(fileOut, fileMode, FileAccess.Write)) ms.WriteTo(fOut);
                    }
                }
            } catch ( Exception e ) {
                if ( e is CompilerException ) throw;
                throw new CompilerException( e, fileIn );
            }

        }

        /// <summary>Convert MBIN to EXML</summary>
        /// <param name="fIn">Source file</param>
        /// <param name="msOut">Output stream</param>
        /// <param name="fileOut">Output file path. Passed through as the return value. Not actually used.</param>
        /// <returns>fileOut</returns>
        private static string ConvertMBIN( string inputPath, FileStream fIn, MemoryStream msOut, string fileOut ) {
            MBINFile mbin = new MBINFile( fIn );
            if ( !(mbin.Load() && mbin.Header.IsValid) ) throw new InvalidDataException( "Not a valid MBIN file!" );

            Type type = NMSTemplate.GetTemplateType( mbin.Header.GetXMLTemplateName() );
            // Get the Attribute. If there isn't one just don't worry about it...
            object[] attr = type.GetCustomAttributes( typeof( NMSAttribute ), false );
            if (attr.Length != 0) {
                NMSAttribute nms = (NMSAttribute) (type.GetCustomAttributes( typeof( NMSAttribute ), false )?[0] ?? null);
                bool broken = nms.Broken;
                // GUID's for the old files
                ulong[] UnsupportedGUIDs = new ulong[] { };
                bool mismatch = (mbin.Header.TemplateGUID != nms.GUID);
                bool unsupported = (UnsupportedGUIDs.Contains(mbin.Header.TemplateGUID));

                if (broken) {
                    FileIsBroken(inputPath, mbin);
                } else if ( unsupported ) {
                    FileIsUnused(inputPath, mbin);
                } else if ( mismatch ) {
                    FileIsUnrecognized( inputPath, mbin, nms.GUID );
                }
            }

            StreamWriter sw = new StreamWriter( msOut );

            NMSTemplate data = null;
            string msg = "";
            try {
                msg = $"Failed to read {mbin.Header.GetXMLTemplateName()} from MBIN.";
                data = mbin.GetData();
                if ( data is null ) throw new InvalidDataException( "Invalid MBIN data." );

                msg = $"Failed serializing {mbin.Header.GetXMLTemplateName()} to EXML.";
                string exml = EXmlFile.WriteTemplate(data, HideVersionInfo);

                if ( StreamToConsole ) {
                    EmitInfo($"");
                    EmitInfo($"[INPUT]: {inputPath}");
                    EmitInfo($"{exml}");
                }
                else {
                    sw.Write(exml);
                    sw.Flush();
                    if ( msOut.Length == 0 ) throw new InvalidDataException( "Invalid EXML data." );
                }
            } catch ( Exception e ) {
                throw new MbinException( msg, e, fIn.Name, mbin );
            }

            return fileOut;
        }

        /// <summary>Convert EXML to MBIN</summary>
        /// <param name="fIn">Source file</param>
        /// <param name="msOut">Output stream</param>
        /// <param name="fileOut">Output file path. Passed through as the return value. For geometry files, ".PC" will be appended.</param>
        /// <returns>fileOut</returns>
        private static string ConvertEXML( string inputPath, FileStream fIn, MemoryStream msOut, string fileOut ) {
            string templateName;
            NMSTemplate data = null;
            try {
                data = EXmlFile.ReadTemplateFromStream( fIn, out templateName );

                Type type = NMSTemplate.GetTemplateType( templateName );
                var nms = (NMSAttribute) (data.GetType().GetCustomAttributes( typeof( NMSAttribute ), false )?[0] ?? null);
                if ( nms.Broken ) FileIsBroken( inputPath, data );

                if ( data is null ) throw new InvalidDataException( $"Failed to deserialize EXML." );
                if ( data is libMBIN.NMS.Toolkit.TkGeometryData ) fileOut += ".PC";

                var mbin = new MBINFile( msOut ) { Header = new MBINHeader() };
                mbin.Header.SetDefaults( data.GetType(), FormatVersion );
                mbin.SetData( data );
                mbin.Save();
            } catch ( Exception e ) {
                throw new ExmlException( e, fIn.Name, data );
            }

            return fileOut;
        }

        private static void FileIsUnsupported( string filePath, MBINFile mbin ) {
            WarnBroken( "File not supported."
                      , filePath, mbin );
        }
        private static void FileIsUnrecognized( string filePath, MBINFile mbin, ulong expectedGUID = 0L ) {
            WarnBroken( "File not recognized. You may need to use an older (or newer) version of MBINCompiler."
                      , filePath, mbin, null, expectedGUID );
        }
        private static void FileIsUnused(string filePath, MBINFile mbin)
        {
            WarnBroken("This file is not supported by MBINCompiler as it is no longer used by the game. Do not report issues decompiling this file anywhere as it is not expected to."
                      , filePath, mbin);
        }
        private static void  FileIsBroken( string filePath, MBINFile mbin    ) => _FileIsBroken( filePath, mbin, null );
        private static void  FileIsBroken( string filePath, NMSTemplate data ) => _FileIsBroken( filePath, null, data );
        private static void _FileIsBroken( string filePath, MBINFile mbin, NMSTemplate data ) {
            WarnBroken( "There are known issues with this file in the current version of MBINCompiler."
                      , filePath, mbin, data );
        }

        private static long lastPosition = 0;

        private static void WarnBroken( string msg, string filePath, MBINFile mbin, NMSTemplate data = null, ulong expectedGUID = 0L ) {
            #if ERROR_ON_BROKEN
                if (mbin != null) throw new MbinException( msg, filePath, mbin );
                throw new ExmlException( msg, filePath, data );
            #endif

            Async.SynchronizeTask( errorLock, ref errorTask, () => {
                warnedFiles.Add( filePath );
                warnings.Add( msg );
                if (Logger.LogStream.BaseStream.Position != lastPosition) msg = $"\n{msg}";
                Logger.LogWarning( $"{msg}" );
                using ( var indentInfo = new Logger.IndentScope() ) {
                    Logger.LogMessage( false, Console.Out, null, "" ); // newline, console only
                    Logger.LogMessage( Console.Out, $"[INFO]: {filePath}" );
                    if ( mbin != null ) {
                        Logger.LogMessage( false, Console.Out, null, "" ); // newline, console only
                        Logger.LogMessage( null, "INFO", $"{CommandLine.GetFileInfo( mbin )}" );
                        if (expectedGUID != 0L) {
                            Logger.LogMessage(null, "EXPECTED INFO", $"GUID: {expectedGUID:X}\n");
                        }
                    }
                    //Logger.LogMessage( true, Console.Out, null, "" ); // newline, console and log
                }
                lastPosition = Logger.LogStream.BaseStream.Position;
            });
        }

        private static string ChangeFileExtension( string file, FormatType format ) {
            string ext = format.ToString().ToUpper();
            if ( Path.HasExtension( file ) ) {
                string x = Path.GetExtension( file ).ToUpper();
                if ( x == ".PC" ) file = Path.ChangeExtension( file, null );
                x = Path.GetExtension( file ).ToUpper();
                if ( x == ".MBIN" ) return Path.ChangeExtension( file, ext );
                if ( x == ".EXML" ) return Path.ChangeExtension( file, ext );
            }
            return file + $".{ext}";
        }

        /// <summary>
        /// Gets the appropriate file mode based on the Overwrite option setting.
        /// For output files. If file exists and Overwrite is Prompt, the user will be asked
        /// how to handle the file.
        /// </summary>
        /// <param name="file">The file path to check.</param>
        /// <param name="fileMode">When the method returns, contains the file mode.</param>
        /// <returns>true if the file mode is safe to use, otherwise false</returns>
        private static bool GetFileMode( string file, out FileMode fileMode ) {
            FileMode mode = FileMode.CreateNew; // OverwriteMode.Never or file doesn't exist
            bool ret = true;
            // If threaded, we need to synchronize so that the user doesn't get prompted multiple times.
            Async.SynchronizeTask( fileModeLock, ref fileModeTask, () => {
                if ( Overwrite == OverwriteMode.Always ) {
                    mode = FileMode.Create;
                } else if ( File.Exists( file ) ) {
                    if ( Overwrite == OverwriteMode.Prompt &&
                         Utils.PromptOverwrite( file, ref OptionBackers.optOverwrite ) ) {
                        mode = FileMode.Create;
                    } else {
                        ret = false;
                    }
                }
            } );
            fileMode = mode;
            return ret;
        }

    }

}

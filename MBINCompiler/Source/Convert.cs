using System;
using System.Collections.Generic;
using System.IO;

using libMBIN;
using libMBIN.Models;
using libMBIN.Models.Structs;

namespace MBINCompiler
{
    using static CommandLineOptions;

    internal static class Convert
    {

        public static ErrorCode ConvertFileList( string inputDir, string outputDir, List<string> fileList, bool force )
        {
            var failedFiles = new List<string>();
            var exceptions = new List<Exception>();
            var errorCode = ErrorCode.Success;
            foreach ( var fileIn in fileList ) {
                var path = fileIn;
                if (outputDir != null) path = fileIn.Substring( inputDir.Length + 1 );
                try {
                    string fileOut = fileIn;
                    if ( outputDir != null ) fileOut = fileOut.Replace( inputDir, outputDir );

                    Console.Out.WriteLine( $"Converting {path}" );
                    ConvertFile( fileIn, fileOut, InputFormat, OutputFormat );

                } catch ( System.Exception e ) {
                    if ( !force ) throw;
                    failedFiles.Add( path );
                    exceptions.Add( e );
                    errorCode = (ErrorCode) CommandLine.ShowException( e );
                }
            }

            Logger.LogInfo( $"\n\n{fileList.Count - failedFiles.Count} files successfully converted." );
            if ( failedFiles.Count > 0 ) {
                Logger.LogInfo( $"{failedFiles.Count} FILES FAILED.\n" );
                for ( int i = 0; i < failedFiles.Count; i++ ) {
                    Logger.LogInfo( "FILE: {0}", failedFiles[i] );
                    if ( exceptions[i].GetType() == typeof( CompilerException ) ) exceptions[i] = exceptions[i].InnerException;
                    Logger.LogInfo( "ERROR: {0}\n", exceptions[i].Message );
                }
            }

            return errorCode;
        }

        public static void ConvertFile( string fileIn, string fileOut, FormatType inputFormat, FormatType outputFormat )
        {
            fileOut = ChangeFileExtension( fileOut, outputFormat );

            FileMode fileMode = GetFileMode( fileOut );

            Directory.CreateDirectory( Path.GetDirectoryName( fileOut ) );

            try {
                using ( var indentScope = new Logger.IndentScope() )
                using ( var fIn = new FileStream( fileIn, FileMode.Open, FileAccess.Read ) )
                using ( var ms = new MemoryStream() ) {

                    if ( inputFormat == FormatType.MBIN ) {
                        var mbin = new MBINFile( fIn );
                        if ( !mbin.Load() || !mbin.Header.IsValid ) throw new InvalidDataException( "Not a valid MBIN file!" );

                        var sw = new StreamWriter( ms );

                        NMSTemplate data = null;
                        try {
                            data = mbin.GetData();
                            if (data is null) throw new InvalidDataException( "Invalid MBIN data." );
                        } catch (Exception e) {
                            throw new MbinException( $"Failed to read {mbin.Header.GetXMLTemplateName()} from MBIN.", e, fileIn, mbin );
                        }

                        try {
                            sw.Write( EXmlFile.WriteTemplate( data ) );
                            sw.Flush();
                            if ( ms.Length == 0 ) throw new InvalidDataException( "Invalid EXML data." );
                        } catch (Exception e) {
                            throw new MbinException( $"Failed serializing {mbin.Header.GetXMLTemplateName()} to EXML.", e, fileIn, mbin );
                        }

                    } else if ( inputFormat == FormatType.EXML ) {
                        NMSTemplate data = null;
                        try {
                            data = EXmlFile.ReadTemplateFromStream( fIn );
                            if ( data is null ) throw new InvalidDataException( $"Failed to deserialize EXML." );
                            if ( data is TkGeometryData ) fileOut += ".PC";
                            var mbin = new MBINFile( ms ) { Header = new MBINHeader() };
                            mbin.Header.SetDefaults( data.GetType() );
                            mbin.SetData( data );
                            mbin.Save();
                        } catch ( Exception e ) {
                            throw new ExmlException( e, fileIn, data );
                        }

                    }

                    ms.Flush();
                    using ( var fOut = new FileStream( fileOut, fileMode, FileAccess.Write ) ) ms.WriteTo( fOut );
                }
            } catch ( Exception e ) {
                File.Delete( fileOut );
                if ( e is CompilerException ) throw;
                throw new CompilerException( e, fileIn );
            }

        }

        private static string ChangeFileExtension( string file, FormatType format )
        {
            string ext = format.ToString().ToUpper();
            if ( Path.HasExtension( file ) ) {
                string x = Path.GetExtension( file ).ToUpper();
                if ( x == ".PC" ) file = Path.ChangeExtension( file, null );
                x = Path.GetExtension( file ).ToUpper();
                if (x == ".MBIN") return Path.ChangeExtension( file, ext );
                if (x == ".EXML") return Path.ChangeExtension( file, ext );
            }
            return file + $".{ext}";
        }

        /// <summary>
        /// Gets the appropriate file mode based on the Overwrite option setting.
        /// For output files. If file exists and Overwrite is Prompt, the user will be asked
        /// how to handle the file.
        /// </summary>
        /// <param name="file">The file path to check.</param>
        /// <returns>A FileMode enum. The value is 0 if the user opted to keep the existing file.</returns>
        private static FileMode GetFileMode( string file )
        {
            if ( Overwrite == OverwriteMode.Always ) {
                return FileMode.Create;
            } else if ( Overwrite == OverwriteMode.Prompt ) {
                if ( File.Exists( file ) ) {
                    if ( Utils.PromptOverwrite( file, ref OptionBackers.optOverwrite ) ) return FileMode.Create;
                    throw new IOException( "The destination file already exists!" );
                }
            }
            return FileMode.CreateNew; // OverwriteMode.Never or file doesn't exist
        }

    }

}

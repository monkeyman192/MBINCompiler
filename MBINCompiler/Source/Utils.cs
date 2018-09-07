using System;
using System.IO;

namespace MBINCompiler
{

    internal enum FormatType { Unknown, MBIN, EXML }

    internal enum OverwriteMode { Prompt, Always, Never }

    internal class Utils
    {

        public static string GetExecutablePath()      => Environment.GetCommandLineArgs()[0];
        public static string GetExecutableName()      => Path.GetFileNameWithoutExtension( GetExecutablePath() );

        public static FormatType PromptInputFormat()
        {
            Console.WriteLine(  "\nPlease specify the input file format:" );
            Console.WriteLine(  "\nValid options are:" );

            string[] names = Enum.GetNames( typeof( FormatType ) );
            string validFormats = String.Join( ", ", names, 1, names.Length - 2 );
            if ( names.Length > 2 ) validFormats += " or ";
            if ( names.Length > 1 ) validFormats += names[names.Length - 1];
            Console.WriteLine( $"    {validFormats}" );

            string result;
            while ( true ) {
                Console.Write( "\n--input-format=" );
                result = Console.ReadLine().ToUpper();
                if ( result == "MBIN" ) break;
                if ( result == "EXML" ) break;
            }

            return ( result == "MBIN" ) ? FormatType.MBIN : FormatType.EXML;
        }

        public static bool PromptOverwrite( string fileOut, ref OverwriteMode overwrite )
        {
            Console.WriteLine( $"File already exists!\n\"{fileOut}\"\n" );
            Console.WriteLine( "Options:\n" +
                               "  [y]es\n" +
                               "  [n]o\n" +
                               "  [O]verwrite all existing files.\n" +
                               "  [K]eep all existing files." );
            char key;
            while (true) {
                Console.Write( "\nOverwrite this file? " );
                key = Console.ReadKey().KeyChar;
                key = ( key >= 'a' ) ? (char) (key - 32) : key;
                Console.WriteLine();
                if ( key == 'O' ) overwrite = OverwriteMode.Always;
                if ( key == 'K' ) overwrite = OverwriteMode.Never;
                if ( ( key == 'Y' ) || ( key == 'O' ) ) return true;
                if ( ( key == 'N' ) || ( key == 'K' ) ) return false;
            }
        }
    }

}

using System.IO;

namespace MBINCompilerTests {

    public static class Utils {

        public static string NormalizePath( string path ) {
            return path.Trim( new char[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar } );
        }

        public static string AbsoluteToRelativePath( string baseDir, string path ) {
            path = NormalizePath( path );
            if ( !Path.IsPathRooted( path ) ) return path; // already a relative path
            baseDir = NormalizePath( baseDir );
            if ( path.StartsWith( baseDir, true, System.Globalization.CultureInfo.CurrentCulture ) ) {
                path = path.Substring( baseDir.Length + 1 );
            }
            return path;
        }

        public static string RelativeToAbsolutePath( string baseDir, string path ) {
            path = NormalizePath( path );
            if ( Path.IsPathRooted( path ) ) return path; // already an absolute path
            baseDir = NormalizePath( baseDir );
            return Path.Combine( baseDir, path );
        }

        public static void SetFileReadOnly( string path, bool isReadOnly = true ) {
            if ( !File.Exists( path ) ) return;
            FileAttributes attributes = File.GetAttributes( path ) & ~FileAttributes.ReadOnly;
            File.SetAttributes( path, attributes | (isReadOnly ? FileAttributes.ReadOnly : 0) );
        }

        // nibble 0 to 9 -> hex '0' to '9' = nibble + '0'
        // nibble A to F -> hex 'A' to 'F' = nibble + ('A' - 0xA)
        public static char NibbleToHexChar( int nibble ) => (char) (nibble + ((nibble < 0xA) ? '0' : ('A' - 0xA)));
        // hex '0' to '9' -> nibble 0 to 9 = hex - '0'
        // hex 'A' to 'F' -> nibble A to F = hex - ('A' - 0xA)
        public static byte HexCharToNibble( char hex )   => (byte) (hex    - ((hex    < 'A')  ? '0' : ('A' - 0xA)));

        public static string BytesToHexString( byte[] bytes ) {
            char[] chars = new char[bytes.Length * 2];
            int i = 0;
            for (int j = 0; j < bytes.Length; j++) {
                chars[i++] = NibbleToHexChar( (bytes[j] & 0xF0) >> 4 );
                chars[i++] = NibbleToHexChar( (bytes[j] & 0x0F)      );
            }
            return new string( chars );
        }

        public static byte[] HexStringToBytes( string hex ) {
            byte[] bytes = new byte[hex.Length / 2];
            int i = 0;
            char[] chars = hex.ToCharArray();
            for ( int j = 0; j < chars.Length; j += 2 ) {
                byte b  = (byte) (HexCharToNibble( chars[j + 0] ) << 4 );
                     b += (byte) (HexCharToNibble( chars[j + 1] )      );
                bytes[i] = b;
            }
            return bytes;
        }

        public static class SHA1 {

            public static byte[] GetBytes( Stream stream, long position = 0 ) {
                using ( var sha = System.Security.Cryptography.SHA1.Create() ) {
                    stream.Position = position;
                    return sha.ComputeHash( stream );
                }
            }

            public static string GetHexString( Stream stream, long position = 0 ) {
                return BytesToHexString( GetBytes( stream, position ) );
            }

            public static byte[] GetBytes( string path, long position = 0 ) {
                using ( var streamIn = new FileStream( path, FileMode.Open ) ) return GetBytes( streamIn, position );
            }

            public static string GetHexString( string path, long position = 0) {
                using ( var streamIn = new FileStream( path, FileMode.Open ) ) return GetHexString( streamIn, position );
            }

        }

    }

}

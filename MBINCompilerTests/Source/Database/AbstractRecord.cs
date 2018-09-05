using System.Globalization;

namespace MBINCompilerTests.Database {

    public abstract class AbstractRecord {

        //internal abstract string[] GetColumnHeadings();

        internal AbstractRecord() { }
        //internal AbstractRecord( string[] fields ) { SetFields( fields ); }

        internal abstract void SetFields( string[] fields );
        internal abstract string[] GetFields();

        internal static string ToHexString(    int val ) => $"0x{val:X8}";
        internal static string ToHexString(   uint val ) => $"0x{val:X8}";
        internal static string ToHexString(   long val ) => $"0x{val:X16}";
        internal static string ToHexString(  ulong val ) => $"0x{val:X16}";
        internal static string ToHexString( string val ) => $"0x{val}";

        internal static    int ParseInt(    string hex ) =>   int.Parse( hex.Substring(2), NumberStyles.HexNumber );
        internal static   uint ParseUint(   string hex ) =>  uint.Parse( hex.Substring(2), NumberStyles.HexNumber );
        internal static   long ParseLong(   string hex ) =>  long.Parse( hex.Substring(2), NumberStyles.HexNumber );
        internal static  ulong ParseUlong(  string hex ) => ulong.Parse( hex.Substring(2), NumberStyles.HexNumber );
        internal static string ParseHex(    string hex ) => hex.Substring(2);

        //public static implicit operator string[] ( AbstractRecord record ) { return record.GetFields(); }
    }

}

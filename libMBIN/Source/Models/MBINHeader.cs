using System;
using System.Reflection;
using System.Linq;

namespace libMBIN.Models
{
    public class MBINHeader : NMSTemplate
    {
        private static uint  MBIN_MAGIC    = 0xCCCCCCCC;        // MBIN format ID
        private static uint  MBIN_MAGIC_PC = 0xDDDDDDDD;        // only used by TkGeometryData / .MBIN.PC files, maybe used to signal the file is PC only?
        private static  int  MBIN_VERSION = 2500;               // vanilla version (why not uint?)
        private static ulong MBINCVER_TAG = 0x726576434E49424D; // "revCNIBM" ("MBINCver")

        /* 0x00 */ public uint Magic;              // can be 0xCCCCCCCC, or 0xDDDDDDDD for MBIN.PC files, probably used to seperate PC files from PS4
        /* 0x04 */ public int Version;             // seems to be a version field, game checks this under certain conditions to make sure it's equal to 2500
        //public long BuildDateTime;    // 0x0 for most files, 0xFFFF.. for TkGeometryData files, timestamp eg. 201607201542 (decimal) on global files and older MBINs, likely removed the code that set it at some stage
        //public long TemplateGUID;     // seems to be unique across templates (files using the same template share the same GUID)
        /* 0x08 */ public ulong Tag;               // if the MBIN file was compiled with MBINCompiler this will match MBINCVER_TAG
        /* 0x10 */ public ulong MbinVersion;       // if compiled by MBINCompiler this will contain the version of the compiler
                                        // for TkAnimMetadata files, this is always 0x9B251350AE1ABCA7

        [NMS( Size = 0x40 )] // 64 bytes
        /* 0x18 */ public string TemplateName; // the name of the MBIN struct

        /* 0x58 */ public ulong EndPadding;    // doesn't seem to be used in the game, stores 00.../FE... in the games files
        /* 0x60 */ 

        private string MbinVersionString; // Version of the mbin file as read initially as a string

        public string GetXMLTemplateName() {
            if (TemplateName.StartsWith( "c" ) && (TemplateName.Length > 1)) {
                return TemplateName.Substring( 1 ); // remove the "c" (compiled?) from the start of the template name
            }

            return TemplateName;
        }

        /// <summary>
        /// Get a Version object representing the MBIN file version
        /// if it was compiled with MBINCompiler.
        /// </summary>
        /// <returns>
        /// A <see cref="System.Version"/> object containing the MBINCompiler version
        /// that was used to build the MBIN file. If the file was not compiled
        /// with MBINCompiler, then the version will be "0.0.0.0".
        /// </returns>
        public System.Version GetMBINVersion() {
            System.Version version = new System.Version( "0.0.0.0" );
            if (Tag != MBINCVER_TAG) return version; // not compiled by MBINC
            if (MbinVersionString != null) return version; // already cached

            // get the string representation of MbinVersion and cache it in MbinVersionString
            MbinVersionString = UlongToString(MbinVersion);
            // convert the string to a Version object
            return new System.Version(MbinVersionString);
        }

        public void SetDefaults() {
            Magic   = MBIN_MAGIC;
            Version = MBIN_VERSION;
            Tag     = MBINCVER_TAG;

            // set the 0x10 bytes to be the MBINCompiler version
            MbinVersionString = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            // get just the part we need and pad to 8 bytes
            MbinVersionString = MbinVersionString.Substring( 0, MbinVersionString.Length - 2 ).PadRight( 0x8, Convert.ToChar( 0x00 ) );

            MbinVersion = StringToUlong( MbinVersionString );

            TemplateName = string.Empty;
            EndPadding = 0;
            //Padding58 = ulong.Parse($"{DateTime.Now:yyyyMMddhhmm}"); // may as well make use of this field too
        }

        private ulong StringToUlong(string s) {
            byte[] bytes = s.Select( c => (byte)c ).ToArray();
            return BitConverter.ToUInt64( bytes, 0 );
        }

        private string UlongToString(ulong val) {
            byte[] bytes = (byte[]) BitConverter.GetBytes( val );
            char[] chars = bytes.Select( b => (char) b).ToArray();
            return new string(chars).Substring( 0, 8 );
        }
    }
}

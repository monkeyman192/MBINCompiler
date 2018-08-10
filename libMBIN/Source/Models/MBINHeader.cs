using System;
using System.Reflection;
using System.Linq;

namespace libMBIN.Models
{
    [NMS(Size = 0x60)]
    public class MBINHeader : NMSTemplate
    {
        private static uint  MBIN_MAGIC    = 0xCCCCCCCC;         // MBIN format ID
        private static uint  MBIN_MAGIC_PC = 0xDDDDDDDD;         // only used by TkGeometryData (*.MBIN.PC)
        private static  int  MBIN_VERSION  = 2500;               // vanilla version (why not uint?)
        private static ulong MBINCVER_TAG  = 0x726576434E49424D; // "revCNIBM" ("MBINCver")

        private static ulong TKANIMMETADATA_TAG    = 0xFFFFFFFFFFFFFFFF; // only used for TkAnimMetadata
        private static ulong TKANIMMETADATA_VERSION = 0x9B251350AE1ABCA7; // only used for TkAnimMetadata
        private static ulong TKANIMMETADATA_PADDING = 0xFEFEFEFEFEFEFEFE; // only used for TkAnimMetadata

        /// <summary>
        ///     For *.MBIN files, this value is always 0xCCCCCCCC.
        ///     For *.MBIN.PC files, this is always 0xDDDDDDDD.
        /// </summary>
        /// <remarks>Checked in NMS.exe</remarks>
        /* 0x00 */ public uint Magic { get; set; }

        /// <summary>
        ///     Always 2500.
        ///     Likely a version field for NMS MBIN format.
        /// </summary>
        /// <remarks>Checked in NMS.exe</remarks>
        /* 0x04 */ public int Version { get; set; }

        #region // Vanilla
        /// <summary>
        ///     Only applicable in vanilla NMS MBIN files.
        ///     0x0 for most files.
        ///     0xFFFF.. for TkGeometryData files.
        ///     Timestamp eg. 201607201542 (decimal) on global files and older MBINs, likely removed the code that set it at some stage.
        /// </summary>
        /* 0x08 */ public ulong BuildDateTime => Tag;

        /// <summary>
        ///     Only applicable in vanilla NMS MBIN files.
        ///     Seems to be unique across templates (files using the same template share the same GUID).
        /// </summary>
        /* 0x10 */ public ulong TemplateGUID => MbinVersion;
        #endregion

        #region // MBIN Format v1 (libMBIN)
        /// <summary>
        ///     Only applicable in MBIN files compiled by libMBIN.
        ///     If compiled by libMBIN this will be "MBINCver" encoded as a ulong value (0x726576434E49424D).
        /// </summary>
        /// <remarks>Hijacks the BuildDateTime field.</remarks>
        /* 0x08 */ public ulong Tag { get; set; }

        /// <summary>
        ///     Only applicable in MBIN files compiled by libMBIN.
        ///     If compiled by libMBIN this will contain the version of the compiler.
        /// </summary>
        /* 0x10 */ public ulong MbinVersion { get; set; }
        #endregion

        /// <summary>
        ///     The name of the data template the MBIN file is using.
        ///     Eg. <c>"cGcTestMetadata"</c>
        /// </summary>
        [NMS( Size = 0x40 )] // 64 bytes
        /* 0x18 */ public string TemplateName;

        // doesn't seem to be used in the game, stores 00.../FE... in the games files
        // could be repurposed
        /* 0x58 */ public ulong EndPadding;
        /* Size = 0x60 */ 

        private string MbinVersionString; // Version of the mbin file as read initially as a string

        public bool IsValid => ((Magic == MBIN_MAGIC) || (Magic == MBIN_MAGIC_PC)) && (Version == MBIN_VERSION);

        public string GetXMLTemplateName() {
            if (TemplateName.StartsWith( "c" ) && (TemplateName.Length > 1)) {
                return TemplateName.Substring( 1 ); // remove the "c" (compiled?) from the start of the template name
            }

            return TemplateName;
        }

        /// <summary>
        /// Get a Version object representing the MBIN file version, if it was compiled with MBINCompiler.
        /// </summary>
        /// <returns>
        /// A <see cref="System.Version"/> object containing the MBINCompiler version that was used to build the MBIN file. If the file was not compiled with MBINCompiler, then the version will be "0.0.0.0".
        /// </returns>
        public System.Version GetMBINVersion() {
            System.Version version = new System.Version( "0.0.0.0" );
            if (Tag != MBINCVER_TAG) return version; // not compiled by MBINC

            // get the string representation of MbinVersion and cache it in MbinVersionString
            if (MbinVersionString == null) MbinVersionString = UlongToString(MbinVersion);

            // convert the string to a Version object
            return new System.Version( MbinVersionString );
        }

        public void SetDefaults( Type type = null ) {
            // MBIN_MAGIC_PC is only used by TkGeometryData (*.MBIN.PC)
            Magic   = (type == typeof( Models.Structs.TkGeometryData )) ? MBIN_MAGIC_PC : MBIN_MAGIC;
            Version = MBIN_VERSION;
            Tag     = MBINCVER_TAG;

            // set the 0x10 bytes to be the MBINCompiler version
            // get just the part we need and pad to 8 bytes
            MbinVersionString = libMBIN.Version.AssemblyVersion.ToString( 3 ).PadRight( 8, '\0' );

            MbinVersion = StringToUlong( MbinVersionString );

            TemplateName = string.Empty;
            EndPadding = 0;
            //Padding58 = ulong.Parse($"{DateTime.Now:yyyyMMddhhmm}"); // may as well make use of this field too

            if (type == typeof( Models.Structs.TkAnimMetadata )) {
                Tag = TKANIMMETADATA_TAG;
                MbinVersion = TKANIMMETADATA_VERSION;
                EndPadding = TKANIMMETADATA_PADDING;
            }
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

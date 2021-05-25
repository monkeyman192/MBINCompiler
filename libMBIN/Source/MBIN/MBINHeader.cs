using System;
using System.Reflection;
using System.Text;

namespace libMBIN
{
    [NMS(Size = 0x60)]
    public class MBINHeader : NMSTemplate
    {
        internal const uint  MBIN_MAGIC    = 0xCCCCCCCC;         // MBIN format ID
        internal const uint  MBIN_MAGIC_PC = 0xDDDDDDDD;         // only used by TkGeometryData and TkGeometryStreamData (*.MBIN.PC)
        internal const uint  MBIN_VERSION  = 2500;               // vanilla version

        // used for format V1
        internal const ulong MBINCVER_TAG  = 0x726576434E49424D; // "revCNIBM" ("MBINCver")

        // used for format V1
        internal const ulong TKANIMMETADATA_TAG     = 0xFFFFFFFFFFFFFFFF; // only used for TkAnimMetadata
        internal const ulong TKANIMMETADATA_VERSION = 0x3CD7D2192958BA6C; // only used for TkAnimMetadata
        internal const ulong TKANIMMETADATA_PADDING = 0xFEFEFEFEFEFEFEFE; // only used for TkAnimMetadata

        // used for format V2
        internal const ulong TKGEOMETRYDATA_TAG     = 0xFFFFFFFFFFFFFFFF; // used by TkGeometryData and TkGeometryStreamData
        internal const ulong TKGEOMETRYDATA_PADDING = 0xFEFEFEFEFEFEFEFE; // used by TkGeometryData and TkGeometryStreamData

        public enum Format { V0, V1, V2 }

        #region // Fields

        /// <summary><b><i>Format V0, V1 and V2:</i></b>
        ///     For *.MBIN files, this value is always 0xCCCCCCCC.
        ///     For *.MBIN.PC files, this is always 0xDDDDDDDD.
        /// </summary>
        /* 0x00 */ public uint MagicID;// { get; set; }

        /// <summary>
        /// <b><i>Format V0:</i></b>
        ///     Always 2500. Likely a version field for NMS MBIN format.
        /// <b><i>Format V2:</i></b>
        ///     Low short is NMS Format ID (always 2500)
        ///     High short is libMBIN Format ID. (always 0 for format V0 and V1)
        /// </summary>
        /* 0x04 */ public uint FormatID;// { get; set; }

        /// <summary><b><i>Format V0 (Vanilla NMS):</i></b>
        ///     Only applicable in vanilla NMS MBIN files.
        ///     0x0 for most files.
        ///     0xFFFF.. for TkGeometryData files.
        ///     Timestamp eg. 201607201542 (decimal) on global files and older MBINs, likely removed the code that set it at some stage.
        /// </summary>
        /* 0x08 */ public ulong Timestamp;

        /// <summary><b><i>Format V0 and V2:</i></b>
        ///     Unique across templates (files using the same template share the same GUID).
        /// </summary>
        /* 0x10 */ public ulong TemplateGUID;

        /// <summary><b><i>Format V0, V1 and V2:</i></b>
        ///     The name of the data template the MBIN file is using.
        ///     Eg. <c>"cGcTestMetadata"</c>
        /// </summary>
        /// <remarks>Do not Change. Required in NMS.exe</remarks>
        [NMS( Size = 0x40 )] // 64 bytes
        /* 0x18 */ public string TemplateName;

        /// <summary><b><i>Format V0 and V1:</i></b> Not used.</summary>
        /* 0x58 */ public ulong EndPadding;
        /* Size = 0x60 */

        #endregion

        #region // V1 Properties

        /// <summary><b><i>Format V1:</i></b>
        ///     If compiled by libMBIN this will be "MBINCver" encoded as a ulong value (0x726576434E49424D).
        /// </summary>
        /// <remarks>Hijacks the Timestamp field.</remarks>
        /// <seealso cref="Timestamp"/>
        /* 0x08 */ public ulong Tag { get => Timestamp; internal set => Timestamp = value; }

        /// <summary><b><i>Format V1:</i></b>
        ///     If compiled by libMBIN this will contain the version of the compiler.
        /// </summary>
        /// <remarks>Hijacks the TemplateGUID field.</remarks>
        /* 0x10 */ public ulong MbinVersion { get => TemplateGUID; internal set => TemplateGUID = value; }

        #endregion

        #region // V2 Properties

        /// <summary><b><i>Format V2:</i></b>
        ///     The low short from <see cref="FormatID"/>. (always 2500)
        /// </summary>
        /// <seealso cref="FormatAPI"/>
        /// <seealso cref="FormatID"/>
        /* 0x04 */ public ushort FormatNMS {
            get => (ushort) FormatID;
            internal set => FormatID = value | ((uint) FormatAPI << 16);
        }

        /// <summary><b><i>Format V2:</i></b>
        ///     The high short from <see cref="FormatID"/>.
        ///     For format V0 and V1, this is always 0.
        ///     For later versions, this will be the version number.
        ///     Eg. for Format V2, this is 2.
        /// </summary>
        /// <seealso cref="FormatNMS"/>
        /// <seealso cref="FormatID"/>
        /* 0x06 */ public ushort FormatAPI {
            get => (ushort) (FormatID >> 16);
            internal set => FormatID = FormatNMS | ((uint) value << 16);
        }

        /// <summary><b><i>Format V2:</i></b>
        ///     Stores the NMS (low word) and API (high word) versions. 
        /// </summary>
        /// <remarks>Hijacks the Timestamp field.</remarks>
        /* 0x08 */ public ulong VersionID { get => Timestamp; internal set => Timestamp = value; }

        /* 0x08 */ internal uint VersionID_NMS {
            get => (uint) VersionID;
            set => VersionID = value | ((ulong) VersionID_API << 32);
        }

        /// <summary><b><i>Format V2:</i></b>
        ///     The version of NMS that this file is compiled for.
        ///     This converts the low word for <see cref="VersionID"/> to/from a
        ///     <see cref="System.Version"/> object.
        /// </summary>
        /// <seealso cref="VersionAPI"/>
        /// <seealso cref="VersionID"/>
        /* 0x08 */ public System.Version VersionNMS {
            get => new System.Version(
                        (int) (VersionID_NMS >>  0) & 0xFF,
                        (int) (VersionID_NMS >>  8) & 0xFF,
                        (int) (VersionID_NMS >> 16) & 0xFF,
                        (int) (VersionID_NMS >> 24) & 0xFF );
            internal set => VersionID_NMS = (uint) (
                        (value.Major << 0) | (value.Minor << 8) | (value.Build << 16) | (value.Revision << 24) );
        }

        /* 0x0C */ internal uint VersionID_API {
            get => (uint) (VersionID >> 32);
            set => VersionID = VersionID_NMS | ((ulong) value << 32);
        }

        /// <summary><b><i>Format V2:</i></b>
        ///     The version of the libMBIN API that this file was compiled with.
        ///     This converts the high word for <see cref="VersionID"/> to/from a
        ///     <see cref="System.Version"/> object.
        /// </summary>
        /// <seealso cref="VersionNMS"/>
        /// <seealso cref="VersionID"/>
        /* 0x0C */ public System.Version VersionAPI {
            get => new System.Version(
                        (int) (VersionID_API >>  0) & 0xFF,
                        (int) (VersionID_API >>  8) & 0xFF,
                        (int) (VersionID_API >> 16) & 0xFF,
                        (int) (VersionID_API >> 24) & 0xFF );
            internal set => VersionID_API = (uint) (
                        (value.Major << 0) | (value.Minor << 8) | (value.Build << 16) | (value.Revision << 24) );
        }

        /// <summary><b><i>Format V2:</i></b>
        ///     Stores the offset from the start of the file to the location where
        ///     (libMBIN exclusive) custom metadata may be stored.
        ///     If 0, there is no metadata.
        /// </summary>
        /// <remarks>Hijacks the EndPadding field.</remarks>
        /// <seealso cref="EndPadding"/>
        /* 0x58 */ public ulong MetaOffset { get => EndPadding; internal set => EndPadding = value; }
        #endregion

        // used for format V1
        private string MbinVersionString; // Version of the mbin file as read initially as a string

        public bool IsValid => ((MagicID == MBIN_MAGIC) || (MagicID == MBIN_MAGIC_PC)) && (FormatNMS == MBIN_VERSION);

        public int GetFormat() => IsFormatV0 ? 0 : IsFormatV1 ? 1 : FormatAPI;

        public bool IsFormatV0 => (FormatAPI == 0) && (Tag != MBINCVER_TAG);
        public bool IsFormatV1 => (FormatAPI == 0) && (Tag == MBINCVER_TAG);
        public bool IsFormatV2 => (FormatAPI == 2);

        // remove the "c" (compiled?) from the start of the template name
        public string GetXMLTemplateName() {
            if ( (TemplateName?.Length ?? 0) == 0 ) return TemplateName;
            if ( TemplateName[0] != 'c' )           return TemplateName;
            return TemplateName.Substring( 1 ); 
        }

        /// <summary>
        /// Get a Version object representing the MBIN file version, if it was compiled with MBINCompiler.
        /// </summary>
        /// <returns>
        /// A <see cref="System.Version"/> object containing the MBINCompiler version that was used to build the MBIN file. If the file was not compiled with MBINCompiler, then the version will be "0.0.0.0".
        /// </returns>
        public System.Version GetMBINVersion() {
            if (IsFormatV0) return new System.Version( "0.0.0.0" );
            if (IsFormatV1) {
                // get the string representation of MbinVersion and cache it in MbinVersionString
                if (MbinVersionString == null) MbinVersionString = UlongToString(MbinVersion);
                return new System.Version( MbinVersionString );
            }
            return VersionAPI;
        }

        public void SetDefaultsV0( Type type = null ) {
            // MBIN_MAGIC_PC is only used by TkGeometryData (*.MBIN.PC)
            MagicID      = (type == typeof(NMS.Toolkit.TkGeometryData) | type == typeof(NMS.Toolkit.TkGeometryStreamData)) ? MBIN_MAGIC_PC : MBIN_MAGIC;
            FormatID     = MBIN_VERSION;
            Timestamp    = 0;
            TemplateGUID = type?.GetCustomAttribute<NMSAttribute>()?.GUID ?? 0;
            TemplateName = string.Empty;
            EndPadding   = 0;

            if (type == typeof( NMS.Toolkit.TkAnimMetadata ) ) {
                Tag         = TKANIMMETADATA_TAG;
                MbinVersion = TKANIMMETADATA_VERSION;
                EndPadding  = TKANIMMETADATA_PADDING;
            }
            else if (type == typeof(NMS.Toolkit.TkGeometryData) | type == typeof(NMS.Toolkit.TkGeometryStreamData))
            {
                Tag        = TKGEOMETRYDATA_TAG;
                EndPadding = TKGEOMETRYDATA_PADDING;
            }
        }

        public void SetDefaultsV1( Type type = null ) {
            SetDefaultsV0( type );
            if ( type == typeof( NMS.Toolkit.TkAnimMetadata ) | type == typeof(NMS.Toolkit.TkGeometryData) | type == typeof(NMS.Toolkit.TkGeometryStreamData)) return;

            Tag = MBINCVER_TAG;

            // set the 0x10 bytes to be the MBINCompiler version
            // get just the part we need and pad to 8 bytes
            MbinVersionString = Version.AssemblyVersion.ToString( 3 ).PadRight( 8, '\0' );
            MbinVersion = StringToUlong( MbinVersionString );
        }

        public void SetDefaultsV2( Type type = null ) {
            SetDefaultsV0( type );
            if (type == typeof(NMS.Toolkit.TkAnimMetadata) | type == typeof(NMS.Toolkit.TkGeometryData) | type == typeof(NMS.Toolkit.TkGeometryStreamData)) return;

            FormatAPI = 2;
            VersionNMS = Version.NMSVersion;
            VersionAPI = Version.AssemblyVersion;
        }

        public void SetDefaults( Type type = null, Format format = Format.V2 ) {
            switch (format) {
                case Format.V0: SetDefaultsV0( type ); break;
                case Format.V1: SetDefaultsV1( type ); break;
                default:        SetDefaultsV2( type ); break;
            }
        }

        internal static ulong StringToUlong( string s ) {
            return BitConverter.ToUInt64( Encoding.ASCII.GetBytes( s ), 0 );
        }

        internal static string UlongToString(ulong val) {
            return Encoding.ASCII.GetString( BitConverter.GetBytes( val ) );
        }
    }
}

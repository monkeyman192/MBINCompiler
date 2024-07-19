using System;
using System.Reflection;
using System.Text;
using System.Globalization;

namespace libMBIN
{
    [NMS(Size = 0x20, Alignment = 0x8)]
    public class MBINHeader : NMSTemplate
    {
        public enum Format { V0, V1, V2, V3, V4 }
        internal const ulong MBIN_MAGIC    = 0xCCCCCCCCCCCCCCCC;         // MBIN format ID
        internal const ulong MBIN_MAGIC_PC = 0xDDDDDDDDDDDDDDDD;         // only used by TkGeometryData and TkGeometryStreamData (*.MBIN.PC)
        internal const ushort MBIN_VERSION = 3300;               // vanilla version with ordered fields and no template name.
        internal const ushort MBINCOMPILER_HEADER_VERSION = 4;
        internal const uint HEADER_SIZE = 0x20;  // Setting this here so that we can look it up faster than using inspection.

        #region // Fields

        /// <summary><b><i>All formats:</i></b>
        ///     For *.MBIN files, this value is always 0xCCCCCCCCCCCCCCCC.
        ///     For *.MBIN.PC files, this is always 0xDDDDDDDDDDDDDDDD.
        /// </summary>
        /* 0x00 */ public ulong MagicID;

        /// <summary>
        /// <b><i>Format V3:</i></b>
        ///     NMS MBIN format version (Always 3250)
        /// </summary>
        /* 0x08 */ public ushort MbinVersion;

        /* 0x0A */ public ushort MbinCompilerHeaderVersion;

        /* 0x0C */ public uint NameHash;

        /// <summary><b><i>Format V0, V2 and V3:</i></b>
        ///     Unique across templates (files using the same template share the same GUID).
        /// </summary>
        /* 0x10 */ public ulong TemplateGUID;

        /// <summary><b><i>Timestamp:</i></b>
        /// For a vanilla file this can be either empty, the actual timestamp, or all \xFF's
        /// For a modded file this will have the low 4 bytes as the NMS/MBINCompiler version,
        /// and the high 4 bytes are reserved for future use.
        /// </summary>
        /* 0x18 */ public ulong Timestamp;

        #endregion

        #region // Properties

        /// <summary><b><i>Format V2:</i></b>
        ///     Stores the NMS (low word) and API (high word) versions. 
        /// </summary>
        /// <remarks>Hijacks the Timestamp field.</remarks>
        /* 0x18 */ public ulong VersionID { get => Timestamp; internal set => Timestamp = value; }

        /* 0x18 */ internal uint VersionID_NMS {
            get => (uint) VersionID;
            set => VersionID = value | ((ulong) VersionID_API);
        }

        /* 0x1C */ internal uint VersionID_API {
            get => (uint) VersionID;
            set => VersionID = VersionID_NMS | ((ulong) value);
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

        #endregion

        public bool IsValid => (
            ((MagicID == MBIN_MAGIC) || (MagicID == MBIN_MAGIC_PC)) && (MbinVersion == MBIN_VERSION)
        );

        public int GetFormat() {
            if (IsValid) return 4;
            return -1;
        }

        // remove the "c" (compiled?) from the start of the template name
        public string GetXMLTemplateName() {
            NMSTemplate.NameHashToNameMap.TryGetValue(NameHash, out string TemplateName);
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
            return VersionAPI;
        }

        public void SetDefaults( Type type = null, Format format = Format.V4 ) {
            // MBIN_MAGIC_PC is only used by TkGeometryData (*.MBIN.PC)
            MagicID      = (type == typeof(NMS.Toolkit.TkGeometryData) | type == typeof(NMS.Toolkit.TkGeometryStreamData)) ? MBIN_MAGIC_PC : MBIN_MAGIC;
            MbinVersion  = MBIN_VERSION;
            Timestamp    = 0;
            NameHash     = type?.GetCustomAttribute<NMSAttribute>()?.NameHash ?? 0;
            TemplateGUID = type?.GetCustomAttribute<NMSAttribute>()?.GUID ?? 0;
            MbinCompilerHeaderVersion = MBINCOMPILER_HEADER_VERSION;

            VersionAPI = Version.AssemblyVersion;
        }

        public bool IsModded() {
            return MbinCompilerHeaderVersion == MBINCOMPILER_HEADER_VERSION;
        }

        internal static ulong StringToUlong( string s ) {
            return BitConverter.ToUInt64( Encoding.ASCII.GetBytes( s ), 0 );
        }

        internal static string UlongToString(ulong val) {
            return Encoding.ASCII.GetString( BitConverter.GetBytes( val ) );
        }
    }
}

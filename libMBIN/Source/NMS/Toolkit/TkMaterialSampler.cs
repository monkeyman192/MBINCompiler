namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x17323BADBC4CF02D, NameHash = 0xA42C786)]
    public class TkMaterialSampler : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A MaterialAlternativeId;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString Map;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Name;
        [NMS(Index = 9)]
        /* 0x40 */ public int Anisotropy;
        // size: 0x5
        public enum TextureAddressModeEnum : uint {
            Wrap,
            WrapUClampV,
            Clamp,
            ClampToBorder,
            Mirror,
        }
        [NMS(Index = 7)]
        /* 0x44 */ public TextureAddressModeEnum TextureAddressMode;
        // size: 0x3
        public enum TextureFilterModeEnum : uint {
            None,
            Bilinear,
            Trilinear,
        }
        [NMS(Index = 8)]
        /* 0x48 */ public TextureFilterModeEnum TextureFilterMode;
        [NMS(Index = 2)]
        /* 0x4C */ public bool IsCube;
        [NMS(Index = 5)]
        /* 0x4D */ public bool IsSRGB;
        [NMS(Index = 3)]
        /* 0x4E */ public bool UseCompression;
        [NMS(Index = 4)]
        /* 0x4F */ public bool UseMipMaps;
    }
}

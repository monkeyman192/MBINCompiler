namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC65052A26EF49760, NameHash = 0x330286CE11647D4C)]
    public class TkMaterialSampler : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A MaterialAlternativeId;
        [NMS(Index = 9)]
        /* 0x20 */ public int Anisotropy;
        // size: 0x4
        public enum TextureAddressModeEnum : uint {
            Wrap,
            Clamp,
            ClampToBorder,
            Mirror,
        }
        [NMS(Index = 7)]
        /* 0x24 */ public TextureAddressModeEnum TextureAddressMode;
        // size: 0x3
        public enum TextureFilterModeEnum : uint {
            None,
            Bilinear,
            Trilinear,
        }
        [NMS(Index = 8)]
        /* 0x28 */ public TextureFilterModeEnum TextureFilterMode;
        [NMS(Index = 1)]
        /* 0x2C */ public NMSString0x80 Map;
        [NMS(Index = 0)]
        /* 0xAC */ public NMSString0x20 Name;
        [NMS(Index = 2)]
        /* 0xCC */ public bool IsCube;
        [NMS(Index = 5)]
        /* 0xCD */ public bool IsSRGB;
        [NMS(Index = 3)]
        /* 0xCE */ public bool UseCompression;
        [NMS(Index = 4)]
        /* 0xCF */ public bool UseMipMaps;
    }
}

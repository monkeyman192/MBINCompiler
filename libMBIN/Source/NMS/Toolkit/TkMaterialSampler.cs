namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB1F00BB1F804178A, NameHash = 0x330286CE11647D4C)]
    public class TkMaterialSampler : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A MaterialAlternativeId;
        /* 0x20 */ public int Anisotropy;
        // size: 0x4
        public enum TextureAddressModeEnum : uint {
            Wrap,
            Clamp,
            ClampToBorder,
            Mirror,
        }
        /* 0x24 */ public TextureAddressModeEnum TextureAddressMode;
        // size: 0x3
        public enum TextureFilterModeEnum : uint {
            None,
            Bilinear,
            Trilinear,
        }
        /* 0x28 */ public TextureFilterModeEnum TextureFilterMode;
        /* 0x2C */ public NMSString0x80 Map;
        /* 0xAC */ public NMSString0x20 Name;
        /* 0xCC */ public bool IsCube;
        /* 0xCD */ public bool IsSRGB;
        /* 0xCE */ public bool UseCompression;
        /* 0xCF */ public bool UseMipMaps;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8CE6144467FBF05A, NameHash = 0x330286CE11647D4C)]
    public class TkMaterialSampler : NMSTemplate
    {
        public NMSString0x20 Name;
        public NMSString0x80 Map;
        public bool IsCube;
        public bool UseCompression;
        public bool UseMipMaps;
        public bool IsSRGB;
        public NMSString0x20A MaterialAlternativeId;
		public enum TextureAddressModeEnum { Wrap, Clamp, ClampToBorder, Mirror }
		public TextureAddressModeEnum TextureAddressMode;

		public enum TextureFilterModeEnum { None, Bilinear, Trilinear }
		public TextureFilterModeEnum TextureFilterMode;

        public int Anisotropy;
    }
}
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xD8, Alignment = 0x8, GUID = 0x8CE6144467FBF05A, NameHash = 0x330286CE11647D4C)]
    public class TkMaterialSampler : NMSTemplate
    {
        public NMSString0x20 Name;
        public NMSString0x80 Map;
        public bool IsCube;
        public bool UseCompression;
        public bool UseMipMaps;
        public bool IsSRGB;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingA4;
        public NMSString0x20 MaterialAlternativeId;
		public enum TextureAddressModeEnum { Wrap, Clamp, ClampToBorder, Mirror }
		public TextureAddressModeEnum TextureAddressMode;

		public enum TextureFilterModeEnum { None, Bilinear, Trilinear }
		public TextureFilterModeEnum TextureFilterMode;

        public int Anisotropy;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC4;
    }
}
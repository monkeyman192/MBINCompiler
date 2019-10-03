using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Alignment = 0x8, GUID = 0x8CE6144467FBF05A, NameHash = 0x330286CE11647D4C)]
    public class TkMaterialSampler : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Map;
        public bool IsCube;
        public bool UseCompression;
        public bool UseMipMaps;
        public bool IsSRGB;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingA4;
        [NMS(Size = 0x20)]
        public string MaterialAlternativeId;
		public enum TextureAddressModeEnum { Wrap, Clamp, ClampToBorder, Mirror }
		public TextureAddressModeEnum TextureAddressMode;

		public enum TextureFilterModeEnum { None, Bilinear, Trilinear }
		public TextureFilterModeEnum TextureFilterMode;

        public int Anisotropy;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC4;
    }
}

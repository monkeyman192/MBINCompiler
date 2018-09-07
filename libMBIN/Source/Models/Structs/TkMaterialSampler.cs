namespace libMBIN.Models.Structs
{
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

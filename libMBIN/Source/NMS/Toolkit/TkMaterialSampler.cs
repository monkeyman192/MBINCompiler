using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
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
        public NMSString0x10 MaterialAlternativeId;
        public int TextureAddressMode;
        public string[] TextureAddressModeValues()
        {
            return new[] { "Wrap", "Clamp", "ClampToBorder", "Mirror" };
        }

        public int TextureFilterMode;
        public string[] TextureFilterModeValues()
        {
            return new[] { "None", "Bilinear", "Trilinear" };
        }

        public int Anisotropy;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC4;
    }
}

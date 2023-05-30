using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkProceduralTexture : NMSTemplate
    {
        public NMSString0x10 Name;

        public TkPaletteTexture Palette;
        public float Probability;
        public int TextureGameplayUse;

        public string[] TextureGameplayUseValues()
        {
            return new[] { "IgnoreName", "MatchName", "DoNotMatchName" };
        }

        public bool OverrideAverageColour;
        public Colour AverageColour;

        public NMSString0x80 Diffuse;

        public NMSString0x80 Normal;

        public NMSString0x80 Mask;
    }
}

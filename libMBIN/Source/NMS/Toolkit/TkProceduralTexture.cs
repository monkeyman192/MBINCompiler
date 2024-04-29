using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9F76C3595E94342A, NameHash = 0x75816D38B6B42FE4)]
    public class TkProceduralTexture : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public Colour AverageColour;
        [NMS(Index = 0)]
        /* 0x010 */ public NMSString0x20A Name;
        [NMS(Index = 1)]
        /* 0x030 */ public TkPaletteTexture Palette;
        [NMS(Index = 2)]
        /* 0x038 */ public float Probability;
        // size: 0x3
        public enum TextureGameplayUseEnum : uint {
            IgnoreName,
            MatchName,
            DoNotMatchName,
        }
        [NMS(Index = 3)]
        /* 0x03C */ public TextureGameplayUseEnum TextureGameplayUse;
        [NMS(Index = 6)]
        /* 0x040 */ public NMSString0x80 Diffuse;
        [NMS(Index = 8)]
        /* 0x0C0 */ public NMSString0x80 Mask;
        [NMS(Index = 7)]
        /* 0x140 */ public NMSString0x80 Normal;
        [NMS(Index = 4)]
        /* 0x1C0 */ public bool OverrideAverageColour;
    }
}

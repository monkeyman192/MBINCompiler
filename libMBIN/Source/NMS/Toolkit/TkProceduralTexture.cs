using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x41741A32E7319EC1, NameHash = 0x2F1069AA)]
    public class TkProceduralTexture : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public Colour AverageColour;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20A Name;
        [NMS(Index = 7)]
        /* 0x30 */ public VariableSizeString Diffuse;
        [NMS(Index = 11)]
        /* 0x40 */ public VariableSizeString Feature;
        [NMS(Index = 9)]
        /* 0x50 */ public VariableSizeString Mask;
        [NMS(Index = 8)]
        /* 0x60 */ public VariableSizeString Normal;
        [NMS(Index = 10)]
        /* 0x70 */ public VariableSizeString Parallax;
        [NMS(Index = 1)]
        /* 0x80 */ public TkPaletteTexture Palette;
        [NMS(Index = 2)]
        /* 0x88 */ public float Probability;
        // size: 0x3
        public enum TextureGameplayUseEnum : uint {
            IgnoreName,
            MatchName,
            DoNotMatchName,
        }
        [NMS(Index = 3)]
        /* 0x8C */ public TextureGameplayUseEnum TextureGameplayUse;
        [NMS(Index = 4)]
        /* 0x90 */ public bool Multiply;
        [NMS(Index = 5)]
        /* 0x91 */ public bool OverrideAverageColour;
    }
}

using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7CF8D68EBE26F1D2, NameHash = 0x2F1069AA)]
    public class TkProceduralTexture : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public Colour AverageColour;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20A Name;
        [NMS(Index = 7)]
        /* 0x30 */ public GcFilename TextureName;
        [NMS(Index = 1)]
        /* 0x40 */ public TkPaletteTexture Palette;
        [NMS(Index = 2)]
        /* 0x4C */ public float Probability;
        // size: 0x3
        public enum TextureGameplayUseEnum : uint {
            IgnoreName,
            MatchName,
            DoNotMatchName,
        }
        [NMS(Index = 3)]
        /* 0x50 */ public TextureGameplayUseEnum TextureGameplayUse;
        [NMS(Index = 4)]
        /* 0x54 */ public bool Multiply;
        [NMS(Index = 5)]
        /* 0x55 */ public bool OverrideAverageColour;
    }
}

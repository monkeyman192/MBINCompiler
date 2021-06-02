using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1D0, GUID = 0xEDF250D3D9ABB318, NameHash = 0x75816D38B6B42FE4)]
    public class TkProceduralTexture : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public TkPaletteTexture Palette;
        /* 0x028 */ public float Probability;
		public enum TextureGameplayUseEnum { IgnoreName, MatchName, DoNotMatchName }
		public TextureGameplayUseEnum TextureGameplayUse;
        /* 0x030 */ public bool OverrideAverageColour;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x031 */ public byte[] Padding31;
        /* 0x040 */ public Colour AverageColour;
        /* 0x050 */ public NMSString0x80 Diffuse;
        /* 0x0D0 */ public NMSString0x80 Normal;
        /* 0x150 */ public NMSString0x80 Mask;
    }
}

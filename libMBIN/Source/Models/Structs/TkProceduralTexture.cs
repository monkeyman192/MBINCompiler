namespace libMBIN.Models.Structs
{
    public class TkProceduralTexture : NMSTemplate      // size: 0x1D0
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;

        /* 0x020 */ public TkPaletteTexture Palette;
        /* 0x028 */ public float Probability;
		public enum TextureGameplayUseEnum { IgnoreName, MatchName, DoNotMatchName }
		public TextureGameplayUseEnum TextureGameplayUse;

        /* 0x030 */ public bool OverrideAverageColour;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x031 */ public byte[] Padding31;
        /* 0x040 */ public Colour AverageColour;

        [NMS(Size = 0x80)]
        /* 0x050 */ public string Diffuse;

        [NMS(Size = 0x80)]
        /* 0x0D0 */ public string Normal;

        [NMS(Size = 0x80)]
        /* 0x150 */ public string Mask;
    }
}

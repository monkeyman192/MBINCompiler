using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x16C0, GUID = 0xA5943DFEC116B5B7, Alignment = 0x10, NameHash = 0x555E177C27F47DDB)]
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x34, EnumType = typeof(TkPaletteTexture.PaletteEnum))]
        public GcColourPaletteData[] Palettes;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x16C0, GUID = 0xA5943DFEC116B5B7)]
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS( EnumType = typeof( TkPaletteTexture.PaletteEnum ) )]
        public GcColourPaletteData[] Palettes;
    }
}

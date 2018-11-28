using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD340, GUID = 0xD30F287F6E810E96)]
    public class GcPaletteList : NMSTemplate
    {
        [NMS( EnumType = typeof( TkPaletteTexture.PaletteEnum ) )]
        public GcPaletteData[] Palettes;
    }
}

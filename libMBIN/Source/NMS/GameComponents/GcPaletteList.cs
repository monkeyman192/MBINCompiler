using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD340, GUID = 0xD30F287F6E810E96, NameHash = 0xDF4A26E5B1BF936A)]
    public class GcPaletteList : NMSTemplate
    {
        [NMS(Size = 0x34, EnumType = typeof(TkPaletteTexture.PaletteEnum))]
        public GcPaletteData[] Palettes;
    }
}

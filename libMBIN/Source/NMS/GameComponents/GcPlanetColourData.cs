using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x26)]
        public GcColourPaletteData[] Palettes;
    }
}

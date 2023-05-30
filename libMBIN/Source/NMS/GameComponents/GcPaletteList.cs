using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPaletteList : NMSTemplate
    {
        [NMS(Size = 0x26)]
        public GcPaletteData[] Palettes;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Size = 5)]
        public Colour[] Colours;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAB31CFBF20311E9, NameHash = 0x3F4922910DCC54BD)]
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public Colour[] Colours;
        [NMS(Size = 0x5)]
        public int[] ColourIndices;
    }
}

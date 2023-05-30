using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPaletteData : NMSTemplate
    {
        public int NumColours;
        public string[] NumColoursValues()
        {
            return new[] { "Inactive", "1", "4", "16", "All" };
        }

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        [NMS(Size = 0x40)]
        public Colour[] Colours;
    }
}

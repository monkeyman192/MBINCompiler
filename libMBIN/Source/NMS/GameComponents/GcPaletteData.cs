using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x410, GUID = 0xF0E4633B478708FE, NameHash = 0xB66F8D60603D1092)]
    public class GcPaletteData : NMSTemplate
    {
        public enum NumColoursEnum { Inactive, _1, _4, _8, _16, All }
        public NumColoursEnum NumColours;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        [NMS(Size = 0x40)]
        public Colour[] Colours;
    }
}

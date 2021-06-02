using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x9BC6A89E878C831D, NameHash = 0xB499CC97C0515963)]
    public class GcBaseBuildingPalette : NMSTemplate
    {
        public Colour PrimaryColour;
        public Colour SecondaryColour;
        public NMSString0x20 Name;
    }
}

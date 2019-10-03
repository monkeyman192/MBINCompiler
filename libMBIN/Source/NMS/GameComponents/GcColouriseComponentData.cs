using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCCB13805BC4EFC10, NameHash = 0x8F7F2EBCF9C0EDF)]
    public class GcColouriseComponentData : NMSTemplate
    {
        public Colour PrimaryColour;
        public Colour SecondaryColour;
    }
}

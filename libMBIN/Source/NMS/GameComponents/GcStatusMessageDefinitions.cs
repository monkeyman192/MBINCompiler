using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x455D7DC0831DC48D, NameHash = 0x434379BF90DDF679)]
    public class GcStatusMessageDefinitions : NMSTemplate
    {
        public List<GcStatusMessageDefinition> Messages;
        public Colour MissionMarkupColour;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF3CA17CA103F5724, NameHash = 0x1574CF6A0D2BD6C6)]
    public class GcTechList : NMSTemplate
    {
        public List<NMSString0x10> AvailableTech;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA4768229DACCC1, NameHash = 0xD2E65AA0EC314D9C)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        public List<GcJourneyMilestoneData> Table; // called GcJourneyMilestoneTable in the exe
    }
}

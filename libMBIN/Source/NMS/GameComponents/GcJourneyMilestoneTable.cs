using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD134BF6FFEDA2E80, NameHash = 0xD2E65AA0EC314D9C)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyMilestoneData> JourneyMilestoneTable;
    }
}

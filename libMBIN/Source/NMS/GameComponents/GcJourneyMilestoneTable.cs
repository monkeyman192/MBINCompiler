using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C95FB1BB25311BD, NameHash = 0xD2E65AA0EC314D9C)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyMilestoneData> JourneyMilestoneTable;
    }
}

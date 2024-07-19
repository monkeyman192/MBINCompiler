using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF45494377C4902F6, NameHash = 0x51722EF5)]
    public class GcJourneyMilestoneTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcJourneyMilestoneData> JourneyMilestoneTable;
    }
}

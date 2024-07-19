using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x395CB43670E23140, NameHash = 0x574CBA5D)]
    public class GcStatRewardsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatRewardGroup> StatRewardGroups;
    }
}

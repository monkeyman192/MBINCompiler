using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE1F7792F5E626D9, NameHash = 0x949BD8619D1DA144)]
    public class GcStatRewardsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatRewardGroup> StatRewardGroups;
    }
}

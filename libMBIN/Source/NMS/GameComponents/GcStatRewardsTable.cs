using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE0F386B97DB6C68F, NameHash = 0x949BD8619D1DA144)]
    public class GcStatRewardsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatRewardGroup> StatRewardGroups;
    }
}

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E1C4686E498F8BB, NameHash = 0x949D182E)]
    public class GcRewardRecycleSpecificObject : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A RewardMessage;
        [NMS(Index = 0)]
        /* 0x20 */ public List<NMSString0x10> ExtraStats;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x10 RewardMessageSubstanceForIcon;
        [NMS(Index = 1)]
        /* 0x40 */ public int Value;
    }
}

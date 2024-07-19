using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x55E14A6D234EC721, NameHash = 0x55850C4B)]
    public class GcMissionSequenceConditionalReward : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 4)]
        /* 0x10 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 RewardIfFalse;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 RewardIfTrue;
        [NMS(Index = 2)]
        /* 0x40 */ public GcMissionConditionTest ConditionTest;
    }
}

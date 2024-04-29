using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC0B1D3839B8304F, NameHash = 0x4A3E875FBE0AEA1D)]
    public class GcMissionSequenceConditionalReward : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 RewardIfFalse;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 RewardIfTrue;
        [NMS(Index = 2)]
        /* 0x30 */ public GcMissionConditionTest ConditionTest;
        [NMS(Index = 4)]
        /* 0x34 */ public NMSString0x80 DebugText;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0089B6F057AF2B, NameHash = 0x4A3E875FBE0AEA1D)]
    public class GcMissionSequenceConditionalReward : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Conditions;
        /* 0x10 */ public NMSString0x10 RewardIfFalse;
        /* 0x20 */ public NMSString0x10 RewardIfTrue;
        /* 0x30 */ public GcMissionConditionTest ConditionTest;
        /* 0x34 */ public NMSString0x80 DebugText;
    }
}

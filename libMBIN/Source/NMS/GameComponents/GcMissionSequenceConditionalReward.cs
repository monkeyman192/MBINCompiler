using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2108991F48DCA41F, NameHash = 0x4A3E875FBE0AEA1D)]
    public class GcMissionSequenceConditionalReward : NMSTemplate
    {
        public NMSString0x10 RewardIfTrue;
        public NMSString0x10 RewardIfFalse;
        public GcMissionConditionTest ConditionTest;
        public List<NMSTemplate> Conditions;
        public NMSString0x80 DebugText;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB8, GUID = 0x2108991F48DCA41F, NameHash = 0x4A3E875FBE0AEA1D)]
    public class GcMissionSequenceConditionalReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string RewardIfTrue;
        [NMS(Size = 0x10)]
        public string RewardIfFalse;
        public GcMissionConditionTest ConditionTest;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding24;
        public List<NMSTemplate> Conditions;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

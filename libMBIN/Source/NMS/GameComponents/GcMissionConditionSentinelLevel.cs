using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2553FB84ED818C60, NameHash = 0xB45DF78C123D703E)]
    public class GcMissionConditionSentinelLevel : NMSTemplate
    {
        public enum RequiredSentinelLevelEnum { None, Low, Default, Aggressive }
        public RequiredSentinelLevelEnum RequiredSentinelLevel;
    }
}
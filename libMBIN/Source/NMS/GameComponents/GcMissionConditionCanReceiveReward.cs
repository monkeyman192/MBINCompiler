using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x96FEB7E2FEA00BC5, NameHash = 0x1108B5A70EA9DF1A)]
    public class GcMissionConditionCanReceiveReward : NMSTemplate
    {
        public NMSString0x10 Reward;
    }
}
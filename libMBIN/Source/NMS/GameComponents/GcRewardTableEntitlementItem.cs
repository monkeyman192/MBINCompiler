using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x85B887A3C1D9BD55, NameHash = 0x728CF5B9DDC60AD4)]
    public class GcRewardTableEntitlementItem : NMSTemplate
    {
        public NMSString0x10 RewardId;
        public NMSString0x10 EntitlementId;
        public NMSTemplate Reward;
    }
}

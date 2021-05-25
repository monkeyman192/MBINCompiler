using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xA2D4F94DB103412, NameHash = 0x27C5678B5AA766C2)]
    public class GcRewardScanEventOutcome : NMSTemplate
    {
        // size: 0x7
        public enum RewardScanEventOutcomeEnum { Success, Interstellar, BadData, FailedToFindBase, Duplicate, NoBuilding, NoSystem }
        public RewardScanEventOutcomeEnum RewardScanEventOutcome;
    }
}
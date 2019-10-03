using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA2D4F94DB103412, NameHash = 0x27C5678B5AA766C2)]
    public class GcRewardScanEventOutcome : NMSTemplate
    {
        // 0x7 entries
        public enum RewardScanEventOutcomeEnum { Success, Interstellar, BadData, FailedToFindBase, Duplicate, NoBuilding, NoSystem }
        public RewardScanEventOutcomeEnum RewardScanEventOutcome;
    }
}

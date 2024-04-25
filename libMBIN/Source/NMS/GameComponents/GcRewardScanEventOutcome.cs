namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B2510C614EF8484, NameHash = 0x27C5678B5AA766C2)]
    public class GcRewardScanEventOutcome : NMSTemplate
    {
        // size: 0x7
        public enum RewardScanEventOutcomeEnum : uint {
            Success,
            Interstellar,
            BadData,
            FailedToFindBase,
            Duplicate,
            NoBuilding,
            NoSystem,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RewardScanEventOutcomeEnum RewardScanEventOutcome;
    }
}

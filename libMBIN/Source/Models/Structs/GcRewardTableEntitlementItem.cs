namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x68)]
    public class GcRewardTableEntitlementItem : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string RewardId;
        [NMS(Size = 0x10)]
        public string EntitlementId;
        public NMSTemplate Reward;
    }
}

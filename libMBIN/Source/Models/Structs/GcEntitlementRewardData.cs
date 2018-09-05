namespace libMBIN.Models.Structs
{
    public class GcEntitlementRewardData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string EntitlementId;

        [NMS(Size = 0x10)]
        public string RewardId;

        [NMS(Size = 0x20)]
        public string Name;

        [NMS(Size = 0x20)]
        public string Error;
    }
}

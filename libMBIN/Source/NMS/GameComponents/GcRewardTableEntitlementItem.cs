namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A98656C67C78B51, NameHash = 0x728CF5B9DDC60AD4)]
    public class GcRewardTableEntitlementItem : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSTemplate Reward;
        [NMS(Index = 1)]
        /* 0x50 */ public NMSString0x10 EntitlementId;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x10 RewardId;
    }
}

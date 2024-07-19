namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC77D30C9E5BA32C2, NameHash = 0x8883E76F)]
    public class GcRewardTableEntitlementItem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 EntitlementId;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSTemplate Reward;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 RewardId;
    }
}

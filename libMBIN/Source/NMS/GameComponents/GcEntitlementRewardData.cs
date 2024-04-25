namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A88D23C53219B88, NameHash = 0x748EDC86AFA4F5A3)]
    public class GcEntitlementRewardData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A Error;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A Name;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 EntitlementId;
        [NMS(Index = 1)]
        /* 0x50 */ public NMSString0x10 RewardId;
    }
}

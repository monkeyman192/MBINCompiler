namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A88D23C53219B88, NameHash = 0x748EDC86AFA4F5A3)]
    public class GcEntitlementRewardData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Error;
        /* 0x20 */ public NMSString0x20A Name;
        /* 0x40 */ public NMSString0x10 EntitlementId;
        /* 0x50 */ public NMSString0x10 RewardId;
    }
}

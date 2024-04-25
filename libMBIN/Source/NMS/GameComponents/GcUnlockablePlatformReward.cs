namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB042A79D6D9B42BA, NameHash = 0x639E6618156B37C)]
    public class GcUnlockablePlatformReward : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 ProductId;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 RewardId;
    }
}

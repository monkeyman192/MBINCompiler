namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15E8ED259A31A171, NameHash = 0x3D602C43)]
    public class GcUnlockablePlatformReward : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 ProductId;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 RewardId;
    }
}

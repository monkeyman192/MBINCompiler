namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5AAFC3D082A770F7, NameHash = 0xC34E43C2)]
    public class GcRewardHealth : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 2)]
        /* 0x8 */ public bool SilentUnlessShieldAtMax;
    }
}

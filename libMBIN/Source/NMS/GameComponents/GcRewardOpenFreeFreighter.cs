namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD215FE9145145C73, NameHash = 0x4DD6C74BA4B6AD5A)]
    public class GcRewardOpenFreeFreighter : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A NextInteractionIfBought;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A NextInteractionIfNotBought;
        [NMS(Index = 0)]
        /* 0x40 */ public bool ReinteractWhenBought;
    }
}

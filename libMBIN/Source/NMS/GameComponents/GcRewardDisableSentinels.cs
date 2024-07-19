namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1728C908172FDEC2, NameHash = 0xC8E666B2)]
    public class GcRewardDisableSentinels : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A WantedBarMessage;
        [NMS(Index = 0)]
        /* 0x40 */ public float Duration;
    }
}

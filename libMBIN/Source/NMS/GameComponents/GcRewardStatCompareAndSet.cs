namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0373B87295140F5, NameHash = 0x63E76E3324C90001)]
    public class GcRewardStatCompareAndSet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 CompareAndSetStat;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 CoreStat;
    }
}

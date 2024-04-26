namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C43DBC2D460E56A, NameHash = 0x63E76E3324C90001)]
    public class GcRewardStatCompareAndSet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 CompareAndSetStat;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 CoreStat;
    }
}

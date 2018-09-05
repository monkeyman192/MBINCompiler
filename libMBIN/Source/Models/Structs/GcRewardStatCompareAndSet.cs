namespace libMBIN.Models.Structs
{
    public class GcRewardStatCompareAndSet : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
    }
}

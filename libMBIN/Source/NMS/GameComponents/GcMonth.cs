namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7212715AB678D0C3, NameHash = 0x498BE03D1C172203)]
    public class GcMonth : NMSTemplate
    {
        // size: 0xC
        public enum MonthEnum : uint {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MonthEnum Month;
    }
}

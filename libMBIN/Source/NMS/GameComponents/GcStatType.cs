namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6D7101DE9D4929B, NameHash = 0xC9590B318F3C4D2)]
    public class GcStatType : NMSTemplate
    {
        // size: 0x3
        public enum StatTypeEnum : uint {
            Int,
            Float,
            AvgRate,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public StatTypeEnum StatType;
    }
}

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x42A415F679C0191E, NameHash = 0x2412AB95A81851E8)]
    public class TkBlackboardComparisonTypeEnum : NMSTemplate
    {
        // size: 0x6
        public enum ComparisonTypeEnum : uint {
            Equal,
            NotEqual,
            GreaterThan,
            GreaterThanEqual,
            LessThan,
            LessThanEqual,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ComparisonTypeEnum ComparisonType;
    }
}

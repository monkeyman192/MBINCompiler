namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BE6A0FD938188A4, NameHash = 0x77128F31CC435E5F)]
    public class GcWonderCategoryConfig : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A LocID;
        /* 0x20 */ public NMSString0x10 StatID;
        /* 0x30 */ public float ThresholdValue;
        // size: 0x2
        public enum WonderCategoryComparisonTypeEnum : uint {
            Max,
            Min,
        }
        /* 0x34 */ public WonderCategoryComparisonTypeEnum WonderCategoryComparisonType;
    }
}

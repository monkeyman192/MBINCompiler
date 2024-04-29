namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77B7B12B676BBA5E, NameHash = 0x77128F31CC435E5F)]
    public class GcWonderCategoryConfig : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A LocID;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x10 StatID;
        [NMS(Index = 1)]
        /* 0x30 */ public float ThresholdValue;
        // size: 0x2
        public enum WonderCategoryComparisonTypeEnum : uint {
            Max,
            Min,
        }
        [NMS(Index = 0)]
        /* 0x34 */ public WonderCategoryComparisonTypeEnum WonderCategoryComparisonType;
    }
}

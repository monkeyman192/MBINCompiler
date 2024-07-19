namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45E28131CA26A14B, NameHash = 0x1117CF1B)]
    public class GcItemShopAvailabilityDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum ItemShopAvailabilityDifficultyEnum : uint {
            High,
            Normal,
            Low,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ItemShopAvailabilityDifficultyEnum ItemShopAvailabilityDifficulty;
    }
}

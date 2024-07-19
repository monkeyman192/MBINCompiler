using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA8F7893A5F14422, NameHash = 0xFE1496F6)]
    public class GcTradingClassTable : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(GcTradeCategory.TradeCategoryEnum))]
        /* 0x000 */ public GcTradingCategoryData[] CategoryData;
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x360 */ public GcTradingClassData[] TradingClassesData;
        [NMS(Index = 2)]
        /* 0x4E8 */ public float MaxTradingMultiplier;
        [NMS(Index = 3)]
        /* 0x4EC */ public float MinTradingMultiplier;
    }
}

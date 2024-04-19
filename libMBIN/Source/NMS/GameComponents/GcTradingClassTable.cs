using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACCC9ED09D872CB0, NameHash = 0x8CBF7A7EE4372A7F)]
    public class GcTradingClassTable : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcTradeCategory.TradeCategoryEnum))]
        /* 0x000 */ public GcTradingCategoryData[] CategoryData;
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x72C */ public GcTradingClassData[] TradingClassesData;
        /* 0xBA8 */ public float MaxTradingMultiplier;
        /* 0xBAC */ public float MinTradingMultiplier;
    }
}

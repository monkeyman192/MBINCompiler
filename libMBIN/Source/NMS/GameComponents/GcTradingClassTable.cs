using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD31332AA0EB8E00F, NameHash = 0x8CBF7A7EE4372A7F)]
    public class GcTradingClassTable : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x000 */ public GcTradingClassData[] TradingClassesData;
        [NMS(Size = 0x9, EnumType = typeof(GcTradeCategory.TradeCategoryEnum))]
        /* 0x444 */ public GcTradingCategoryData[] CategoryData;
        /* 0xB70 */ public float MaxTradingMultiplier;
        /* 0xB74 */ public float MinTradingMultiplier;
    }
}
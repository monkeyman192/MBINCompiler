using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4BF71BB18072DE17, NameHash = 0x8CBF7A7EE4372A7F)]
    public class GcTradingClassTable : NMSTemplate      // size: 0xAAC
    {
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x000 */ public GcTradingClassData[] TradingClassesData;
        [NMS(Size = 0x8, EnumType = typeof(GcTradeCategory.TradingClassEnum))]
        /* 0x444 */ public GcTradingCategoryData[] CategoryData;
        /* 0xAA4 */ public float MaxTradingMultiplier;
        /* 0xAA8 */ public float MinTradingMultiplier;
    }
}

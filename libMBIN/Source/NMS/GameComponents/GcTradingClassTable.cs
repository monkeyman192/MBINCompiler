using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4BF71BB18072DE17)]
    public class GcTradingClassTable : NMSTemplate      // size: 0xAAC
    {
        [NMS( EnumType = typeof( GcTradingClass.TradingClassEnum ) )]
        /* 0x000 */ public GcTradingClassData[] TradingClassesData;
        [NMS( EnumType = typeof( GcTradeCategory.TradingClassEnum ) )]
        /* 0x444 */ public GcTradingCategoryData[] CategoryData;
        /* 0xAA4 */ public float MaxTradingMultiplier;
        /* 0xAA8 */ public float MinTradingMultiplier;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC57DDD51E7AC678, NameHash = 0xDB0B133A)]
    public class GcTradingClassData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 5)]
        /* 0x18 */ public float MaxBuyingPriceMultiplier;
        [NMS(Index = 7)]
        /* 0x1C */ public float MaxBuyingPriceMultiplierSurge;
        [NMS(Index = 3)]
        /* 0x20 */ public float MaxSellingPriceMultiplier;
        [NMS(Index = 4)]
        /* 0x24 */ public float MinBuyingPriceMultiplier;
        [NMS(Index = 6)]
        /* 0x28 */ public float MinBuyingPriceMultiplierSurge;
        [NMS(Index = 2)]
        /* 0x2C */ public float MinSellingPriceMultiplier;
        [NMS(Index = 1)]
        /* 0x30 */ public GcTradeCategory Needs;
        [NMS(Index = 0)]
        /* 0x34 */ public GcTradeCategory Sells;
    }
}

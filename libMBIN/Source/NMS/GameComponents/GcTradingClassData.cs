using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1CCDBE645854309, NameHash = 0xB0C75D0F1E252081)]
    public class GcTradingClassData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 5)]
        /* 0x84 */ public float MaxBuyingPriceMultiplier;
        [NMS(Index = 7)]
        /* 0x88 */ public float MaxBuyingPriceMultiplierSurge;
        [NMS(Index = 3)]
        /* 0x8C */ public float MaxSellingPriceMultiplier;
        [NMS(Index = 4)]
        /* 0x90 */ public float MinBuyingPriceMultiplier;
        [NMS(Index = 6)]
        /* 0x94 */ public float MinBuyingPriceMultiplierSurge;
        [NMS(Index = 2)]
        /* 0x98 */ public float MinSellingPriceMultiplier;
        [NMS(Index = 1)]
        /* 0x9C */ public GcTradeCategory Needs;
        [NMS(Index = 0)]
        /* 0xA0 */ public GcTradeCategory Sells;
    }
}

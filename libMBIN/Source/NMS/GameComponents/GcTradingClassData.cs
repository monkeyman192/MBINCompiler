using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32EFC0B76CA1A467, NameHash = 0xB0C75D0F1E252081)]
    public class GcTradingClassData : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource Icon;
        /* 0x84 */ public float MaxBuyingPriceMultiplier;
        /* 0x88 */ public float MaxBuyingPriceMultiplierSurge;
        /* 0x8C */ public float MaxSellingPriceMultiplier;
        /* 0x90 */ public float MinBuyingPriceMultiplier;
        /* 0x94 */ public float MinBuyingPriceMultiplierSurge;
        /* 0x98 */ public float MinSellingPriceMultiplier;
        /* 0x9C */ public GcTradeCategory Needs;
        /* 0xA0 */ public GcTradeCategory Sells;
    }
}

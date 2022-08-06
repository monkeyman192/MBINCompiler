using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4690413FF8678285, NameHash = 0xB0C75D0F1E252081)]
    public class GcTradingClassData : NMSTemplate
    {
        /* 0x00 */ public GcTradeCategory Sells;
        /* 0x04 */ public GcTradeCategory Needs;
        /* 0x08 */ public float MinSellingPriceMultiplier;
        /* 0x0C */ public float MaxSellingPriceMultiplier;
        /* 0x10 */ public float MinBuyingPriceMultiplier;
        /* 0x14 */ public float MaxBuyingPriceMultiplier;
        /* 0x18 */ public TkTextureResource Icon;
    }
}

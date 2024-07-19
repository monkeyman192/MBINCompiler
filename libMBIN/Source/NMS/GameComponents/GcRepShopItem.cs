using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x389975D856FBF60E, NameHash = 0x337A26E5)]
    public class GcRepShopItem : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<NMSString0x10> AltIDs;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ProductID;
        [NMS(Index = 1)]
        /* 0x20 */ public int AmountForSale;
        [NMS(Index = 3)]
        /* 0x24 */ public GcCurrency Currency;
        [NMS(Index = 2)]
        /* 0x28 */ public float PriceMul;
        [NMS(Index = 4)]
        /* 0x2C */ public int RepLevelRequired;
    }
}

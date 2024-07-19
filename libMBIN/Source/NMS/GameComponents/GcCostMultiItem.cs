using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B3515CE6B922410, NameHash = 0xE608696D)]
    public class GcCostMultiItem : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A DisplayLocID;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcItemAmountCostPair> ItemList;
        [NMS(Index = 1)]
        /* 0x30 */ public bool OnlyTakeIfCanAfford;
    }
}

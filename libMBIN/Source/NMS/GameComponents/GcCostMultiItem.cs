using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20AFBE2273197FD8, NameHash = 0x8753450A435B1BC5)]
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

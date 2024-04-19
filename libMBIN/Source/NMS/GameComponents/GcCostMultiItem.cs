using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20AFBE2273197FD8, NameHash = 0x8753450A435B1BC5)]
    public class GcCostMultiItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A DisplayLocID;
        /* 0x20 */ public List<GcItemAmountCostPair> ItemList;
        /* 0x30 */ public bool OnlyTakeIfCanAfford;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40E4B2CFB2236E44, NameHash = 0x8753450A435B1BC5)]
    public class GcCostMultiItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A DisplayLocID;
        /* 0x20 */ public bool OnlyTakeIfCanAfford;
        /* 0x28 */ public List<GcItemAmountCostPair> ItemList;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85D416C56F233361, NameHash = 0x320CEBDAD440CF79)]
    public class GcItemAmountCostPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ItemId;
        /* 0x10 */ public int Amount;
    }
}

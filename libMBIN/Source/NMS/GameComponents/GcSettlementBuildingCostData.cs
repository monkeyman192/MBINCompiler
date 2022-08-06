using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8385AE8C29B67B0, NameHash = 0x1746DC1EE79AD525)]
    public class GcSettlementBuildingCostData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Products;
        /* 0x10 */ public List<NMSString0x10> Substances;
        /* 0x20 */ public int AmountMin;
        /* 0x24 */ public int AmountMax;
        /* 0x28 */ public GcCurrency Currency;
    }
}

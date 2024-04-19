using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4313B57BEE95EF8, NameHash = 0x1746DC1EE79AD525)]
    public class GcSettlementBuildingCostData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Products;
        /* 0x10 */ public List<NMSString0x10> Substances;
        /* 0x20 */ public int AmountMax;
        /* 0x24 */ public int AmountMin;
        /* 0x28 */ public GcCurrency Currency;
    }
}

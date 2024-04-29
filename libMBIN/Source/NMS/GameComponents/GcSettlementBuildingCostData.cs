using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FEFC5240FC40145, NameHash = 0x1746DC1EE79AD525)]
    public class GcSettlementBuildingCostData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> Products;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x10> Substances;
        [NMS(Index = 3)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x24 */ public int AmountMin;
        [NMS(Index = 4)]
        /* 0x28 */ public GcCurrency Currency;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45C9CD270AA0B0A9, NameHash = 0x6476A035)]
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

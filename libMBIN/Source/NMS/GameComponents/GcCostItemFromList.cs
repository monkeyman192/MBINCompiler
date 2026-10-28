using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x17A7A4AE0A97D0D8, NameHash = 0x458EED45)]
    public class GcCostItemFromList : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 1)]
        /* 0x20 */ public List<NMSString0x10> ItemList;
        [NMS(Index = 0)]
        /* 0x30 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x34 */ public int Index;
    }
}

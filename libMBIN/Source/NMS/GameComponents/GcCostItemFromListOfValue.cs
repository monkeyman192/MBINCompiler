using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x637D77EC9C82F0E8, NameHash = 0x20D1A01C0454CD5B)]
    public class GcCostItemFromListOfValue : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A CostText;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x10> ItemList;
        [NMS(Index = 0)]
        /* 0x30 */ public int UnitValue;
        [NMS(Index = 1)]
        /* 0x34 */ public bool UseDefaultAmount;
    }
}

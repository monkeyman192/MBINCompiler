using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1487B0C218DF575, NameHash = 0xB71EC41B)]
    public class GcSeasonTransferInventoryConfig : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcInventoryLayout Layout;
        [NMS(Index = 2)]
        /* 0x18 */ public List<NMSString0x10> SlotItemFilterIDs;
        [NMS(Index = 0)]
        /* 0x28 */ public int Width;
    }
}

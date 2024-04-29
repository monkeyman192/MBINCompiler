using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4875CD4636367FC, NameHash = 0xE431AE3102063AE2)]
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

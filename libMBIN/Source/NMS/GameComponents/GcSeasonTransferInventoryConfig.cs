using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD47555CB038B9503, NameHash = 0xE431AE3102063AE2)]
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

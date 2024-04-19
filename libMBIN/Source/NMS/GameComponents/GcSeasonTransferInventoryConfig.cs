using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD47555CB038B9503, NameHash = 0xE431AE3102063AE2)]
    public class GcSeasonTransferInventoryConfig : NMSTemplate
    {
        /* 0x00 */ public GcInventoryLayout Layout;
        /* 0x18 */ public List<NMSString0x10> SlotItemFilterIDs;
        /* 0x28 */ public int Width;
    }
}

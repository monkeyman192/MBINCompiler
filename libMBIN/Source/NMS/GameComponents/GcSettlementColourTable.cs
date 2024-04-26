using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8AE561762286A39, NameHash = 0x4EF075AF93525886)]
    public class GcSettlementColourTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> DecorationPartIds;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcSettlementColourPalette> SettlementColourPalettes;
    }
}

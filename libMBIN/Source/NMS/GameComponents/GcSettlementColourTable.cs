using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D108199BE3FC8CD, NameHash = 0x36708BC9)]
    public class GcSettlementColourTable : NMSTemplate
    {
        [NMS(Index = 1, MxmlName = "Decoration Part Ids")]
        /* 0x00 */ public List<NMSString0x10> DecorationPartIds;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcSettlementColourPalette> SettlementColourPalettes;
    }
}

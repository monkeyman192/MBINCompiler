using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41E05A809276EF2B, NameHash = 0xC588030)]
    public class GcActionSetHudLayer : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> HudLayerIDs;
        [NMS(Index = 0)]
        /* 0x10 */ public GcActionSetType Type;
    }
}

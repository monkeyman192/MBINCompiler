using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE186C5BF0BA084CF, NameHash = 0xC8ABA2A9ED6C9748)]
    public class GcActionSetHudLayer : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> HudLayerIDs;
        [NMS(Index = 0)]
        /* 0x10 */ public GcActionSetType Type;
    }
}

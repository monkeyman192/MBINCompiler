using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AFE7D3C948876BA, NameHash = 0xC8ABA2A9ED6C9748)]
    public class GcActionSetHudLayer : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> HudLayerIDs;
        /* 0x10 */ public GcActionSetType Type;
    }
}

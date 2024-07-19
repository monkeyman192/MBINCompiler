using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD548E17C6A11040D, NameHash = 0x94B217E8)]
    public class GcActionSetsHudLayers : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcActionSetHudLayer> ActionSetHudLayers;
    }
}

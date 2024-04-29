using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97B2801698B0B455, NameHash = 0x8F95942200CB4111)]
    public class GcActionSetsHudLayers : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcActionSetHudLayer> ActionSetHudLayers;
    }
}

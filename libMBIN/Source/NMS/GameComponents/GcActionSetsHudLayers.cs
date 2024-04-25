using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x319A6300F2FDB6E, NameHash = 0x8F95942200CB4111)]
    public class GcActionSetsHudLayers : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcActionSetHudLayer> ActionSetHudLayers;
    }
}

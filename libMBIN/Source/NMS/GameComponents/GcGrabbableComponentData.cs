using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x173EF56E8149E126, NameHash = 0x82286E866B7201D0)]
    public class GcGrabbableComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGrabbableData> GrabbableDataArray;
    }
}

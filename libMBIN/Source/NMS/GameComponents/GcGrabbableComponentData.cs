using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x421C81B82553C54F, NameHash = 0x433F1524)]
    public class GcGrabbableComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGrabbableData> GrabbableDataArray;
    }
}

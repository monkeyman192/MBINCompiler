using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5A948FC9164198A, NameHash = 0xFC177E43)]
    public class GcBaseBuildingPartsDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPartData> PartsData;
    }
}

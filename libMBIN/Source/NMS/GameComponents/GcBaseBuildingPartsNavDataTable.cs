using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3A1BE9387392976, NameHash = 0xD12E966E50238278)]
    public class GcBaseBuildingPartsNavDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPartNavData> Parts;
    }
}

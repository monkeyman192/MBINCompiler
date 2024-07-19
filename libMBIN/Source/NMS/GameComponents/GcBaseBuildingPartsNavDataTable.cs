using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4B44F74BC1F697E, NameHash = 0x2DC080D1)]
    public class GcBaseBuildingPartsNavDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPartNavData> Parts;
    }
}

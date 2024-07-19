using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAFCD6190D8A0ED, NameHash = 0x8CD79C1E)]
    public class GcPurchaseableBuildingBlueprints : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<int> GroupMaxItems;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcBuildingBlueprint> Table;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37B7E55978E55097, NameHash = 0x7DB6471B493F5A78)]
    public class GcPurchaseableBuildingBlueprints : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<int> GroupMaxItems;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcBuildingBlueprint> Table;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x731C1382219CB189, NameHash = 0xFCDCA49CE9A8AAE7)]
    public class GcMissionConditionPlanetHasBuilding : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcBuildingClassification> AdditionalBuildings;
        [NMS(Index = 0)]
        /* 0x10 */ public GcBuildingClassification Building;
    }
}

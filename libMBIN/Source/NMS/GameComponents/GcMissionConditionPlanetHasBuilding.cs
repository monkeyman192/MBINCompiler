using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4685F311FCBC3893, NameHash = 0xA0CE729B)]
    public class GcMissionConditionPlanetHasBuilding : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcBuildingClassification> AdditionalBuildings;
        [NMS(Index = 0)]
        /* 0x10 */ public GcBuildingClassification Building;
    }
}

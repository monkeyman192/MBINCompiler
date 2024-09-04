using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CA0DE5A869C7EE4, NameHash = 0xE0DDA29E)]
    public class GcMissionConditionNearestBuilding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcBuildingClassification> AdditionalBuildings;
        [NMS(Index = 0)]
        /* 0x10 */ public GcBuildingClassification Building;
        [NMS(Index = 1)]
        /* 0x14 */ public float Distance;
        [NMS(Index = 3)]
        /* 0x18 */ public GcInteractionType RequireIncompleteInteraction;
    }
}

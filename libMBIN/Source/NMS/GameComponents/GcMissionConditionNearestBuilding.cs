using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87A10B3C360256FC, NameHash = 0xE0DDA29E)]
    public class GcMissionConditionNearestBuilding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcBuildingClassification> AdditionalBuildings;
        [NMS(Index = 1)]
        /* 0x10 */ public float Distance;
        [NMS(Index = 3)]
        /* 0x14 */ public GcInteractionType RequireIncompleteInteraction;
        [NMS(Index = 0)]
        /* 0x18 */ public GcBuildingClassification Building;
    }
}

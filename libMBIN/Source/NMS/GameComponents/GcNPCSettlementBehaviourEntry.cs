using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD4C948E0F5A7EF0, NameHash = 0xB268E74AC135A1A5)]
    public class GcNPCSettlementBehaviourEntry : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcNPCSettlementBehaviourAreaPropertyWeightEntry> AreaPropertyWeights;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcNPCSettlementBehaviourBuildingClassCapacityEntry> BuildingClassCapacities;
        [NMS(Index = 4)]
        /* 0x20 */ public List<GcNPCSettlementBehaviourBuildingClassWeightEntry> BuildingClassWeights;
        [NMS(Index = 5)]
        /* 0x30 */ public List<GcNPCSettlementBehaviourObjectTypeWeightEntry> ObjectTypeWeights;
        [NMS(Index = 0)]
        /* 0x40 */ public float RunWhenOutdoorsProbability;
        [NMS(Index = 1)]
        /* 0x44 */ public bool OnlyUseIndoorPOIs;
    }
}

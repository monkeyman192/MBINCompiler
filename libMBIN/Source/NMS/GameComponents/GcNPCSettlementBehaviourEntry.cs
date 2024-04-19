using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63A8F155127B8DA6, NameHash = 0xB268E74AC135A1A5)]
    public class GcNPCSettlementBehaviourEntry : NMSTemplate
    {
        /* 0x00 */ public List<GcNPCSettlementBehaviourAreaPropertyWeightEntry> AreaPropertyWeights;
        /* 0x10 */ public List<GcNPCSettlementBehaviourBuildingClassCapacityEntry> BuildingClassCapacities;
        /* 0x20 */ public List<GcNPCSettlementBehaviourBuildingClassWeightEntry> BuildingClassWeights;
        /* 0x30 */ public List<GcNPCSettlementBehaviourObjectTypeWeightEntry> ObjectTypeWeights;
        /* 0x40 */ public float RunWhenOutdoorsProbability;
        /* 0x44 */ public bool OnlyUseIndoorPOIs;
    }
}

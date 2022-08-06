using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A735D64B5D4C86F, NameHash = 0xB268E74AC135A1A5)]
    public class GcNPCSettlementBehaviourEntry : NMSTemplate
    {
        /* 0x00 */ public float RunWhenOutdoorsProbability;
        /* 0x04 */ public bool OnlyUseIndoorPOIs;
        /* 0x08 */ public List<GcNPCSettlementBehaviourBuildingClassCapacityEntry> BuildingClassCapacities;
        /* 0x18 */ public List<GcNPCSettlementBehaviourAreaPropertyWeightEntry> AreaPropertyWeights;
        /* 0x28 */ public List<GcNPCSettlementBehaviourBuildingClassWeightEntry> BuildingClassWeights;
        /* 0x38 */ public List<GcNPCSettlementBehaviourObjectTypeWeightEntry> ObjectTypeWeights;
    }
}

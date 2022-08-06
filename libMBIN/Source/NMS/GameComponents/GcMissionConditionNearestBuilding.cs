using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3686EFA1015060D, NameHash = 0x116C1EDD24B089D5)]
    public class GcMissionConditionNearestBuilding : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification Building;
        /* 0x4 */ public float Distance;
        /* 0x8 */ public List<GcBuildingClassification> AdditionalBuildings;
    }
}

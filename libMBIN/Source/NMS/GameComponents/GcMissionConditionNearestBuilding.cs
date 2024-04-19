using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5ED0E27CAF188CEA, NameHash = 0x116C1EDD24B089D5)]
    public class GcMissionConditionNearestBuilding : NMSTemplate
    {
        /* 0x00 */ public List<GcBuildingClassification> AdditionalBuildings;
        /* 0x10 */ public GcBuildingClassification Building;
        /* 0x14 */ public float Distance;
    }
}

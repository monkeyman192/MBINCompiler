using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF977893C581A9F6A, NameHash = 0xD9D7367B)]
    public class GcMissionConditionHasSettlementBuilding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcInventoryClass MinimumClass;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AnyBuildingClass;
        [NMS(Index = 0)]
        /* 0x5 */ public GcBuildingClassification BuildingClass;
        [NMS(Index = 3)]
        /* 0x6 */ public bool RequireComplete;
    }
}

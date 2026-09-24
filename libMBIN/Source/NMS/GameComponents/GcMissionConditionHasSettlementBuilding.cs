using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B6D9252B25E5EA7, NameHash = 0xD9D7367B)]
    public class GcMissionConditionHasSettlementBuilding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcInventoryClass MinimumClass;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AnyBuildingClass;
        [NMS(Index = 0)]
        /* 0x5 */ public GcBuildingClassification BuildingClass;
        [NMS(Index = 4)]
        /* 0x6 */ public bool CheckAllSettlements;
        [NMS(Index = 3)]
        /* 0x7 */ public bool RequireComplete;
    }
}

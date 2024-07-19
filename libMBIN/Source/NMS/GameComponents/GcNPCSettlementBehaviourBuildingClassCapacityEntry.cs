using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B7C16F30EB51E26, NameHash = 0xB1E003D1)]
    public class GcNPCSettlementBehaviourBuildingClassCapacityEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        [NMS(Index = 1)]
        /* 0x4 */ public int Capacity;
    }
}

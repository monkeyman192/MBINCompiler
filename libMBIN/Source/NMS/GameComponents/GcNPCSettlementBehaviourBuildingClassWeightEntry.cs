using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x107A3DDC0D87C2D3, NameHash = 0xC563E51748C26DEE)]
    public class GcNPCSettlementBehaviourBuildingClassWeightEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        [NMS(Index = 1)]
        /* 0x4 */ public float EntryWeight;
        [NMS(Index = 2)]
        /* 0x8 */ public float ExitWeight;
    }
}

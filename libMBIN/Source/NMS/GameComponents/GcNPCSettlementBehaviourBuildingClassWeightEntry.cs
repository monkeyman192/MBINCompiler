using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32ADA7E5BAA20DC5, NameHash = 0xA3D4C382)]
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

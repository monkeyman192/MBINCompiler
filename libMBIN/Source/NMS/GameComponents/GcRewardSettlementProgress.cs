using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9807233585E1F685, NameHash = 0x87616D37E129954C)]
    public class GcRewardSettlementProgress : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcBuildingClassification BuildingType;
        [NMS(Index = 0)]
        /* 0x4 */ public bool UseInteractionBuildingType;
    }
}

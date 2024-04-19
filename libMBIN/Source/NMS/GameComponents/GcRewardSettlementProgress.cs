using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x899C5093160A6CED, NameHash = 0x87616D37E129954C)]
    public class GcRewardSettlementProgress : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification BuildingType;
        /* 0x4 */ public bool UseInteractionBuildingType;
    }
}

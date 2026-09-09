using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA388005D3137AAC, NameHash = 0xBFA2B54B)]
    public class GcMissionConditionHasProcProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcProceduralProductCategory ProcProduct;
        [NMS(Index = 1)]
        /* 0x4 */ public GcModularCustomisationResourceType SpecificFossilType;
        [NMS(Index = 2)]
        /* 0x8 */ public bool ForceSearchFreighterAndChests;
        [NMS(Index = 3)]
        /* 0x9 */ public bool SearchEveryShip;
    }
}

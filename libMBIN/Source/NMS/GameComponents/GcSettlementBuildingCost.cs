using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD42AD084C0F69075, NameHash = 0x22A3B9FA5D01C4DD)]
    public class GcSettlementBuildingCost : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcSettlementConstructionLevel.SettlementConstructionLevelEnum))]
        /* 0x0 */ public GcSettlementBuildingCostData[] StageCosts;
    }
}

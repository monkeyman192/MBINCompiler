using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DE1800479BADEE8, NameHash = 0xBFA2B54B)]
    public class GcMissionConditionHasProcProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcProceduralProductCategory ProcProduct;
        [NMS(Index = 1)]
        /* 0x4 */ public bool ForceSearchFreighterAndChests;
        [NMS(Index = 2)]
        /* 0x5 */ public bool SearchEveryShip;
    }
}

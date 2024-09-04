using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8D24D9495C6A563, NameHash = 0xBFA2B54B)]
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

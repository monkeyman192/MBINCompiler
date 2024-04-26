using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x748CFB4E68C05944, NameHash = 0x754263974A1E2442)]
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

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC60C40B229BE2E8, NameHash = 0xD0AB76328A1D707)]
    public class GcSettlementCustomJudgement : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcSettlementJudgementData Data;
        [NMS(Index = 2)]
        /* 0x200 */ public NMSString0x20A CustomCostText;
        [NMS(Index = 0)]
        /* 0x220 */ public NMSString0x10 ID;
    }
}

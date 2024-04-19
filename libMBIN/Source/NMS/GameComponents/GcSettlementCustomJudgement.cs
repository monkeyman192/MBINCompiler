using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC60C40B229BE2E8, NameHash = 0xD0AB76328A1D707)]
    public class GcSettlementCustomJudgement : NMSTemplate
    {
        /* 0x000 */ public GcSettlementJudgementData Data;
        /* 0x200 */ public NMSString0x20A CustomCostText;
        /* 0x220 */ public NMSString0x10 ID;
    }
}

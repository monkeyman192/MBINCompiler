using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA1C08BC1688EA29, NameHash = 0xDE31ED3D)]
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

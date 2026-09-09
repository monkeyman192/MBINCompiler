namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E3CD930D8EC1E40, NameHash = 0x60619BEE)]
    public class GcRewardSettlementCustomJudgement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CustomJudgement;
        [NMS(Index = 3)]
        /* 0x10 */ public bool AwardToClosestSettlement;
        [NMS(Index = 2)]
        /* 0x11 */ public bool CanOverrideNonCustomJudgement;
        [NMS(Index = 1)]
        /* 0x12 */ public bool DisplaySettlementJudgementAlert;
    }
}

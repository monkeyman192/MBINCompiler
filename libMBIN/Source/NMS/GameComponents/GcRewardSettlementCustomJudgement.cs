namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3051642C59D1CC63, NameHash = 0x93BCED5E009EBA47)]
    public class GcRewardSettlementCustomJudgement : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CustomJudgement;
        /* 0x10 */ public bool CanOverrideNonCustomJudgement;
        /* 0x11 */ public bool Silent;
    }
}

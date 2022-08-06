using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA42786487036AD06, NameHash = 0x35FB9E28116A4F2A)]
    public class GcMissionSequenceCompleteSettlementJudgement : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x000 */ public GcJudgementMessageOptions[] MessageOptions;
        /* 0xA80 */ public GcJudgementMessageOptions MessageNoOffice;
        /* 0xC00 */ public NMSString0x80 DebugText;
    }
}

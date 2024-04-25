using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC55DBADBB2207F2, NameHash = 0x35FB9E28116A4F2A)]
    public class GcMissionSequenceCompleteSettlementJudgement : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x000 */ public GcJudgementMessageOptions[] MessageOptions;
        [NMS(Index = 1)]
        /* 0xA80 */ public GcJudgementMessageOptions MessageNoOffice;
        [NMS(Index = 2)]
        /* 0xC00 */ public NMSString0x80 DebugText;
    }
}

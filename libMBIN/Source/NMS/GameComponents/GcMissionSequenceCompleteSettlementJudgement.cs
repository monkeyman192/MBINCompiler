using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x898640C1D1FF6958, NameHash = 0xE6CB9CDC)]
    public class GcMissionSequenceCompleteSettlementJudgement : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public VariableSizeString DebugText;
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x010 */ public GcJudgementMessageOptions[] MessageOptions;
        [NMS(Index = 1)]
        /* 0xA90 */ public GcJudgementMessageOptions MessageNoOffice;
    }
}

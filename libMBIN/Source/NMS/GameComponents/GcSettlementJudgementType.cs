using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7ACDF43EC7B82ED, NameHash = 0x9B6A014776B1F8BB)]
    public class GcSettlementJudgementType : NMSTemplate
    {
        // size: 0x7
        public enum SettlementJudgementTypeEnum { None, StrangerVisit, Policy, NewBuilding, BuildingChoice, Conflict, Request }
        public SettlementJudgementTypeEnum SettlementJudgementType;
    }
}

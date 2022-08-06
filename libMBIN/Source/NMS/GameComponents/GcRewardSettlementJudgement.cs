using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2508D343B194F8E2, NameHash = 0x7A92D278225AF4A9)]
    public class GcRewardSettlementJudgement : NMSTemplate
    {
        /* 0x00 */ public List<GcSettlementJudgementType> JudgementTypes;
        /* 0x10 */ public bool Silent;
    }
}

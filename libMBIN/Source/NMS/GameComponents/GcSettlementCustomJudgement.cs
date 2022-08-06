using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D645CF69A39E190, NameHash = 0x0D0AB76328A1D707)]
    public class GcSettlementCustomJudgement : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public GcSettlementJudgementData Data;
        /* 0x228 */ public NMSString0x20A CustomCostText;
    }
}

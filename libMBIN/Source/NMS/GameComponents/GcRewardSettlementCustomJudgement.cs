using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA74BA2B2400FE370, NameHash = 0x93BCED5E009EBA47)]
    public class GcRewardSettlementCustomJudgement : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CustomJudgement;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public bool CanOverrideNonCustomJudgement;
    }
}

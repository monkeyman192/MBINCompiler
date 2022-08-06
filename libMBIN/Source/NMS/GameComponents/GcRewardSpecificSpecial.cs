using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E75BAD60825C82E, NameHash = 0xCF9FC45A7B70BB85)]
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A Message;
        /* 0x30 */ public bool ShowSpecialProductPopup;
        /* 0x31 */ public bool UseSpecialFormatting;
        /* 0x38 */ public NMSString0x20A MilestoneRewardOverrideText;
    }
}

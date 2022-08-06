using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11D2602587C55308, NameHash = 0x231FFA8B84C504B1)]
    public class GcRewardDisableSentinels : NMSTemplate
    {
        /* 0x00 */ public float Duration;
        /* 0x08 */ public NMSString0x20A OSDMessage;
        /* 0x28 */ public NMSString0x20A WantedBarMessage;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7074FF6A0F417CBC, NameHash = 0x25696B35BE341F6C)]
    public class GcMissionSequenceWaitForRefuel : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcStatsTypes TargetStat;
        /* 0x84 */ public int Amount;
        /* 0x88 */ public NMSString0x80 DebugText;
    }
}

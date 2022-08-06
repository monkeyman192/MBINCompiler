using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x299FCE10F82AEDC3, NameHash = 0x9FA5A1E5E026A5B3)]
    public class GcMissionSequenceGatherForRefuel : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcStatsTypes TargetStat;
        /* 0x84 */ public int Amount;
        /* 0x88 */ public NMSString0x80 DebugText;
    }
}

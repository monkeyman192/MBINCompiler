using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CBC34C7A0F6E384, NameHash = 0x535215E1DEB68BB2)]
    public class GcMissionSequenceGatherForRepair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcStatsTypes TargetStat;
        /* 0x88 */ public NMSString0x10 GatherResource;
        /* 0x98 */ public NMSString0x80 DebugText;
    }
}

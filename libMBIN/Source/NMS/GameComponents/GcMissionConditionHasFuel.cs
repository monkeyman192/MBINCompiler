using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8CC262F0C524010, NameHash = 0x2A8282CD4FA96596)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes TargetStat;
        /* 0x04 */ public int Amount;
        /* 0x08 */ public NMSString0x10 SpecificTechID;
        /* 0x18 */ public bool FormatTextAsPercentage;
    }
}

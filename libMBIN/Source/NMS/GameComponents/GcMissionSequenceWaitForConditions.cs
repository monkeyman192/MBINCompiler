using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40CA7F9FAD87E8CF, NameHash = 0x677779252EE27773)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcMissionConditionTest ConditionTest;
        /* 0x088 */ public List<NMSTemplate> Conditions;
        /* 0x098 */ public bool AllowedToFormatObjectives;
        /* 0x099 */ public bool ForceAllowMissionRestart;
        /* 0x0A0 */ public NMSString0x20A ForceAllowMissionRestartEvent;
        /* 0x0C0 */ public NMSString0x80 DebugText;
        /* 0x140 */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA4ADED1901B82DD, NameHash = 0x677779252EE27773)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A ForceAllowMissionRestartEvent;
        /* 0x020 */ public List<NMSTemplate> Conditions;
        /* 0x030 */ public GcMissionConditionTest ConditionTest;
        /* 0x034 */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
        /* 0x038 */ public NMSString0x80 DebugText;
        /* 0x0B8 */ public NMSString0x80 Message;
        /* 0x138 */ public bool AllowedToFormatObjectives;
        /* 0x139 */ public bool ForceAllowMissionRestart;
    }
}

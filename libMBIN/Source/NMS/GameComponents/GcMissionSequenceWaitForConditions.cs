using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA4ADED1901B82DD, NameHash = 0x677779252EE27773)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public NMSString0x20A ForceAllowMissionRestartEvent;
        [NMS(Index = 2)]
        /* 0x020 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 1)]
        /* 0x030 */ public GcMissionConditionTest ConditionTest;
        [NMS(Index = 7)]
        /* 0x034 */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
        [NMS(Index = 6)]
        /* 0x038 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0B8 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x138 */ public bool AllowedToFormatObjectives;
        [NMS(Index = 4)]
        /* 0x139 */ public bool ForceAllowMissionRestart;
    }
}

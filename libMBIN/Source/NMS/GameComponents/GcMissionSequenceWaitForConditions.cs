using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7097567D7A09B1B, NameHash = 0xD71A21D3)]
    public class GcMissionSequenceWaitForConditions : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A ForceAllowMissionRestartEvent;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 6)]
        /* 0x30 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x40 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x50 */ public GcMissionConditionTest ConditionTest;
        [NMS(Index = 7)]
        /* 0x54 */ public GcStatusMessageMissionMarkup StatusMessageMissionMarkup;
        [NMS(Index = 3)]
        /* 0x58 */ public bool AllowedToFormatObjectives;
        [NMS(Index = 4)]
        /* 0x59 */ public bool ForceAllowMissionRestart;
    }
}

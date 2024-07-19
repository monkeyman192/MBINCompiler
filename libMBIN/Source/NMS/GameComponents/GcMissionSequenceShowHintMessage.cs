using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1198AA159C4E66CC, NameHash = 0x8B231872)]
    public class GcMissionSequenceShowHintMessage : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 InventoryHint;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString MessageTitle;
        [NMS(Index = 7)]
        /* 0x40 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        [NMS(Index = 4)]
        /* 0x50 */ public float HighPriorityTime;
        [NMS(Index = 3)]
        /* 0x54 */ public float InitialWaitTime;
        [NMS(Index = 5)]
        /* 0x58 */ public float SecondaryWaitTime;
        [NMS(Index = 6)]
        /* 0x5C */ public bool AllowedWhileInDanger;
    }
}

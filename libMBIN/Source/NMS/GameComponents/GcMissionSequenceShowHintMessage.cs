using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x92FE105FDB7EE0FE, NameHash = 0xFCB8FED346EB142B)]
    public class GcMissionSequenceShowHintMessage : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x10 InventoryHint;
        [NMS(Index = 7)]
        /* 0x010 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        [NMS(Index = 4)]
        /* 0x020 */ public float HighPriorityTime;
        [NMS(Index = 3)]
        /* 0x024 */ public float InitialWaitTime;
        [NMS(Index = 5)]
        /* 0x028 */ public float SecondaryWaitTime;
        [NMS(Index = 8)]
        /* 0x02C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0AC */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x12C */ public NMSString0x80 MessageTitle;
        [NMS(Index = 6)]
        /* 0x1AC */ public bool AllowedWhileInDanger;
    }
}

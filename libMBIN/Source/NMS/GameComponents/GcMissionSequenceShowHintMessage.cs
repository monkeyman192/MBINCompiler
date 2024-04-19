using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x92FE105FDB7EE0FE, NameHash = 0xFCB8FED346EB142B)]
    public class GcMissionSequenceShowHintMessage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 InventoryHint;
        /* 0x010 */ public List<NMSTemplate> UseConditionsForTextFormatting;
        /* 0x020 */ public float HighPriorityTime;
        /* 0x024 */ public float InitialWaitTime;
        /* 0x028 */ public float SecondaryWaitTime;
        /* 0x02C */ public NMSString0x80 DebugText;
        /* 0x0AC */ public NMSString0x80 Message;
        /* 0x12C */ public NMSString0x80 MessageTitle;
        /* 0x1AC */ public bool AllowedWhileInDanger;
    }
}

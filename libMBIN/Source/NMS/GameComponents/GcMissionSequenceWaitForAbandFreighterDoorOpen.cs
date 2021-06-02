using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x184, GUID = 0x4DFA5FFAAFE6B182, NameHash = 0x3C3DF65980E5A451)]
    public class GcMissionSequenceWaitForAbandFreighterDoorOpen : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageOvertime;
        /* 0x100 */ public float MinTime;
        /* 0x104 */ public NMSString0x80 DebugText;
    }
}

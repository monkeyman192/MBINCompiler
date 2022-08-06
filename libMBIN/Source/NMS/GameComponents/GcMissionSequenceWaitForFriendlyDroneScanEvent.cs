using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF8910F1F6C4B052, NameHash = 0xD5B668729A28BD2C)]
    public class GcMissionSequenceWaitForFriendlyDroneScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 MessageSummoned;
        /* 0x080 */ public NMSString0x80 MessageUnsummoned;
        /* 0x100 */ public NMSString0x80 MessageCantSummon;
        /* 0x180 */ public NMSString0x80 MessageNotAvailable;
        /* 0x200 */ public NMSString0x20A Event;
        /* 0x220 */ public NMSString0x80 DebugText;
    }
}

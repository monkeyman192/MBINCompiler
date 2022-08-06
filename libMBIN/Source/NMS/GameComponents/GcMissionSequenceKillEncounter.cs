using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9B413F7556A27E7, NameHash = 0x07E1936B219E215F)]
    public class GcMissionSequenceKillEncounter : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x20A EncounterComponentScanEvent;
        /* 0xA0 */ public bool AllowedToEscape;
        /* 0xA1 */ public NMSString0x80 DebugText;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50066F3D7840BE0A, NameHash = 0x779C608FD9761375)]
    public class GcMissionSequenceWaitForFreighterPods : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public int Amount;
        /* 0x84 */ public bool TakeAmountFromPulseEncounter;
        /* 0x85 */ public NMSString0x80 DebugText;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA351A159275674B9, NameHash = 0xD14F8D38E31CAB20)]
    public class GcMissionSequenceCommunicator : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 VRMessage;
        /* 0x100 */ public NMSString0x80 OSDMessage;
        /* 0x180 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x1D0 */ public bool AutoOpen;
        /* 0x1D1 */ public NMSString0x80 DebugText;
    }
}

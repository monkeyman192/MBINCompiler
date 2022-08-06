using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75F590A081FA85DC, NameHash = 0x382AC51563627203)]
    public class GcRewardCommunicatorMessage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 VRMessage;
        /* 0x100 */ public NMSString0x80 OSDMessage;
        /* 0x180 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x1D0 */ public bool AutoOpen;
    }
}

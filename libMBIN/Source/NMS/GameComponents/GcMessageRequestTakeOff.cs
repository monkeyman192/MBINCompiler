using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB49459DA6966419D, NameHash = 0xB0AB7777BBC667DD)]
    public class GcMessageRequestTakeOff : NMSTemplate
    {
        /* 0x0 */ public float Delay;
        /* 0x4 */ public bool ImmediatelyDissolveNPC;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF14318395DCE2662, NameHash = 0x76E8D6F5EA35F60C)]
    public class GcRewardPirateAttack : NMSTemplate
    {
        /* 0x0 */ public bool Instant;
        /* 0x4 */ public int NumSquads;
        /* 0x8 */ public NMSString0x10 AttackDefinition;
    }
}

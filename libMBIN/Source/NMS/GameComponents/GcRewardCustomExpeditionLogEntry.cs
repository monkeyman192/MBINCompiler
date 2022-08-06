using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x740062672DE20E4F, NameHash = 0xF6BA3ABDC071904B)]
    public class GcRewardCustomExpeditionLogEntry : NMSTemplate
    {
        /* 0x00 */ public bool FromIntervention;
        /* 0x01 */ public bool WhaleEvent;
        /* 0x08 */ public NMSString0x20A LocID;
        /* 0x28 */ public NMSString0x10 RewardID;
    }
}

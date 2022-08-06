using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x0237CE95D2B9ED6E, NameHash = 0xE9EC3242091011CC)]
    public class GcUnlockableTwitchReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TwitchId;
        /* 0x10 */ public NMSString0x10 ProductId;
        /* 0x20 */ public NMSString0x10 LinkedGroupId;
    }
}

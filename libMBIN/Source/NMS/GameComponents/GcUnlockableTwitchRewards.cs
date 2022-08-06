using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x0DDDFB55CAB08B05, NameHash = 0xF128895FDB533FA8)]
    public class GcUnlockableTwitchRewards : NMSTemplate
    {
        /* 0x0 */ public List<GcUnlockableTwitchReward> Table;
    }
}

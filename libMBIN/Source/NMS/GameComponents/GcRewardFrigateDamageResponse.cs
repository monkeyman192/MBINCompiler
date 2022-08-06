using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA18B90B26D0E9D4, NameHash = 0xFA9A306017ED3640)]
    public class GcRewardFrigateDamageResponse : NMSTemplate
    {
        // size: 0x6
        public enum ResponseEnum { StayOut, ReturnHome, CheckForMoreDamage, ShowDamagedCaptain, ShowExpeditionCaptain,
            AbortExpedition
        }
        /* 0x0 */ public ResponseEnum Response;
    }
}

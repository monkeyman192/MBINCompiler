using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x0884EFCBB7E0881B, NameHash = 0xA8C5FB6413CFB7AA)]
    public class GcRewardRefreshHazProt : NMSTemplate
    {
        /* 0x0 */ public float Amount;
        /* 0x4 */ public bool SetNotAdd;
        /* 0x5 */ public bool Silent;
    }
}

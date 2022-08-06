using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x00049A9E7C5470A0, NameHash = 0x2B59E601DE0BDEF9)]
    public class GcRewardMoney : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public bool RoundNumber;
        /* 0xC */ public GcCurrency Currency;
    }
}

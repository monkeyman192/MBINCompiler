using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6CC2C69A75C48F9, NameHash = 0x139E6194371FE10E)]
    public class GcMissionSequenceCollectProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcDefaultMissionProductEnum Default;
        /* 0x88 */ public NMSString0x10 Product;
        /* 0x98 */ public int AmountMin;
        /* 0x9C */ public int AmountMax;
        /* 0xA0 */ public bool WaitForSelected;
        /* 0xA8 */ public NMSString0x10 ForBuild;
        /* 0xB8 */ public NMSString0x10 ForRepair;
        /* 0xC8 */ public bool TeachIfNotKnown;
        /* 0xC9 */ public bool FromNow;
        /* 0xCA */ public bool TakeAmountFromSeasonData;
        /* 0xCB */ public bool DependentOnSeasonMilestone;
        /* 0xCC */ public NMSString0x80 DebugText;
    }
}

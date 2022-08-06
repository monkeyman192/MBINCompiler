using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8E5A601DB5F5271, NameHash = 0x691B32769ECE3BC6)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        /* 0x08 */ public NMSString0x10 ID;
        /* 0x18 */ public int AmountMin;
        /* 0x1C */ public int AmountMax;
        /* 0x20 */ public bool HideAmountInMessage;
        /* 0x21 */ public bool ForceSpecialMessage;
        /* 0x22 */ public bool HideInSeasonRewards;
        /* 0x23 */ public bool Silent;
        /* 0x28 */ public NMSString0x10 SeasonRewardListFormat;
        /* 0x38 */ public NMSString0x10 RequiresTech;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, Alignment = 0x8, GUID = 0x8EDDE2BBF7866E0F, NameHash = 0x691B32769ECE3BC6)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x10 ID;
        /* 0x18 */ public int AmountMin;
        /* 0x1C */ public int AmountMax;
        /* 0x20 */ public bool ForceSpecialMessage;
        /* 0x21 */ public bool HideInSeasonRewards;
        /* 0x22 */ public bool Silent;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x23 */ public byte[] EndPadding;
    }
}

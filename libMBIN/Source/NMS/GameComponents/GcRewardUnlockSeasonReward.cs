using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x40, GUID = 0xE6212DF525ECA350, NameHash = 0x7AB9EBA17278DE9B)]
    public class GcRewardUnlockSeasonReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public bool Silent;
        /* 0x18 */ public NMSString0x20A EncryptedText;
        /* 0x38 */ public bool UseSpecialFormatting;
        /* 0x39 */ public bool MarkAsClaimedInShop;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x3A */ public byte[] EndPadding;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E26081F82CBD6E2, NameHash = 0x7AB9EBA17278DE9B)]
    public class GcRewardUnlockSeasonReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A EncryptedText;
        /* 0x20 */ public NMSString0x10 ProductID;
        /* 0x30 */ public bool MarkAsClaimedInShop;
        /* 0x31 */ public bool Silent;
        /* 0x32 */ public bool UniqueInventoryItem;
        /* 0x33 */ public bool UseSpecialFormatting;
    }
}

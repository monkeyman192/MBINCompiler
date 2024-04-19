using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9426ADEECBC83FEE, NameHash = 0x839AE0F21C2F266C)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ForItemID;
        /* 0x010 */ public int Amount;
        /* 0x014 */ public GcCurrency CollectCurrency;
        /* 0x018 */ public int ForItemQuantity;
        /* 0x01C */ public NMSString0x80 DebugText;
        /* 0x09C */ public NMSString0x80 Message;
        /* 0x11C */ public bool ApplyDifficultyScaling;
        /* 0x11D */ public bool DiscountAlreadyAcquiredForItems;
        /* 0x11E */ public bool TakeAmountFromSeasonData;
    }
}

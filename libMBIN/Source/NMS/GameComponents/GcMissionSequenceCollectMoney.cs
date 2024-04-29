using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD31951FC2603038, NameHash = 0x839AE0F21C2F266C)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x000 */ public NMSString0x10 ForItemID;
        [NMS(Index = 1)]
        /* 0x010 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x014 */ public GcCurrency CollectCurrency;
        [NMS(Index = 7)]
        /* 0x018 */ public int ForItemQuantity;
        [NMS(Index = 5)]
        /* 0x01C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x09C */ public NMSString0x80 Message;
        [NMS(Index = 4)]
        /* 0x11C */ public bool ApplyDifficultyScaling;
        [NMS(Index = 8)]
        /* 0x11D */ public bool DiscountAlreadyAcquiredForItems;
        [NMS(Index = 3)]
        /* 0x11E */ public bool TakeAmountFromSeasonData;
    }
}

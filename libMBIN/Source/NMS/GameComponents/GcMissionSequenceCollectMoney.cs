using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD666FC7FA9B24C, NameHash = 0xFD9DC6F9)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 6)]
        /* 0x10 */ public NMSString0x10 ForItemID;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x30 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x34 */ public GcCurrency CollectCurrency;
        [NMS(Index = 7)]
        /* 0x38 */ public int ForItemQuantity;
        [NMS(Index = 4)]
        /* 0x3C */ public bool ApplyDifficultyScaling;
        [NMS(Index = 8)]
        /* 0x3D */ public bool DiscountAlreadyAcquiredForItems;
        [NMS(Index = 3)]
        /* 0x3E */ public bool TakeAmountFromSeasonData;
    }
}

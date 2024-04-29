using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BD8EEC95399F66F, NameHash = 0x48A0FEC50BBF269C)]
    public class GcExpeditionEventData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A ID;
        [NMS(Index = 5)]
        /* 0x020 */ public NMSString0x10 EasySuccessReward;
        [NMS(Index = 8)]
        /* 0x030 */ public NMSString0x10 FailureReward;
        [NMS(Index = 7)]
        /* 0x040 */ public NMSString0x10 SuccessReward;
        [NMS(Index = 6)]
        /* 0x050 */ public NMSString0x10 WhaleReward;
        [NMS(Index = 15)]
        /* 0x060 */ public GcNumberedTextList DamageDescriptionList;
        [NMS(Index = 11)]
        /* 0x084 */ public GcNumberedTextList FailureDescriptionList;
        [NMS(Index = 13)]
        /* 0x0A8 */ public GcNumberedTextList GenericFailureDescriptionList;
        [NMS(Index = 14)]
        /* 0x0CC */ public GcNumberedTextList GenericFailureWhaleDescriptionList;
        [NMS(Index = 12)]
        /* 0x0F0 */ public GcNumberedTextList GenericSuccessDescriptionList;
        [NMS(Index = 18)]
        /* 0x114 */ public GcNumberedTextList SecondaryDamageDescriptionList;
        [NMS(Index = 16)]
        /* 0x138 */ public GcNumberedTextList SecondaryDescriptionList;
        [NMS(Index = 17)]
        /* 0x15C */ public GcNumberedTextList SecondaryFailureDescriptionList;
        [NMS(Index = 9)]
        /* 0x180 */ public GcNumberedTextList SuccessDescriptionList;
        [NMS(Index = 10)]
        /* 0x1A4 */ public GcNumberedTextList SuccessWhaleDescriptionList;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x1C8 */ public float[] StatContribution;
        [NMS(Index = 4)]
        /* 0x1DC */ public int AdditionalShipDifficultyIncrease;
        [NMS(Index = 2)]
        /* 0x1E0 */ public int DifficultyModifier;
        [NMS(Index = 3)]
        /* 0x1E4 */ public int DifficultyVarianceModifier;
    }
}

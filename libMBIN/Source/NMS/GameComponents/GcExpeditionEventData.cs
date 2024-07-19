using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4D6837AE4A6FEC0, NameHash = 0xAC7F78B7)]
    public class GcExpeditionEventData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A ID;
        [NMS(Index = 15)]
        /* 0x020 */ public GcNumberedTextList DamageDescriptionList;
        [NMS(Index = 11)]
        /* 0x038 */ public GcNumberedTextList FailureDescriptionList;
        [NMS(Index = 13)]
        /* 0x050 */ public GcNumberedTextList GenericFailureDescriptionList;
        [NMS(Index = 14)]
        /* 0x068 */ public GcNumberedTextList GenericFailureWhaleDescriptionList;
        [NMS(Index = 12)]
        /* 0x080 */ public GcNumberedTextList GenericSuccessDescriptionList;
        [NMS(Index = 18)]
        /* 0x098 */ public GcNumberedTextList SecondaryDamageDescriptionList;
        [NMS(Index = 16)]
        /* 0x0B0 */ public GcNumberedTextList SecondaryDescriptionList;
        [NMS(Index = 17)]
        /* 0x0C8 */ public GcNumberedTextList SecondaryFailureDescriptionList;
        [NMS(Index = 9)]
        /* 0x0E0 */ public GcNumberedTextList SuccessDescriptionList;
        [NMS(Index = 10)]
        /* 0x0F8 */ public GcNumberedTextList SuccessWhaleDescriptionList;
        [NMS(Index = 5)]
        /* 0x110 */ public NMSString0x10 EasySuccessReward;
        [NMS(Index = 8)]
        /* 0x120 */ public NMSString0x10 FailureReward;
        [NMS(Index = 7)]
        /* 0x130 */ public NMSString0x10 SuccessReward;
        [NMS(Index = 6)]
        /* 0x140 */ public NMSString0x10 WhaleReward;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x150 */ public float[] StatContribution;
        [NMS(Index = 4)]
        /* 0x164 */ public int AdditionalShipDifficultyIncrease;
        [NMS(Index = 2)]
        /* 0x168 */ public int DifficultyModifier;
        [NMS(Index = 3)]
        /* 0x16C */ public int DifficultyVarianceModifier;
    }
}

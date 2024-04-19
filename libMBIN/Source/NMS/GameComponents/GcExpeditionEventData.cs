using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x228F0F1AFB532DB0, NameHash = 0x48A0FEC50BBF269C)]
    public class GcExpeditionEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A ID;
        /* 0x020 */ public NMSString0x10 EasySuccessReward;
        /* 0x030 */ public NMSString0x10 FailureReward;
        /* 0x040 */ public NMSString0x10 SuccessReward;
        /* 0x050 */ public NMSString0x10 WhaleReward;
        /* 0x060 */ public GcNumberedTextList DamageDescriptionList;
        /* 0x084 */ public GcNumberedTextList FailureDescriptionList;
        /* 0x0A8 */ public GcNumberedTextList GenericFailureDescriptionList;
        /* 0x0CC */ public GcNumberedTextList GenericFailureWhaleDescriptionList;
        /* 0x0F0 */ public GcNumberedTextList GenericSuccessDescriptionList;
        /* 0x114 */ public GcNumberedTextList SecondaryDamageDescriptionList;
        /* 0x138 */ public GcNumberedTextList SecondaryDescriptionList;
        /* 0x15C */ public GcNumberedTextList SecondaryFailureDescriptionList;
        /* 0x180 */ public GcNumberedTextList SuccessDescriptionList;
        /* 0x1A4 */ public GcNumberedTextList SuccessWhaleDescriptionList;
        [NMS(Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x1C8 */ public float[] StatContribution;
        /* 0x1DC */ public int AdditionalShipDifficultyIncrease;
        /* 0x1E0 */ public int DifficultyModifier;
        /* 0x1E4 */ public int DifficultyVarianceModifier;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0xCCE9EB1C98DF64CE, NameHash = 0x48A0FEC50BBF269C)]
    public class GcExpeditionEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 ID;
        [NMS(Size = 0x5)]
        /* 0x020 */ public float[] StatContribution;
        /* 0x034 */ public int DifficultyModifier;
        /* 0x038 */ public int DifficultyVarianceModifier;
        /* 0x03C */ public int AdditionalShipDifficultyIncrease;
        /* 0x040 */ public NMSString0x10 EasySuccessReward;
        /* 0x050 */ public NMSString0x10 SuccessReward;
        /* 0x060 */ public NMSString0x10 FailureReward;
        /* 0x070 */ public GcNumberedTextList SuccessDescriptionList;
        /* 0x094 */ public GcNumberedTextList FailureDescriptionList;
        /* 0x0B8 */ public GcNumberedTextList GenericSuccessDescriptionList;
        /* 0x0DC */ public GcNumberedTextList GenericFailureDescriptionList;
        /* 0x100 */ public GcNumberedTextList DamageDescriptionList;
        /* 0x124 */ public GcNumberedTextList SecondaryDescriptionList;
        /* 0x148 */ public GcNumberedTextList SecondaryFailureDescriptionList;
        /* 0x16C */ public GcNumberedTextList SecondaryDamageDescriptionList;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x675D83BD10A417B6, NameHash = 0x48A0FEC50BBF269C)]
    public class GcExpeditionEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A ID;
        [NMS(Size = 0x5)]
        /* 0x020 */ public float[] StatContribution;
        /* 0x034 */ public int DifficultyModifier;
        /* 0x038 */ public int DifficultyVarianceModifier;
        /* 0x03C */ public int AdditionalShipDifficultyIncrease;
        /* 0x040 */ public NMSString0x10 EasySuccessReward;
        /* 0x050 */ public NMSString0x10 WhaleReward;
        /* 0x060 */ public NMSString0x10 SuccessReward;
        /* 0x070 */ public NMSString0x10 FailureReward;
        /* 0x080 */ public GcNumberedTextList SuccessDescriptionList;
        /* 0x0A4 */ public GcNumberedTextList SuccessWhaleDescriptionList;
        /* 0x0C8 */ public GcNumberedTextList FailureDescriptionList;
        /* 0x0EC */ public GcNumberedTextList GenericSuccessDescriptionList;
        /* 0x110 */ public GcNumberedTextList GenericFailureDescriptionList;
        /* 0x134 */ public GcNumberedTextList GenericFailureWhaleDescriptionList;
        /* 0x158 */ public GcNumberedTextList DamageDescriptionList;
        /* 0x17C */ public GcNumberedTextList SecondaryDescriptionList;
        /* 0x1A0 */ public GcNumberedTextList SecondaryFailureDescriptionList;
        /* 0x1C4 */ public GcNumberedTextList SecondaryDamageDescriptionList;
    }
}

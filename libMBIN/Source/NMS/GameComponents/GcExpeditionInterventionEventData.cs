using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD8, GUID = 0xDD4BD9ABFEFBE883, NameHash = 0x1920DA0CB7B61986)]
    public class GcExpeditionInterventionEventData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 ID;
        /* 0x20 */ public int SelectionWeight;
        /* 0x24 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x28 */ public GcNumberedTextList InteractionID;
        /* 0x4C */ public NMSString0x20 SuccessLogEntry;
        /* 0x6C */ public NMSString0x20 AvoidanceLogEntry;
        /* 0x8C */ public NMSString0x20 FailureLogEntry;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xAC */ public byte[] PaddingAC;
        /* 0xB0 */ public NMSString0x10 SuccessReward;
        /* 0xC0 */ public NMSString0x10 FailureReward;
        /* 0xD0 */ public int FailureDamageChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD4 */ public byte[] EndPadding;
    }
}

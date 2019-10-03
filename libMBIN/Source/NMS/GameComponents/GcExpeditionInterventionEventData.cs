using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD8, GUID = 0xDD4BD9ABFEFBE883, NameHash = 0x1920DA0CB7B61986)]
    public class GcExpeditionInterventionEventData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string ID;
        /* 0x20 */ public int SelectionWeight;
        /* 0x24 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x28 */ public GcNumberedTextList InteractionID;
        [NMS(Size = 0x20)]
        /* 0x4C */ public string SuccessLogEntry;
        [NMS(Size = 0x20)]
        /* 0x6C */ public string AvoidanceLogEntry;
        [NMS(Size = 0x20)]
        /* 0x8C */ public string FailureLogEntry;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xAC */ public byte[] PaddingAC;
        [NMS(Size = 0x10)]
        /* 0xB0 */ public string SuccessReward;
        [NMS(Size = 0x10)]
        /* 0xC0 */ public string FailureReward;
        /* 0xD0 */ public int FailureDamageChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD4 */ public byte[] EndPadding;
    }
}

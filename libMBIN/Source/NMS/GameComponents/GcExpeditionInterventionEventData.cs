using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4BB93E3F8F2AAAD, NameHash = 0x1920DA0CB7B61986)]
    public class GcExpeditionInterventionEventData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A ID;
        /* 0x20 */ public NMSString0x10 AvoidanceFailureReward;
        /* 0x30 */ public NMSString0x10 AvoidanceSuccessReward;
        /* 0x40 */ public NMSString0x10 FailureReward;
        /* 0x50 */ public NMSString0x10 SuccessReward;
        /* 0x60 */ public GcNumberedTextList InteractionID;
        /* 0x84 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x88 */ public int FailureDamageChance;
        /* 0x8C */ public GcMissionType MissionType;
        /* 0x90 */ public int SelectionWeight;
        /* 0x94 */ public NMSString0x20 AvoidanceFailureLogEntry;
        /* 0xB4 */ public NMSString0x20 AvoidanceSuccessLogEntry;
        /* 0xD4 */ public NMSString0x20 FailureLogEntry;
        /* 0xF4 */ public NMSString0x20 SuccessLogEntry;
    }
}

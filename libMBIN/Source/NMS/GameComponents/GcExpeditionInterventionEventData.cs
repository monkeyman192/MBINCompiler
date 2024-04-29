using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD983BCBF3D8E985, NameHash = 0x1920DA0CB7B61986)]
    public class GcExpeditionInterventionEventData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 11)]
        /* 0x20 */ public NMSString0x10 AvoidanceFailureReward;
        [NMS(Index = 10)]
        /* 0x30 */ public NMSString0x10 AvoidanceSuccessReward;
        [NMS(Index = 12)]
        /* 0x40 */ public NMSString0x10 FailureReward;
        [NMS(Index = 9)]
        /* 0x50 */ public NMSString0x10 SuccessReward;
        [NMS(Index = 4)]
        /* 0x60 */ public GcNumberedTextList InteractionID;
        [NMS(Index = 3)]
        /* 0x84 */ public GcExpeditionCategory ExpeditionCategory;
        [NMS(Index = 13)]
        /* 0x88 */ public int FailureDamageChance;
        [NMS(Index = 1)]
        /* 0x8C */ public GcMissionType MissionType;
        [NMS(Index = 2)]
        /* 0x90 */ public int SelectionWeight;
        [NMS(Index = 7)]
        /* 0x94 */ public NMSString0x20 AvoidanceFailureLogEntry;
        [NMS(Index = 6)]
        /* 0xB4 */ public NMSString0x20 AvoidanceSuccessLogEntry;
        [NMS(Index = 8)]
        /* 0xD4 */ public NMSString0x20 FailureLogEntry;
        [NMS(Index = 5)]
        /* 0xF4 */ public NMSString0x20 SuccessLogEntry;
    }
}

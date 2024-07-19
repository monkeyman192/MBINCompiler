using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC267BE8341FCF478, NameHash = 0x4AEDCD0D)]
    public class GcExpeditionInterventionEventData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A ID;
        [NMS(Index = 4)]
        /* 0x20 */ public GcNumberedTextList InteractionID;
        [NMS(Index = 11)]
        /* 0x38 */ public NMSString0x10 AvoidanceFailureReward;
        [NMS(Index = 10)]
        /* 0x48 */ public NMSString0x10 AvoidanceSuccessReward;
        [NMS(Index = 12)]
        /* 0x58 */ public NMSString0x10 FailureReward;
        [NMS(Index = 9)]
        /* 0x68 */ public NMSString0x10 SuccessReward;
        [NMS(Index = 3)]
        /* 0x78 */ public GcExpeditionCategory ExpeditionCategory;
        [NMS(Index = 13)]
        /* 0x7C */ public int FailureDamageChance;
        [NMS(Index = 1)]
        /* 0x80 */ public GcMissionType MissionType;
        [NMS(Index = 2)]
        /* 0x84 */ public int SelectionWeight;
        [NMS(Index = 7)]
        /* 0x88 */ public NMSString0x20 AvoidanceFailureLogEntry;
        [NMS(Index = 6)]
        /* 0xA8 */ public NMSString0x20 AvoidanceSuccessLogEntry;
        [NMS(Index = 8)]
        /* 0xC8 */ public NMSString0x20 FailureLogEntry;
        [NMS(Index = 5)]
        /* 0xE8 */ public NMSString0x20 SuccessLogEntry;
    }
}

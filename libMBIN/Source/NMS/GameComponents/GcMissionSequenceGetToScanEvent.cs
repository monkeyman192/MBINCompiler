using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB27FA443618997A4, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A Event;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A NexusMessage;
        [NMS(Index = 5)]
        /* 0x040 */ public float Distance;
        [NMS(Index = 7)]
        /* 0x044 */ public float Timeout;
        [NMS(Index = 10)]
        /* 0x048 */ public GcScanEventGPSHint UseGPSInText;
        [NMS(Index = 17)]
        /* 0x04C */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x0CC */ public NMSString0x80 GalaxyMapMessage;
        [NMS(Index = 2)]
        /* 0x14C */ public NMSString0x80 GalaxyMapMessageNotSpace;
        [NMS(Index = 0)]
        /* 0x1CC */ public NMSString0x80 Message;
        [NMS(Index = 15)]
        /* 0x24C */ public NMSString0x80 SurveyHint;
        [NMS(Index = 13)]
        /* 0x2CC */ public NMSString0x80 SurveyInactiveHint;
        [NMS(Index = 14)]
        /* 0x34C */ public NMSString0x80 SurveySwapHint;
        [NMS(Index = 16)]
        /* 0x3CC */ public NMSString0x80 SurveyVehicleHint;
        [NMS(Index = 9)]
        /* 0x44C */ public NMSString0x80 TimeoutOSD;
        [NMS(Index = 12)]
        /* 0x4CC */ public bool AlwaysAllowInShip;
        [NMS(Index = 11)]
        /* 0x4CD */ public bool CanFormatObjectives;
        [NMS(Index = 8)]
        /* 0x4CE */ public bool DistanceTimeout;
        [NMS(Index = 6)]
        /* 0x4CF */ public bool EndEventWhenReached;
    }
}

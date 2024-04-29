using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C69DDB261755834, NameHash = 0xCFE8C2198256BF63)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A Event;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A NexusMessage;
        [NMS(Index = 5)]
        /* 0x040 */ public float Timeout;
        [NMS(Index = 8)]
        /* 0x044 */ public GcScanEventGPSHint UseGPSInText;
        [NMS(Index = 13)]
        /* 0x048 */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x0C8 */ public NMSString0x80 GalaxyMapMessage;
        [NMS(Index = 2)]
        /* 0x148 */ public NMSString0x80 GalaxyMapMessageNotSpace;
        [NMS(Index = 0)]
        /* 0x1C8 */ public NMSString0x80 Message;
        [NMS(Index = 11)]
        /* 0x248 */ public NMSString0x80 SurveyHint;
        [NMS(Index = 9)]
        /* 0x2C8 */ public NMSString0x80 SurveyInactiveHint;
        [NMS(Index = 10)]
        /* 0x348 */ public NMSString0x80 SurveySwapHint;
        [NMS(Index = 12)]
        /* 0x3C8 */ public NMSString0x80 SurveyVehicleHint;
        [NMS(Index = 7)]
        /* 0x448 */ public NMSString0x80 TimeoutOSD;
        [NMS(Index = 6)]
        /* 0x4C8 */ public bool DistanceTimeout;
    }
}

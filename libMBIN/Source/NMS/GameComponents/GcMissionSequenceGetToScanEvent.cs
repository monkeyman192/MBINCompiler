using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FC863F1FDCDA1C5, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x20A Event;
        [NMS(Index = 4)]
        /* 0x020 */ public float Distance;
        [NMS(Index = 6)]
        /* 0x024 */ public float Timeout;
        [NMS(Index = 9)]
        /* 0x028 */ public GcScanEventGPSHint UseGPSInText;
        [NMS(Index = 16)]
        /* 0x02C */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x0AC */ public NMSString0x80 GalaxyMapMessage;
        [NMS(Index = 2)]
        /* 0x12C */ public NMSString0x80 GalaxyMapMessageNotSpace;
        [NMS(Index = 0)]
        /* 0x1AC */ public NMSString0x80 Message;
        [NMS(Index = 14)]
        /* 0x22C */ public NMSString0x80 SurveyHint;
        [NMS(Index = 12)]
        /* 0x2AC */ public NMSString0x80 SurveyInactiveHint;
        [NMS(Index = 13)]
        /* 0x32C */ public NMSString0x80 SurveySwapHint;
        [NMS(Index = 15)]
        /* 0x3AC */ public NMSString0x80 SurveyVehicleHint;
        [NMS(Index = 8)]
        /* 0x42C */ public NMSString0x80 TimeoutOSD;
        [NMS(Index = 11)]
        /* 0x4AC */ public bool AlwaysAllowInShip;
        [NMS(Index = 10)]
        /* 0x4AD */ public bool CanFormatObjectives;
        [NMS(Index = 7)]
        /* 0x4AE */ public bool DistanceTimeout;
        [NMS(Index = 5)]
        /* 0x4AF */ public bool EndEventWhenReached;
    }
}

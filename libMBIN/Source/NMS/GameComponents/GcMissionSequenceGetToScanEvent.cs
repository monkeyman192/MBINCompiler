using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FC863F1FDCDA1C5, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Event;
        /* 0x020 */ public float Distance;
        /* 0x024 */ public float Timeout;
        /* 0x028 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x02C */ public NMSString0x80 DebugText;
        /* 0x0AC */ public NMSString0x80 GalaxyMapMessage;
        /* 0x12C */ public NMSString0x80 GalaxyMapMessageNotSpace;
        /* 0x1AC */ public NMSString0x80 Message;
        /* 0x22C */ public NMSString0x80 SurveyHint;
        /* 0x2AC */ public NMSString0x80 SurveyInactiveHint;
        /* 0x32C */ public NMSString0x80 SurveySwapHint;
        /* 0x3AC */ public NMSString0x80 SurveyVehicleHint;
        /* 0x42C */ public NMSString0x80 TimeoutOSD;
        /* 0x4AC */ public bool AlwaysAllowInShip;
        /* 0x4AD */ public bool CanFormatObjectives;
        /* 0x4AE */ public bool DistanceTimeout;
        /* 0x4AF */ public bool EndEventWhenReached;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4107D399F60FB690, NameHash = 0xCFE8C2198256BF63)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Event;
        /* 0x020 */ public NMSString0x20A NexusMessage;
        /* 0x040 */ public float Timeout;
        /* 0x044 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x048 */ public NMSString0x80 DebugText;
        /* 0x0C8 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x148 */ public NMSString0x80 GalaxyMapMessageNotSpace;
        /* 0x1C8 */ public NMSString0x80 Message;
        /* 0x248 */ public NMSString0x80 SurveyHint;
        /* 0x2C8 */ public NMSString0x80 SurveyInactiveHint;
        /* 0x348 */ public NMSString0x80 SurveySwapHint;
        /* 0x3C8 */ public NMSString0x80 SurveyVehicleHint;
        /* 0x448 */ public NMSString0x80 TimeoutOSD;
        /* 0x4C8 */ public bool DistanceTimeout;
    }
}

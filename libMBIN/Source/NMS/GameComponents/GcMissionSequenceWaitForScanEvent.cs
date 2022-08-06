using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD65CB7CB67CBC85A, NameHash = 0xCFE8C2198256BF63)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x20A Event;
        /* 0x120 */ public float Timeout;
        /* 0x124 */ public bool DistanceTimeout;
        /* 0x125 */ public NMSString0x80 TimeoutOSD;
        /* 0x1A8 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x1AC */ public NMSString0x80 SurveyInactiveHint;
        /* 0x22C */ public NMSString0x80 SurveySwapHint;
        /* 0x2AC */ public NMSString0x80 SurveyHint;
        /* 0x32C */ public NMSString0x80 SurveyVehicleHint;
        /* 0x3AC */ public NMSString0x80 DebugText;
    }
}

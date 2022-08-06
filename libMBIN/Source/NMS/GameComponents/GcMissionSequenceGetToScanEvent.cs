using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x01FFBFD7AC43F95D, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x20A Event;
        /* 0x120 */ public float Distance;
        /* 0x124 */ public bool EndEventWhenReached;
        /* 0x128 */ public float Timeout;
        /* 0x12C */ public bool DistanceTimeout;
        /* 0x12D */ public NMSString0x80 TimeoutOSD;
        /* 0x1B0 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x1B4 */ public NMSString0x80 SurveyInactiveHint;
        /* 0x234 */ public NMSString0x80 SurveySwapHint;
        /* 0x2B4 */ public NMSString0x80 SurveyHint;
        /* 0x334 */ public NMSString0x80 SurveyVehicleHint;
        /* 0x3B4 */ public NMSString0x80 DebugText;
    }
}

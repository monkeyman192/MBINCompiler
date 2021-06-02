using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3B8, Alignment = 0x8, GUID = 0x6F9CCC867A54ED73, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x20 Event;
        /* 0x120 */ public float Distance;
        /* 0x124 */ public bool EndEventWhenReached;
        /* 0x128 */ public float Timeout;
        /* 0x12C */ public bool DistanceTimeout;
        /* 0x12D */ public NMSString0x80 TimeoutOSD;
        /* 0x1B0 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x1B4 */ public NMSString0x80 SurveyInactiveHint;
        /* 0x234 */ public NMSString0x80 SurveySwapHint;
        /* 0x2B4 */ public NMSString0x80 SurveyHint;
        /* 0x334 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3B4 */ public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3B0, Alignment = 0x8, GUID = 0x4DABB9A083FEE532, NameHash = 0xCFE8C2198256BF63)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x20 Event;
        /* 0x120 */ public float Timeout;
        /* 0x124 */ public bool DistanceTimeout;
        /* 0x125 */ public NMSString0x80 TimeoutOSD;
        /* 0x1A8 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x1AC */ public NMSString0x80 SurveyInactiveHint;
        /* 0x22C */ public NMSString0x80 SurveySwapHint;
        /* 0x2AC */ public NMSString0x80 SurveyHint;
        /* 0x32C */ public NMSString0x80 DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3AC */ public byte[] EndPadding;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x230, Alignment = 0x8, GUID = 0xAA1A4D33E36B5402, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string GalaxyMapMessage;
        [NMS(Size = 0x20)]
        /* 0x100 */ public string Event;
        /* 0x120 */ public float Distance;
        /* 0x124 */ public bool EndEventWhenReached;
        /* 0x128 */ public float Timeout;
        /* 0x12C */ public bool DistanceTimeout;
        [NMS(Size = 0x80)]
        /* 0x12D */ public string TimeoutOSD;
        [NMS(Size = 0x80)]
        /* 0x1AD */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}

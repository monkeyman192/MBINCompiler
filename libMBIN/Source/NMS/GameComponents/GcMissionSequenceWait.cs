using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0x871308FAE1A40A85, NameHash = 0x47C4BE1F468F66AA)]
    public class GcMissionSequenceWait : NMSTemplate
    {
        /* 0x0 */ public float Time;
        /* 0x4 */ public NMSString0x80 DebugText;
        public bool SuppressMessages;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}

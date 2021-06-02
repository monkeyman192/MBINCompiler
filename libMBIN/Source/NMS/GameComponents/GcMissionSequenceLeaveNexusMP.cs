using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x188, GUID = 0xD5ABFA48F371C2F1, NameHash = 0x210E5E8D593FFE)]
    public class GcMissionSequenceLeaveNexusMP : NMSTemplate
    {
        public NMSString0x80 Message;
        public NMSString0x80 MessageNoWarp;
        public ulong Timeout;
        public NMSString0x80 DebugText;
    }
}

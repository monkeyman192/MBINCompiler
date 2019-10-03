using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x180, GUID = 0x4C9F13ECDE3CC8F7, NameHash = 0x210E5E8D593FFE)]
    public class GcMissionSequenceLeaveNexusMP : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        [NMS(Size = 0x80)]
        public string MessageNoWarp;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}

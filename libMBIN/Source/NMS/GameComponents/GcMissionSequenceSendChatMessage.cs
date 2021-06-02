using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x77C46ACC6C1F9835, NameHash = 0xFE8960194373227E)]
    public class GcMissionSequenceSendChatMessage : NMSTemplate
    {
        public NMSString0x10 StatusMessageId;
        public NMSString0x20 CustomText;
    }
}

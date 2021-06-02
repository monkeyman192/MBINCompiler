using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xED2E57A7986885BA, NameHash = 0x64C12702D824E202)]
    public class GcRewardSendChatMessage : NMSTemplate
    {
        public NMSString0x10 StatusMessageID;
        public NMSString0x20A CustomText;
    }
}
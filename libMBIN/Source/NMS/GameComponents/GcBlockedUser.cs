using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDE740CFF10FD49AC, NameHash = 0x3317FE9999913ADE)]
    public class GcBlockedUser : NMSTemplate
    {
        public NMSString0x40 UserId;
        public NMSString0x40 Username;
        public NMSString0x20 Platform;
    }
}

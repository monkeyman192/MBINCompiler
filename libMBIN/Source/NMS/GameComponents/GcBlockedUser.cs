using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xDE740CFF10FD49AC, NameHash = 0x3317FE9999913ADE)]
    public class GcBlockedUser : NMSTemplate        // size: 0xA0
    {
        public NMSString0x40 UserId;
        public NMSString0x40 Username;
        public NMSString0x20 Platform;
    }
}

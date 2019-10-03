using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xDE740CFF10FD49AC, NameHash = 0x3317FE9999913ADE)]
    public class GcBlockedUser : NMSTemplate        // size: 0xA0
    {
        [NMS(Size = 0x40)]
        public string UserId;
        [NMS(Size = 0x40)]
        public string Username;
        [NMS(Size = 0x20)]
        public string Platform;
    }
}

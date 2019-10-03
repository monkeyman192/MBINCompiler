using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0xD6C64C2E515ADAC6, NameHash = 0x59B76FD6543E9F75)]
    public class GcDiscoveryOwner : NMSTemplate
    {

        [NMS(Size = 0x40)]
        public string LocalID;
        [NMS(Size = 0x40)]
        public string OnlineID;
        [NMS(Size = 0x40)]
        public string Username;
        [NMS(Size = 0x40)]
        public string Platform;
        public int TimeStamp;
    }
}

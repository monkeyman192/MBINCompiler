using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0xD6C64C2E515ADAC6, NameHash = 0x59B76FD6543E9F75)]
    public class GcDiscoveryOwner : NMSTemplate
    {

        public NMSString0x40 LocalID;
        public NMSString0x40 OnlineID;
        public NMSString0x40 Username;
        public NMSString0x40 Platform;
        public int TimeStamp;
    }
}

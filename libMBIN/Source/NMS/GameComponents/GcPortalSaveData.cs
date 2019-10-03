using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xA9ECFDEF35F6EEDF, NameHash = 0x1B40C15E29F0E6FF)]
    public class GcPortalSaveData : NMSTemplate
    {
        public GcSeed PortalSeed;
        public ulong LastPortalUA;      // Universal Address
    }
}

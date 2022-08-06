using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xECB96E78AAC21D87, NameHash = 0x1B40C15E29F0E6FF)]
    public class GcPortalSaveData : NMSTemplate
    {
        /* 0x00 */ public GcSeed PortalSeed;
        /* 0x10 */ public ulong LastPortalUA;      // Universal Address
        /* 0x18 */ public bool IsStoryPortal;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xAF3FFA464A170D62, NameHash = 0x49FD8C968D7B338D)]
    public class GcUniverseAddressData : NMSTemplate
    {
        /* 0x00 */ public int RealityIndex;
        /* 0x04 */ public GcGalacticAddressData GalacticAddress;
    }
}

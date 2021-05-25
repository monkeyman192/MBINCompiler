using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0x8B10056FD8A6F907, NameHash = 0x34272E24BB717FCB)]
    public class GcAtlasDiscoveryData : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x18 */ public GcDiscoveryTypes Type;
        /* 0x1C */ public int PayloadElements;
        [NMS(Size = 0x5)]
        /* 0x20 */ public ulong[] Payload;
    }
}
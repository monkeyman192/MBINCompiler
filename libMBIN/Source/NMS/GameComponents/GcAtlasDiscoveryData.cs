using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFBF07A76BA9EBED, NameHash = 0xA5E57A9A)]
    public class GcAtlasDiscoveryData : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x5)]
        /* 0x00 */ public ulong[] Payload;
        [NMS(Index = 0)]
        /* 0x28 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 2)]
        /* 0x40 */ public int PayloadElements;
        [NMS(Index = 1)]
        /* 0x44 */ public GcDiscoveryType Type;
    }
}

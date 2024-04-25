using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96A8C4489DAC50F2, NameHash = 0x34272E24BB717FCB)]
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

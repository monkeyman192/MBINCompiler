using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96A8C4489DAC50F2, NameHash = 0x34272E24BB717FCB)]
    public class GcAtlasDiscoveryData : NMSTemplate
    {
        [NMS(Size = 0x5)]
        /* 0x00 */ public ulong[] Payload;
        /* 0x28 */ public GcUniverseAddressData UniverseAddress;
        /* 0x40 */ public int PayloadElements;
        /* 0x44 */ public GcDiscoveryType Type;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x48175DF9860477A7, NameHash = 0x995CD6C5BC075C98)]
    public class GcPetData : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x18 */ public int PlanetPayloadElements;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] Padding1C;
        [NMS(Size = 0x5)]
        /* 0x20 */ public ulong[] PlanetPayload;
        /* 0x48 */ public int CreaturePayloadElements;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4C */ public byte[] Padding4C;
        [NMS(Size = 0x5)]
        /* 0x50 */ public ulong[] CreaturePayload;
        /* 0x78 */ public float Scale;
        /* 0x7C */ public bool Baby;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x7D */ public byte[] EndPadding;
    }
}
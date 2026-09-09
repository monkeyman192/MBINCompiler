using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x688E41FD04E920E8, NameHash = 0x3F6D7E5B)]
    public class GcAtlasMessage : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 0)]
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 3)]
        /* 0x28 */ public int ColourIndex;
        [NMS(Index = 1)]
        /* 0x2C */ public NMSString0x80 CustomName;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x783F3BD0EB63F36B, NameHash = 0x81E5018BD0B4C94D)]
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

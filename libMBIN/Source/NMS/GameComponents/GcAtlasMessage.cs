using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C61E84BEA8B2ECE, NameHash = 0x81E5018BD0B4C94D)]
    public class GcAtlasMessage : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public GcUniverseAddressData UniverseAddress;
        /* 0x28 */ public int ColourIndex;
        /* 0x2C */ public NMSString0x80 CustomName;
    }
}

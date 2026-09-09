using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67764669E19805C6, NameHash = 0x98D730F2)]
    public class GcGravityVolumeAuthored : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 NodeNameStartsWith;
        [NMS(Index = 0)]
        /* 0x10 */ public GcGravityVolumeData GravityVolumeData;
        [NMS(Index = 2)]
        /* 0x20 */ public bool DeactivateNode;
        [NMS(Index = 3)]
        /* 0x21 */ public bool IsCapsuleInY;
    }
}

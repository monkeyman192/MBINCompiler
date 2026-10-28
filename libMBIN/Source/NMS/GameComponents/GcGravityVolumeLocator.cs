using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65232B941B22DD0C, NameHash = 0xEFA00D9A)]
    public class GcGravityVolumeLocator : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 NodeNameStartsWith;
        [NMS(Index = 0)]
        /* 0x10 */ public GcGravityVolumeData GravityVolumeData;
    }
}

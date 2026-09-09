using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B4C64A122D07CE4, NameHash = 0x8B4BD057)]
    public class GcGravityVolumeBounds : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGravityVolumeData GravityVolumeData;
    }
}

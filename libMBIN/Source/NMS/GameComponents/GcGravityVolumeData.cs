namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC13FF292738A0D2E, NameHash = 0x75F9E72C)]
    public class GcGravityVolumeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float CornerRadius;
        [NMS(Index = 2)]
        /* 0x4 */ public float FalloffDistance;
        [NMS(Index = 0)]
        /* 0x8 */ public float GravityStrength;
        [NMS(Index = 3)]
        /* 0xC */ public bool BlendGravityWithFalloff;
    }
}

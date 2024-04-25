namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFFFB0FD90DBE99B2, NameHash = 0x3EB24220A135426C)]
    public class TkGravityComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float FalloffRadius;
        [NMS(Index = 0)]
        /* 0x4 */ public float Strength;
    }
}

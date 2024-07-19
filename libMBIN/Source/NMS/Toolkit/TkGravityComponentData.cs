namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE85BA739408AAF81, NameHash = 0x41722F61)]
    public class TkGravityComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float FalloffRadius;
        [NMS(Index = 0)]
        /* 0x4 */ public float Strength;
    }
}

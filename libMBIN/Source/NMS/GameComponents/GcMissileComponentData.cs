namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x804C8875458D6D60, NameHash = 0x342DA8D8BE5A9CE3)]
    public class GcMissileComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Explosion;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 Trail;
        [NMS(Index = 1)]
        /* 0x20 */ public float NoTargetLife;
    }
}

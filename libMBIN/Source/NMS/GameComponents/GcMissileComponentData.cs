namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A6EA81C12E9B119, NameHash = 0x342DA8D8BE5A9CE3)]
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

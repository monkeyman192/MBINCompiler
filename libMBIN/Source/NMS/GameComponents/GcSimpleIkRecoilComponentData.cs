namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15852B0533034E71, NameHash = 0xDD1730E4)]
    public class GcSimpleIkRecoilComponentData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public float ActiveRange;
        [NMS(Index = 5)]
        /* 0x04 */ public float AngleLimit;
        [NMS(Index = 2)]
        /* 0x08 */ public float HitReactDirectedMax;
        [NMS(Index = 1)]
        /* 0x0C */ public float HitReactDirectedMin;
        [NMS(Index = 4)]
        /* 0x10 */ public float HitReactRandomMax;
        [NMS(Index = 3)]
        /* 0x14 */ public float HitReactRandomMin;
        [NMS(Index = 6)]
        /* 0x18 */ public float MinHitReactTime;
        [NMS(Index = 7)]
        /* 0x1C */ public float RecoverTime;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x100 EndJoint;
    }
}

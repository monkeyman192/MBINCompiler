namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53F711196A6BD582, NameHash = 0xF516885AE98E72E8)]
    public class GcSimpleIkRecoilComponentData : NMSTemplate
    {
        /* 0x00 */ public float ActiveRange;
        /* 0x04 */ public float AngleLimit;
        /* 0x08 */ public float HitReactDirectedMax;
        /* 0x0C */ public float HitReactDirectedMin;
        /* 0x10 */ public float HitReactRandomMax;
        /* 0x14 */ public float HitReactRandomMin;
        /* 0x18 */ public float MinHitReactTime;
        /* 0x1C */ public float RecoverTime;
        /* 0x20 */ public NMSString0x100 EndJoint;
    }
}

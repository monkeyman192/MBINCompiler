using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, GUID = 0x2F34AAE6D58F523F, NameHash = 0xF516885AE98E72E8)]
    public class GcSimpleIkRecoilComponentData : NMSTemplate
    {
		/* 0x000 */ public NMSString0x100 EndJoint;
        /* 0x100 */ public float HitReactDirectedMin;
        /* 0x104 */ public float HitReactDirectedMax;
        /* 0x108 */ public float HitReactRandomMin;
        /* 0x10C */ public float HitReactRandomMax;
        /* 0x110 */ public float AngleLimit;
        /* 0x114 */ public float MinHitReactTime;
        /* 0x118 */ public float RecoverTime;
        /* 0x11C */ public float ActiveRange;
    }
}

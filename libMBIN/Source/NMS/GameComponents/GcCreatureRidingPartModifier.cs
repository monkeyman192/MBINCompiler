using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFD5D10FDC84415F, NameHash = 0xCA1CBBFC)]
    public class GcCreatureRidingPartModifier : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public Vector3f Offset;
        [NMS(Index = 8)]
        /* 0x010 */ public Vector3f RotationOffset;
        [NMS(Index = 9)]
        /* 0x020 */ public Vector3f VROffset;
        [NMS(Index = 0)]
        /* 0x030 */ public NMSString0x20A PartName;
        [NMS(Index = 14)]
        /* 0x050 */ public NMSString0x10 DefaultRidingAnim;
        [NMS(Index = 13)]
        /* 0x060 */ public NMSString0x10 IdleRidingAnim;
        [NMS(Index = 15)]
        /* 0x070 */ public List<GcCreatureRidingAnimation> RidingAnims;
        [NMS(Index = 10)]
        /* 0x080 */ public float HeadCounterRotation;
        [NMS(Index = 11)]
        /* 0x084 */ public float LegSpreadOffset;
        [NMS(Index = 3)]
        /* 0x088 */ public float MaxScale;
        [NMS(Index = 2)]
        /* 0x08C */ public float MinScale;
        [NMS(Index = 4)]
        /* 0x090 */ public NMSString0x100 AdditionalScaleJoint;
        [NMS(Index = 1)]
        /* 0x190 */ public NMSString0x100 JointName;
        [NMS(Index = 5)]
        /* 0x290 */ public bool BreakIfNotSelected;
        [NMS(Index = 12)]
        /* 0x291 */ public bool OverrideAnims;
        [NMS(Index = 6)]
        /* 0x292 */ public bool RelativeOffset;
    }
}

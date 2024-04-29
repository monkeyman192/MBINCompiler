using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84B54D69F280D983, NameHash = 0xCBC8926C6C9D9A51)]
    public class GcCreatureRidingData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public Vector3f Offset;
        [NMS(Index = 3)]
        /* 0x010 */ public Vector3f RotationOffset;
        [NMS(Index = 4)]
        /* 0x020 */ public Vector3f VROffset;
        [NMS(Index = 14)]
        /* 0x030 */ public NMSString0x10 DefaultRidingAnim;
        [NMS(Index = 13)]
        /* 0x040 */ public NMSString0x10 IdleRidingAnim;
        [NMS(Index = 12)]
        /* 0x050 */ public List<GcCreatureRidingPartModifier> PartModifiers;
        [NMS(Index = 15)]
        /* 0x060 */ public List<GcCreatureRidingAnimation> RidingAnims;
        [NMS(Index = 5)]
        /* 0x070 */ public float HeadCounterRotation;
        [NMS(Index = 10)]
        /* 0x074 */ public float ScaleForMaxLegSpread;
        [NMS(Index = 9)]
        /* 0x078 */ public float ScaleForMinLegSpread;
        [NMS(Index = 8)]
        /* 0x07C */ public float ScaleForNeutralLegSpread;
        [NMS(Index = 6)]
        /* 0x080 */ public float UprightStrength;
        [NMS(Index = 1)]
        /* 0x084 */ public NMSString0x100 AdditionalScaleJoint;
        [NMS(Index = 0)]
        /* 0x184 */ public NMSString0x100 JointName;
        [NMS(Index = 7)]
        /* 0x284 */ public bool LegSpread;
        [NMS(Index = 11)]
        /* 0x285 */ public bool RequiresMatchingPartModifier;
    }
}

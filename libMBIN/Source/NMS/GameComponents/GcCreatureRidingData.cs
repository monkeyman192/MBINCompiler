using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEDEBE610D3F2531, NameHash = 0xCBC8926C6C9D9A51)]
    public class GcCreatureRidingData : NMSTemplate
    {
        /* 0x000 */ public Vector3f Offset;
        /* 0x010 */ public Vector3f RotationOffset;
        /* 0x020 */ public Vector3f VROffset;
        /* 0x030 */ public NMSString0x10 DefaultRidingAnim;
        /* 0x040 */ public NMSString0x10 IdleRidingAnim;
        /* 0x050 */ public List<GcCreatureRidingPartModifier> PartModifiers;
        /* 0x060 */ public List<GcCreatureRidingAnimation> RidingAnims;
        /* 0x070 */ public float HeadCounterRotation;
        /* 0x074 */ public float ScaleForMaxLegSpread;
        /* 0x078 */ public float ScaleForMinLegSpread;
        /* 0x07C */ public float ScaleForNeutralLegSpread;
        /* 0x080 */ public float UprightStrength;
        /* 0x084 */ public NMSString0x100 AdditionalScaleJoint;
        /* 0x184 */ public NMSString0x100 JointName;
        /* 0x284 */ public bool LegSpread;
        /* 0x285 */ public bool RequiresMatchingPartModifier;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66B10ABD887EC31F, NameHash = 0xB9A3955D41C87D67)]
    public class GcCreatureRidingPartModifier : NMSTemplate
    {
        /* 0x000 */ public Vector3f Offset;
        /* 0x010 */ public Vector3f RotationOffset;
        /* 0x020 */ public Vector3f VROffset;
        /* 0x030 */ public NMSString0x20A PartName;
        /* 0x050 */ public NMSString0x10 DefaultRidingAnim;
        /* 0x060 */ public NMSString0x10 IdleRidingAnim;
        /* 0x070 */ public List<GcCreatureRidingAnimation> RidingAnims;
        /* 0x080 */ public float HeadCounterRotation;
        /* 0x084 */ public float LegSpreadOffset;
        /* 0x088 */ public float MaxScale;
        /* 0x08C */ public float MinScale;
        /* 0x090 */ public NMSString0x100 AdditionalScaleJoint;
        /* 0x190 */ public NMSString0x100 JointName;
        /* 0x290 */ public bool BreakIfNotSelected;
        /* 0x291 */ public bool OverrideAnims;
        /* 0x292 */ public bool RelativeOffset;
    }
}

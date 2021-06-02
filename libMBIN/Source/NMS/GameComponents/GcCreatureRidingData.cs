using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x290, Alignment = 0x10, GUID = 0xCFC4E29700DBAD43, NameHash = 0xCBC8926C6C9D9A51)]
    public class GcCreatureRidingData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 JointName;
        /* 0x100 */ public NMSString0x100 AdditionalScaleJoint;
        /* 0x200 */ public Vector3f Offset;
        /* 0x210 */ public Vector3f RotationOffset;
        /* 0x220 */ public Vector3f VROffset;
        /* 0x230 */ public float HeadCounterRotation;
        /* 0x234 */ public float UprightStrength;
        /* 0x238 */ public bool LegSpread;
        /* 0x23C */ public float ScaleForNeutralLegSpread;
        /* 0x240 */ public float ScaleForMinLegSpread;
        /* 0x244 */ public float ScaleForMaxLegSpread;
        /* 0x248 */ public bool RequiresMatchingPartModifier;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x249 */ public byte[] Padding249;
        /* 0x250 */ public List<GcCreatureRidingPartModifier> PartModifiers;
        /* 0x260 */ public NMSString0x10 IdleRidingAnim;
        /* 0x270 */ public NMSString0x10 DefaultRidingAnim;
        /* 0x280 */ public List<GcCreatureRidingAnimation> RidingAnims;
    }
}

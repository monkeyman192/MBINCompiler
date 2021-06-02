using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2A0, GUID = 0x3C344C32A2437BC0, NameHash = 0xB9A3955D41C87D67)]
    public class GcCreatureRidingPartModifier : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Partname;
        /* 0x020 */ public NMSString0x100 JointName;
        /* 0x120 */ public float MinScale;
        /* 0x124 */ public float MaxScale;
        /* 0x128 */ public NMSString0x100 AdditionalScaleJoint;
        /* 0x229 */ public bool BreakIfNotSelected;
        /* 0x229 */ public bool RelativeOffset;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x22A */ public byte[] Padding22A;
        /* 0x230 */ public Vector3f Offset;
        /* 0x240 */ public Vector3f RotationOffset;
        /* 0x250 */ public Vector3f VROffset;
        /* 0x260 */ public float HeadCounterRotation;
        /* 0x264 */ public float LegSpreadOffset;
        /* 0x268 */ public bool OverrideAnims;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x269 */ public byte[] Padding269;
        /* 0x270 */ public NMSString0x10 IdleRidingAnim;
        /* 0x280 */ public NMSString0x10 DefaultRidingAnim;
        /* 0x290 */ public List<GcCreatureRidingAnimation> RidingAnims;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x290, GUID = 0xEAE224822F8AC71F, NameHash = 0xB9A3955D41C87D67)]
    public class GcCreatureRidingPartModifier : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Partname;
        [NMS(Size = 0x100)]
        /* 0x020 */ public string JointName;
        [NMS(Size = 0x100)]
        /* 0x120 */ public string AdditionalScaleJoint;
        /* 0x220 */ public bool RelativeOffset;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x221 */ public byte[] Padding221;
        /* 0x230 */ public Vector3f Offset;
        /* 0x240 */ public Vector3f RotationOffset;
        /* 0x250 */ public float LegSpreadOffset;
        /* 0x254 */ public float HeadPitch;
        /* 0x258 */ public bool OverrideAnims;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x259 */ public byte[] Padding259;
        [NMS(Size = 0x10)]
        /* 0x260 */ public string IdleRidingAnim;
        [NMS(Size = 0x10)]
        /* 0x270 */ public string DefaultRidingAnim;
        /* 0x280 */ public List<GcCreatureRidingAnimation> RidingAnims;
    }
}

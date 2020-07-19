using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, GUID = 0x651D62BFE2EE5181, NameHash = 0x3EB24220A135426C)]
    public class TkGravityComponentData : NMSTemplate
    {
        /* 0x00 */ public float Strength;
        /* 0x10 */ public Vector3f Centre;
        /* 0x20 */ public Vector3f Extents;
        /* 0x30 */ public float FalloffRadius;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x34 */ public byte[] EndPadding;
    }
}
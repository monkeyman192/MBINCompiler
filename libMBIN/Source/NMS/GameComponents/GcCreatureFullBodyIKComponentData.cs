using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x7329F4CFE6FE07F1, NameHash = 0x741554C15123D097)]
    public class GcCreatureFullBodyIKComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureIkData> JointData;
        /* 0x10 */ public List<GcIkPistonData> PistonData;
		public enum HeadUpAxisEnum { X, XNeg, Y, YNeg, Z, ZNeg }
		/* 0x20 */ public HeadUpAxisEnum HeadUpAxis;
        /* 0x24 */ public float MaxHeadPitch;
        /* 0x28 */ public float MaxHeadRoll;
        /* 0x2C */ public float MaxHeadYaw;
        /* 0x30 */ public bool UseFootGlue;
        /* 0x34 */ public float FootPlantSpringTime;
        /* 0x38 */ public bool UseFootAngle;
        /* 0x3C */ public float FootAngleSpeed;
        /* 0x40 */ public float MaxFootAngle;
        /* 0x44 */ public bool UsePistons;
        /* 0x45 */ public bool Mech;
        [NMS(Size = 2, Ignore = true)]
        /* 0x46 */ public byte[] EndPadding;
    }
}

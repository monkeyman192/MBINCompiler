using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1E0)]
    public class GcPlayerFullBodyIKComponentData : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public bool EnableFootRaycasts;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x002 */ public byte[] Padding2;
        /* 0x008 */ public List<GcIkConstraint> HeadConstraints;
        /* 0x018 */ public List<GcIkConstraint> LegConstraints;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x028 */ public byte[] Padding28;
        /* 0x030 */ public GcIkConstraint COGConstraint;
        /* 0x180 */ public List<GcIkConstraint> RestrictConstraints;

		public enum PlayerHeadUpAxisEnum { X, XNeg, Y, YNeg, Z, ZNeg }
		public PlayerHeadUpAxisEnum PlayerHeadUpAxis;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x194 */ public byte[] Padding194;
        /* 0x198 */ public List<GcCreatureIkData> JointDataDepreciated;
        /* 0x1A8 */ public bool UseFootGlue;
        /* 0x1AC */ public GcCharacterLookAtData LookAtSettings;
    }
}

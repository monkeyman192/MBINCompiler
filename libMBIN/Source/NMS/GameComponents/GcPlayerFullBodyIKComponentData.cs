using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x350, GUID = 0x9C4438C1A1F6C2A5, NameHash = 0x80648B8FC1E7CB4D)]
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
        /* 0x190 */ public List<NMSString0x20> HandBones;
        /* 0x1A0 */ public List<NMSString0x20> CameraNeckBones;
        /* 0x1B0 */ public GcIkConstraint SitConstraint;

        public enum PlayerHeadUpAxisEnum { X, XNeg, Y, YNeg, Z, ZNeg }
		/* 0x300 */ public PlayerHeadUpAxisEnum PlayerHeadUpAxis;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x304 */ public byte[] Padding304;
        /* 0x308 */ public List<GcCreatureIkData> JointDataDepreciated;
        /* 0x318 */ public bool UseFootGlue;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x319 */ public byte[] Padding319;
        /* 0x31C */ public GcCharacterLookAtData LookAtSettings;
    }
}

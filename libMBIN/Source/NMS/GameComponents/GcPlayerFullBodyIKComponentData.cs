using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x800489C5750E2A6E, NameHash = 0x80648B8FC1E7CB4D)]
    public class GcPlayerFullBodyIKComponentData : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public bool EnableFootRaycasts;
        /* 0x008 */ public List<GcIkConstraint> HeadConstraints;
        /* 0x018 */ public List<GcIkConstraint> LegConstraints;
        /* 0x030 */ public GcIkConstraint COGConstraint;
        /* 0x180 */ public List<GcIkConstraint> RestrictConstraints;
        /* 0x190 */ public List<NMSString0x20> HandBones;
        /* 0x1A0 */ public List<NMSString0x20> CameraNeckBones;
        /* 0x1B0 */ public GcIkConstraint SitConstraint;

        public enum PlayerHeadUpAxisEnum { X, XNeg, Y, YNeg, Z, ZNeg }
		/* 0x300 */ public PlayerHeadUpAxisEnum PlayerHeadUpAxis;
        /* 0x308 */ public List<GcCreatureIkData> JointDataDepreciated;
        /* 0x318 */ public bool UseFootGlue;
        /* 0x31C */ public GcCharacterLookAtData LookAtSettings;
    }
}

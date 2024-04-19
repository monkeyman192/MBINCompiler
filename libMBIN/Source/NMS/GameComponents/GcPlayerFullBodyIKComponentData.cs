using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1050DC441F582ECB, NameHash = 0x80648B8FC1E7CB4D)]
    public class GcPlayerFullBodyIKComponentData : NMSTemplate
    {
        /* 0x000 */ public GcIKConstraint COGConstraint;
        /* 0x150 */ public GcIKConstraint SitConstraint;
        /* 0x2A0 */ public List<NMSString0x20> CameraNeckBones;
        /* 0x2B0 */ public List<NMSString0x20> HandBones;
        /* 0x2C0 */ public List<GcIKConstraint> HeadConstraints;
        /* 0x2D0 */ public List<GcCreatureIkData> JointDataDeprecated;
        /* 0x2E0 */ public List<GcIKConstraint> LegConstraints;
        /* 0x2F0 */ public List<GcIKConstraint> RestrictConstraints;
        /* 0x300 */ public GcCharacterLookAtData LookAtSettings;
        // size: 0x6
        public enum PlayerHeadUpAxisEnum : uint {
            X,
            XNeg,
            Y,
            YNeg,
            Z,
            ZNeg,
        }
        /* 0x334 */ public PlayerHeadUpAxisEnum PlayerHeadUpAxis;
        /* 0x338 */ public bool Enabled;
        /* 0x339 */ public bool EnableFootRaycasts;
        /* 0x33A */ public bool UseFootGlue;
    }
}

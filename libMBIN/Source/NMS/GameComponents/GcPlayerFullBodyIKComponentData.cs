using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99DC7E2D12D1102, NameHash = 0x80648B8FC1E7CB4D)]
    public class GcPlayerFullBodyIKComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public GcIKConstraint COGConstraint;
        [NMS(Index = 8)]
        /* 0x150 */ public GcIKConstraint SitConstraint;
        [NMS(Index = 7)]
        /* 0x2A0 */ public List<NMSString0x20> CameraNeckBones;
        [NMS(Index = 6)]
        /* 0x2B0 */ public List<NMSString0x20> HandBones;
        [NMS(Index = 2)]
        /* 0x2C0 */ public List<GcIKConstraint> HeadConstraints;
        [NMS(Index = 10)]
        /* 0x2D0 */ public List<GcCreatureIkData> JointDataDeprecated;
        [NMS(Index = 3)]
        /* 0x2E0 */ public List<GcIKConstraint> LegConstraints;
        [NMS(Index = 5)]
        /* 0x2F0 */ public List<GcIKConstraint> RestrictConstraints;
        [NMS(Index = 12)]
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
        [NMS(Index = 9)]
        /* 0x334 */ public PlayerHeadUpAxisEnum PlayerHeadUpAxis;
        [NMS(Index = 0)]
        /* 0x338 */ public bool Enabled;
        [NMS(Index = 1)]
        /* 0x339 */ public bool EnableFootRaycasts;
        [NMS(Index = 11)]
        /* 0x33A */ public bool UseFootGlue;
    }
}

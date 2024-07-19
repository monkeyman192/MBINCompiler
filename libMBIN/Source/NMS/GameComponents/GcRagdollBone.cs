using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD49F961CDEB3FA37, NameHash = 0xAAC2EA7D)]
    public class GcRagdollBone : NMSTemplate
    {
        [NMS(Index = 15)]
        /* 0x000 */ public AxisSpecification LimitedPlaneAxis;
        [NMS(Index = 14)]
        /* 0x020 */ public AxisSpecification LimitedTwistAxis;
        [NMS(Index = 13)]
        /* 0x040 */ public AxisSpecification LimitingPlaneAxis;
        [NMS(Index = 12)]
        /* 0x060 */ public AxisSpecification LimitingTwistAxis;
        [NMS(Index = 9)]
        /* 0x080 */ public Vector3f ParentNodeTransformInBone_AxisX;
        [NMS(Index = 10)]
        /* 0x090 */ public Vector3f ParentNodeTransformInBone_AxisY;
        [NMS(Index = 11)]
        /* 0x0A0 */ public Vector3f ParentNodeTransformInBone_AxisZ;
        [NMS(Index = 8)]
        /* 0x0B0 */ public Vector3f ParentNodeTransformInBone_Position;
        [NMS(Index = 22)]
        /* 0x0C0 */ public List<GcChildNode> ChildNodes;
        [NMS(Index = 21)]
        /* 0x0D0 */ public List<GcRagdolCollisionObject> CollisionObjects;
        [NMS(Index = 2)]
        /* 0x0E0 */ public List<NMSString0x40> NodeNames;
        [NMS(Index = 4)]
        /* 0x0F0 */ public List<Vector3f> NodeTransformInBone_AxisX;
        [NMS(Index = 5)]
        /* 0x100 */ public List<Vector3f> NodeTransformInBone_AxisY;
        [NMS(Index = 6)]
        /* 0x110 */ public List<Vector3f> NodeTransformInBone_AxisZ;
        [NMS(Index = 3)]
        /* 0x120 */ public List<Vector3f> NodeTransformInBone_Position;
        [NMS(Index = 17)]
        /* 0x130 */ public float ConeLimitDeg;
        // size: 0x7
        public enum LimbTypeEnum : uint {
            LeftUpperArm,
            RightUpperArm,
            LeftUpperLeg,
            RightUpperLeg,
            LeftFoot,
            RightFoot,
            Other,
        }
        [NMS(Index = 20)]
        /* 0x134 */ public LimbTypeEnum LimbType;
        [NMS(Index = 18)]
        /* 0x138 */ public float PlaneMaxAngleDeg;
        [NMS(Index = 19)]
        /* 0x13C */ public float PlaneMinAngleDeg;
        [NMS(Index = 16)]
        /* 0x140 */ public float TwistLimitDeg;
        [NMS(Index = 1)]
        /* 0x144 */ public NMSString0x40 Name;
        [NMS(Index = 7)]
        /* 0x184 */ public NMSString0x40 ParentNodeName;
        [NMS(Index = 0)]
        /* 0x1C4 */ public bool Enabled;
    }
}

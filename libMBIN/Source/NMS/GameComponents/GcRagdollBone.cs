using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4311DB2434073FB8, NameHash = 0xC016E2C8C89F4CF4)]
    public class GcRagdollBone : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x000 */ public AxisSpecification LimitedPlaneAxis;
        [NMS(Index = 15)]
        /* 0x020 */ public AxisSpecification LimitedTwistAxis;
        [NMS(Index = 14)]
        /* 0x040 */ public AxisSpecification LimitingPlaneAxis;
        [NMS(Index = 13)]
        /* 0x060 */ public AxisSpecification LimitingTwistAxis;
        [NMS(Index = 22)]
        /* 0x080 */ public Vector3f AabbMax;
        [NMS(Index = 21)]
        /* 0x090 */ public Vector3f AabbMin;
        [NMS(Index = 29)]
        /* 0x0A0 */ public Vector3f CentreOfMass;
        [NMS(Index = 23)]
        /* 0x0B0 */ public Vector3f CollisionRotationDeg;
        [NMS(Index = 25)]
        /* 0x0C0 */ public Vector3f CollisionScale;
        [NMS(Index = 24)]
        /* 0x0D0 */ public Vector3f CollisionTranslation;
        [NMS(Index = 12)]
        /* 0x0E0 */ public Vector3f JointPosition;
        [NMS(Index = 9)]
        /* 0x0F0 */ public Vector3f ParentNodeTransformInBone_AxisX;
        [NMS(Index = 10)]
        /* 0x100 */ public Vector3f ParentNodeTransformInBone_AxisY;
        [NMS(Index = 11)]
        /* 0x110 */ public Vector3f ParentNodeTransformInBone_AxisZ;
        [NMS(Index = 8)]
        /* 0x120 */ public Vector3f ParentNodeTransformInBone_Position;
        [NMS(Index = 30)]
        /* 0x130 */ public List<GcChildNode> ChildNodes;
        [NMS(Index = 2)]
        /* 0x140 */ public List<NMSString0x40> NodeNames;
        [NMS(Index = 4)]
        /* 0x150 */ public List<Vector3f> NodeTransformInBone_AxisX;
        [NMS(Index = 5)]
        /* 0x160 */ public List<Vector3f> NodeTransformInBone_AxisY;
        [NMS(Index = 6)]
        /* 0x170 */ public List<Vector3f> NodeTransformInBone_AxisZ;
        [NMS(Index = 3)]
        /* 0x180 */ public List<Vector3f> NodeTransformInBone_Position;
        [NMS(Index = 27)]
        /* 0x190 */ public int CapsuleLongAxisIndex;
        // size: 0x3
        public enum CollisionShapeEnum : uint {
            Box,
            Capsule,
            Sphere,
        }
        [NMS(Index = 26)]
        /* 0x194 */ public CollisionShapeEnum CollisionShape;
        [NMS(Index = 18)]
        /* 0x198 */ public float ConeLimitDeg;
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
        [NMS(Index = 28)]
        /* 0x19C */ public LimbTypeEnum LimbType;
        [NMS(Index = 19)]
        /* 0x1A0 */ public float PlaneMaxAngleDeg;
        [NMS(Index = 20)]
        /* 0x1A4 */ public float PlaneMinAngleDeg;
        [NMS(Index = 17)]
        /* 0x1A8 */ public float TwistLimitDeg;
        [NMS(Index = 1)]
        /* 0x1AC */ public NMSString0x40 Name;
        [NMS(Index = 7)]
        /* 0x1EC */ public NMSString0x40 ParentNodeName;
        [NMS(Index = 0)]
        /* 0x22C */ public bool Enabled;
    }
}

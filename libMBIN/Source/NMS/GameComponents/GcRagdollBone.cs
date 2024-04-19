using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2BC2C0094D0DA23, NameHash = 0xC016E2C8C89F4CF4)]
    public class GcRagdollBone : NMSTemplate
    {
        /* 0x000 */ public AxisSpecification LimitedPlaneAxis;
        /* 0x020 */ public AxisSpecification LimitedTwistAxis;
        /* 0x040 */ public AxisSpecification LimitingPlaneAxis;
        /* 0x060 */ public AxisSpecification LimitingTwistAxis;
        /* 0x080 */ public Vector3f AabbMax;
        /* 0x090 */ public Vector3f AabbMin;
        /* 0x0A0 */ public Vector3f CentreOfMass;
        /* 0x0B0 */ public Vector3f CollisionRotationDeg;
        /* 0x0C0 */ public Vector3f CollisionScale;
        /* 0x0D0 */ public Vector3f CollisionTranslation;
        /* 0x0E0 */ public Vector3f JointPosition;
        /* 0x0F0 */ public Vector3f ParentNodeTransformInBone_AxisX;
        /* 0x100 */ public Vector3f ParentNodeTransformInBone_AxisY;
        /* 0x110 */ public Vector3f ParentNodeTransformInBone_AxisZ;
        /* 0x120 */ public Vector3f ParentNodeTransformInBone_Position;
        /* 0x130 */ public List<GcChildNode> ChildNodes;
        /* 0x140 */ public List<NMSString0x40> NodeNames;
        /* 0x150 */ public List<Vector3f> NodeTransformInBone_AxisX;
        /* 0x160 */ public List<Vector3f> NodeTransformInBone_AxisY;
        /* 0x170 */ public List<Vector3f> NodeTransformInBone_AxisZ;
        /* 0x180 */ public List<Vector3f> NodeTransformInBone_Position;
        /* 0x190 */ public int CapsuleLongAxisIndex;
        // size: 0x3
        public enum CollisionShapeEnum : uint {
            Box,
            Capsule,
            Sphere,
        }
        /* 0x194 */ public CollisionShapeEnum CollisionShape;
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
        /* 0x19C */ public LimbTypeEnum LimbType;
        /* 0x1A0 */ public float PlaneMaxAngleDeg;
        /* 0x1A4 */ public float PlaneMinAngleDeg;
        /* 0x1A8 */ public float TwistLimitDeg;
        /* 0x1AC */ public NMSString0x40 Name;
        /* 0x1EC */ public NMSString0x40 ParentNodeName;
        /* 0x22C */ public bool Enabled;
    }
}

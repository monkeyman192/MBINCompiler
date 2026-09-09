using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9140D12B514155A, NameHash = 0xAAC2EA7D)]
    public class GcRagdollBone : NMSTemplate
    {
        [NMS(Index = 24)]
        /* 0x000 */ public AxisSpecification LimitedPlaneAxis;
        [NMS(Index = 23)]
        /* 0x020 */ public AxisSpecification LimitedTwistAxis;
        [NMS(Index = 22)]
        /* 0x040 */ public AxisSpecification LimitingPlaneAxis;
        [NMS(Index = 21)]
        /* 0x060 */ public AxisSpecification LimitingTwistAxis;
        [NMS(Index = 18)]
        /* 0x080 */ public Vector3f BoneTransformInParentNode_AxisX;
        [NMS(Index = 19)]
        /* 0x090 */ public Vector3f BoneTransformInParentNode_AxisY;
        [NMS(Index = 20)]
        /* 0x0A0 */ public Vector3f BoneTransformInParentNode_AxisZ;
        [NMS(Index = 17)]
        /* 0x0B0 */ public Vector3f BoneTransformInParentNode_Position;
        [NMS(Index = 10)]
        /* 0x0C0 */ public Vector3f ParentNodeTransformInBone_AxisX;
        [NMS(Index = 11)]
        /* 0x0D0 */ public Vector3f ParentNodeTransformInBone_AxisY;
        [NMS(Index = 12)]
        /* 0x0E0 */ public Vector3f ParentNodeTransformInBone_AxisZ;
        [NMS(Index = 9)]
        /* 0x0F0 */ public Vector3f ParentNodeTransformInBone_Position;
        [NMS(Index = 14)]
        /* 0x100 */ public List<Vector3f> BoneTransformInNode_AxisX;
        [NMS(Index = 15)]
        /* 0x110 */ public List<Vector3f> BoneTransformInNode_AxisY;
        [NMS(Index = 16)]
        /* 0x120 */ public List<Vector3f> BoneTransformInNode_AxisZ;
        [NMS(Index = 13)]
        /* 0x130 */ public List<Vector3f> BoneTransformInNode_Position;
        [NMS(Index = 31)]
        /* 0x140 */ public List<GcChildNode> ChildNodes;
        [NMS(Index = 30)]
        /* 0x150 */ public List<GcRagdolCollisionObject> CollisionObjects;
        [NMS(Index = 2)]
        /* 0x160 */ public List<NMSString0x40> NodeNames;
        [NMS(Index = 6)]
        /* 0x170 */ public List<Vector3f> NodeTransformInBone_AxisX;
        [NMS(Index = 7)]
        /* 0x180 */ public List<Vector3f> NodeTransformInBone_AxisY;
        [NMS(Index = 8)]
        /* 0x190 */ public List<Vector3f> NodeTransformInBone_AxisZ;
        [NMS(Index = 5)]
        /* 0x1A0 */ public List<Vector3f> NodeTransformInBone_Position;
        [NMS(Index = 26)]
        /* 0x1B0 */ public float ConeLimitDeg;
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
        [NMS(Index = 29)]
        /* 0x1B4 */ public LimbTypeEnum LimbType;
        [NMS(Index = 27)]
        /* 0x1B8 */ public float PlaneMaxAngleDeg;
        [NMS(Index = 28)]
        /* 0x1BC */ public float PlaneMinAngleDeg;
        [NMS(Index = 25)]
        /* 0x1C0 */ public float TwistLimitDeg;
        [NMS(Index = 1)]
        /* 0x1C4 */ public NMSString0x40 Name;
        [NMS(Index = 3)]
        /* 0x204 */ public NMSString0x40 ParentNodeName;
        [NMS(Index = 0)]
        /* 0x244 */ public bool Enabled;
        [NMS(Index = 4)]
        /* 0x245 */ public bool UseBoneTransformsInNodes;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD01229EB9EA34333, NameHash = 0x1BAB3C5B)]
    public class GcRagdolCollisionObject : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f CentreInBone;
        [NMS(Index = 7)]
        /* 0x10 */ public Vector3f CentreInNode;
        [NMS(Index = 2)]
        /* 0x20 */ public Vector3f ExtentInBone;
        [NMS(Index = 8)]
        /* 0x30 */ public Vector3f ExtentInNode;
        [NMS(Index = 4)]
        /* 0x40 */ public Vector3f HalfVectorInBone;
        [NMS(Index = 10)]
        /* 0x50 */ public Vector3f HalfVectorInNode;
        [NMS(Index = 5)]
        /* 0x60 */ public Vector4f OrientationQuaternionInBone;
        [NMS(Index = 11)]
        /* 0x70 */ public Vector4f OrientationQuaternionInNode;
        [NMS(Index = 0)]
        /* 0x80 */ public CollisionShapeType CollisionShapeType;
        [NMS(Index = 3)]
        /* 0x84 */ public float RadiusInBone;
        [NMS(Index = 9)]
        /* 0x88 */ public float RadiusInNode;
        [NMS(Index = 6)]
        /* 0x8C */ public bool UseCollisionDataInNodeFrame;
    }
}

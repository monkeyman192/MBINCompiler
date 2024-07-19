namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CD4E738C1281C4A, NameHash = 0x1BAB3C5B)]
    public class GcRagdolCollisionObject : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Centre;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector3f Extent;
        [NMS(Index = 4)]
        /* 0x20 */ public Vector3f HalfVector;
        [NMS(Index = 5)]
        /* 0x30 */ public Vector4f OrientationQuaternion;
        // size: 0x4
        public enum CollisionShapeTypeEnum : uint {
            Box,
            Capsule,
            Sphere,
            None,
        }
        [NMS(Index = 0)]
        /* 0x40 */ public CollisionShapeTypeEnum CollisionShapeType;
        [NMS(Index = 3)]
        /* 0x44 */ public float Radius;
    }
}

using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x32601FB6FD32C46B, NameHash = 0xB06E660D)]
    public class TkEmitterRotation : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector3f RotationAxis;
        [NMS(Index = 3)]
        /* 0x10 */ public TkEmitterFloatProperty Rotation;
        // size: 0x3
        public enum AlignmentAxisEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        [NMS(Index = 0)]
        /* 0x48 */ public AlignmentAxisEnum AlignmentAxis;
        [NMS(Index = 2)]
        /* 0x4C */ public float RotationOffset;
        [NMS(Index = 1)]
        /* 0x50 */ public float StartRotationVariation;
    }
}

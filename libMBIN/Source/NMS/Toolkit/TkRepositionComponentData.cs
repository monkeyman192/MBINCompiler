using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x815FC5B95C9D375E, NameHash = 0x7B0AA69F)]
    public class TkRepositionComponentData : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public Vector2f RandomUpAxisRotationMinMax;
        // size: 0x3
        public enum DestinationUpOrientationEnum : uint {
            MaintainExistingUp,
            MatchWorldUp,
            MatchContactNormal,
        }
        [NMS(Index = 6)]
        /* 0x08 */ public DestinationUpOrientationEnum DestinationUpOrientation;
        [NMS(Index = 9)]
        /* 0x0C */ public float MaxUpAngleDifferenceLocalX;
        [NMS(Index = 10)]
        /* 0x10 */ public float MaxUpAngleDifferenceLocalZ;
        [NMS(Index = 8)]
        /* 0x14 */ public float MaxUpAngleOverallDifference;
        // size: 0x4
        public enum NodeToRepositionEnum : uint {
            AttachmentNode,
            ModelNode,
            MasterModelNode,
            SpecificLocator,
        }
        [NMS(Index = 0)]
        /* 0x18 */ public NodeToRepositionEnum NodeToReposition;
        [NMS(Index = 5)]
        /* 0x1C */ public GcPhysicsCollisionGroups RaycastCollisionGroup;
        [NMS(Index = 2)]
        /* 0x20 */ public float RepositionMaxDistance;
        // size: 0x9
        public enum RepositionRaycastDirectionEnum : uint {
            WorldDown,
            WorldUp,
            LocalXPositive,
            LocalXNegative,
            LocalYPositive,
            LocalYNegative,
            LocalZPositive,
            LocalZNegative,
            UseRaycastLocatorAt,
        }
        [NMS(Index = 3)]
        /* 0x24 */ public RepositionRaycastDirectionEnum RepositionRaycastDirection;
        [NMS(Index = 7)]
        /* 0x28 */ public float UpOrientationBlend;
        [NMS(Index = 4)]
        /* 0x2C */ public NMSString0x20 RaycastLocatorName;
        [NMS(Index = 1)]
        /* 0x4C */ public NMSString0x20 SpecificLocatorName;
    }
}

using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x517BB7514301A5B9, NameHash = 0xF90BB3)]
    public class TkPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkPhysicsData Data;
        [NMS(Index = 1)]
        /* 0x18 */ public TkNavMeshInclusionParams NavMeshInclusion;
        // size: 0x3
        public enum ModelOwnershipEnum : uint {
            Model,
            MasterModel,
            None,
        }
        [NMS(Index = 5)]
        /* 0x24 */ public ModelOwnershipEnum ModelOwnership;
        [NMS(Index = 32)]
        /* 0x28 */ public float SimpleCharacterCollisionFwdOffset;
        [NMS(Index = 30)]
        /* 0x2C */ public float SimpleCharacterCollisionHeight;
        [NMS(Index = 31)]
        /* 0x30 */ public float SimpleCharacterCollisionHeightOffset;
        [NMS(Index = 29)]
        /* 0x34 */ public float SimpleCharacterCollisionRadius;
        [NMS(Index = 21)]
        /* 0x38 */ public float SpinOnCreate;
        // size: 0x2
        public enum SurfacePropertiesEnum : uint {
            None,
            Glass,
        }
        [NMS(Index = 4)]
        /* 0x3C */ public SurfacePropertiesEnum SurfaceProperties;
        [NMS(Index = 3)]
        /* 0x40 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 23)]
        /* 0x44 */ public bool AllowedDefaultCollision;
        [NMS(Index = 18)]
        /* 0x45 */ public bool AllowTeleporter;
        [NMS(Index = 24)]
        /* 0x46 */ public bool Animated;
        [NMS(Index = 15)]
        /* 0x47 */ public bool BlocksInteract;
        [NMS(Index = 19)]
        /* 0x48 */ public bool BlockTeleporter;
        [NMS(Index = 16)]
        /* 0x49 */ public bool CameraInvisible;
        [NMS(Index = 6)]
        /* 0x4A */ public bool Climbable;
        [NMS(Index = 20)]
        /* 0x4B */ public bool DisableGravity;
        [NMS(Index = 8)]
        /* 0x4C */ public bool Floor;
        [NMS(Index = 14)]
        /* 0x4D */ public bool IgnoreAllCollisions;
        [NMS(Index = 9)]
        /* 0x4E */ public bool IgnoreModelOwner;
        [NMS(Index = 17)]
        /* 0x4F */ public bool InvisibleForInteraction;
        [NMS(Index = 26)]
        /* 0x50 */ public bool IsTransporter;
        [NMS(Index = 13)]
        /* 0x51 */ public bool NoFallDamage;
        [NMS(Index = 12)]
        /* 0x52 */ public bool NoFireCollide;
        [NMS(Index = 11)]
        /* 0x53 */ public bool NoPlayerCollide;
        [NMS(Index = 10)]
        /* 0x54 */ public bool NoVehicleCollide;
        [NMS(Index = 28)]
        /* 0x55 */ public bool RotateSimpleCharacterCollisionCapsule;
        [NMS(Index = 22)]
        /* 0x56 */ public bool ScaleAffectsMass;
        [NMS(Index = 2)]
        /* 0x57 */ public bool TriggerVolume;
        [NMS(Index = 25)]
        /* 0x58 */ public bool UseBasePartOptimisation;
        [NMS(Index = 27)]
        /* 0x59 */ public bool UseSimpleCharacterCollision;
        [NMS(Index = 7)]
        /* 0x5A */ public bool Walkable;
    }
}

using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x25CD3FFA8E448F4E, NameHash = 0xC58660803669C46F)]
    public class TkPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSTemplate RagdollData;
        [NMS(Index = 0)]
        /* 0x50 */ public TkPhysicsData Data;
        [NMS(Index = 15)]
        /* 0x68 */ public float SpinOnCreate;
        // size: 0x2
        public enum SurfacePropertiesEnum : uint {
            None,
            Glass,
        }
        [NMS(Index = 3)]
        /* 0x6C */ public SurfacePropertiesEnum SurfaceProperties;
        [NMS(Index = 2)]
        /* 0x70 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 12)]
        /* 0x74 */ public bool AllowTeleporter;
        [NMS(Index = 13)]
        /* 0x75 */ public bool BlockTeleporter;
        [NMS(Index = 10)]
        /* 0x76 */ public bool CameraInvisible;
        [NMS(Index = 5)]
        /* 0x77 */ public bool Climbable;
        [NMS(Index = 14)]
        /* 0x78 */ public bool DisableGravity;
        [NMS(Index = 6)]
        /* 0x79 */ public bool Floor;
        [NMS(Index = 7)]
        /* 0x7A */ public bool IgnoreModelOwner;
        [NMS(Index = 11)]
        /* 0x7B */ public bool InvisibleForInteraction;
        [NMS(Index = 17)]
        /* 0x7C */ public bool IsTransporter;
        [NMS(Index = 9)]
        /* 0x7D */ public bool NoPlayerCollide;
        [NMS(Index = 8)]
        /* 0x7E */ public bool NoVehicleCollide;
        [NMS(Index = 4)]
        /* 0x7F */ public bool TriggerVolume;
        [NMS(Index = 16)]
        /* 0x80 */ public bool UseBasePartOptimisation;
    }
}

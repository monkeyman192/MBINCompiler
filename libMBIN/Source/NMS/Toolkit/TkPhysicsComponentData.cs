using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x25CD3FFA8E448F4E, NameHash = 0xC58660803669C46F)]
    public class TkPhysicsComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate RagdollData;
        /* 0x50 */ public TkPhysicsData Data;
        /* 0x68 */ public float SpinOnCreate;
        // size: 0x2
        public enum SurfacePropertiesEnum : uint {
            None,
            Glass,
        }
        /* 0x6C */ public SurfacePropertiesEnum SurfaceProperties;
        /* 0x70 */ public TkVolumeTriggerType TriggerVolumeType;
        /* 0x74 */ public bool AllowTeleporter;
        /* 0x75 */ public bool BlockTeleporter;
        /* 0x76 */ public bool CameraInvisible;
        /* 0x77 */ public bool Climbable;
        /* 0x78 */ public bool DisableGravity;
        /* 0x79 */ public bool Floor;
        /* 0x7A */ public bool IgnoreModelOwner;
        /* 0x7B */ public bool InvisibleForInteraction;
        /* 0x7C */ public bool IsTransporter;
        /* 0x7D */ public bool NoPlayerCollide;
        /* 0x7E */ public bool NoVehicleCollide;
        /* 0x7F */ public bool TriggerVolume;
        /* 0x80 */ public bool UseBasePartOptimisation;
    }
}

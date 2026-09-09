using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA58CB5105D2C2A05, NameHash = 0xB2405C75)]
    public class TkStaticPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkPhysicsData Data;
        // size: 0x2
        public enum StaticPhysicsTargetNodeEnum : uint {
            Attachment,
            MasterModel,
        }
        [NMS(Index = 2)]
        /* 0x20 */ public StaticPhysicsTargetNodeEnum StaticPhysicsTargetNode;
        [NMS(Index = 5)]
        /* 0x24 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 1)]
        /* 0x28 */ public TkNavMeshInclusionParams NavMeshInclusion;
        [NMS(Index = 4)]
        /* 0x2B */ public bool AddToWorldImmediately;
        [NMS(Index = 3)]
        /* 0x2C */ public bool AddToWorldOnPrepare;
        [NMS(Index = 12)]
        /* 0x2D */ public bool CameraInvisible;
        [NMS(Index = 7)]
        /* 0x2E */ public bool Climbable;
        [NMS(Index = 9)]
        /* 0x2F */ public bool NoPlayerCollide;
        [NMS(Index = 10)]
        /* 0x30 */ public bool NoTerrainCollide;
        [NMS(Index = 8)]
        /* 0x31 */ public bool NoVehicleCollide;
        [NMS(Index = 6)]
        /* 0x32 */ public bool TriggerVolume;
        [NMS(Index = 11)]
        /* 0x33 */ public bool UseAsteroidCollision;
    }
}

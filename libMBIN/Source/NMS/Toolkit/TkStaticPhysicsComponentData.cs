using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x99BA278E9CAE3BE9, NameHash = 0x4955878C6E8051DB)]
    public class TkStaticPhysicsComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkPhysicsData Data;
        [NMS(Index = 3)]
        /* 0x18 */ public TkVolumeTriggerType TriggerVolumeType;
        [NMS(Index = 2)]
        /* 0x1C */ public bool AddToWorldImmediately;
        [NMS(Index = 1)]
        /* 0x1D */ public bool AddToWorldOnPrepare;
        [NMS(Index = 8)]
        /* 0x1E */ public bool CameraInvisible;
        [NMS(Index = 5)]
        /* 0x1F */ public bool Climbable;
        [NMS(Index = 7)]
        /* 0x20 */ public bool NoPlayerCollide;
        [NMS(Index = 6)]
        /* 0x21 */ public bool NoVehicleCollide;
        [NMS(Index = 4)]
        /* 0x22 */ public bool TriggerVolume;
    }
}

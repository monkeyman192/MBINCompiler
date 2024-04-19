using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x99BA278E9CAE3BE9, NameHash = 0x4955878C6E8051DB)]
    public class TkStaticPhysicsComponentData : NMSTemplate
    {
        /* 0x00 */ public TkPhysicsData Data;
        /* 0x18 */ public TkVolumeTriggerType TriggerVolumeType;
        /* 0x1C */ public bool AddToWorldImmediately;
        /* 0x1D */ public bool AddToWorldOnPrepare;
        /* 0x1E */ public bool CameraInvisible;
        /* 0x1F */ public bool Climbable;
        /* 0x20 */ public bool NoPlayerCollide;
        /* 0x21 */ public bool NoVehicleCollide;
        /* 0x22 */ public bool TriggerVolume;
    }
}

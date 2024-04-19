using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F1BB35707F734B, NameHash = 0x4442EB7E64C68AC9)]
    public class GcBehaviourLaunchProjectileData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueId Projectile;
        /* 0x28 */ public int Amount;
        /* 0x2C */ public float HorizontalDispersion;
        /* 0x30 */ public float VerticalDispersion;
        /* 0x34 */ public NMSString0x40 LaunchJoint;
    }
}

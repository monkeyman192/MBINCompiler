using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9E461287A0C8968, NameHash = 0x4442EB7E64C68AC9)]
    public class GcBehaviourLaunchProjectileData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueId Projectile;
        /* 0x28 */ public NMSString0x40 LaunchJoint;
        /* 0x68 */ public int Amount;
        /* 0x6C */ public float HorizontalDispersion;
        /* 0x70 */ public float VerticalDispersion;
    }
}

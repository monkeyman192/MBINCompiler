using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F1BB35707F734B, NameHash = 0x4442EB7E64C68AC9)]
    public class GcBehaviourLaunchProjectileData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkBlackboardDefaultValueId Projectile;
        [NMS(Index = 2)]
        /* 0x28 */ public int Amount;
        [NMS(Index = 3)]
        /* 0x2C */ public float HorizontalDispersion;
        [NMS(Index = 4)]
        /* 0x30 */ public float VerticalDispersion;
        [NMS(Index = 1)]
        /* 0x34 */ public NMSString0x40 LaunchJoint;
    }
}

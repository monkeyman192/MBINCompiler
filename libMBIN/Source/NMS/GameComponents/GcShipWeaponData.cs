using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E88564BD2E816CD, NameHash = 0x73BA1311CF8E1962)]
    public class GcShipWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Projectile;
        /* 0x10 */ public NMSString0x10 Reticle;
        /* 0x20 */ public float AutoAimAngle;
        /* 0x24 */ public float AutoAimExtraAngle;
        /* 0x28 */ public float CoolRate;
        /* 0x2C */ public float OverheatCoolTime;
        /* 0x30 */ public GcRemoteWeapons RemoteType;
        /* 0x34 */ public GcStatsTypes Stat;
        /* 0x38 */ public bool IsProjectile;
        /* 0x39 */ public bool ShowOverheatSwitch;
    }
}

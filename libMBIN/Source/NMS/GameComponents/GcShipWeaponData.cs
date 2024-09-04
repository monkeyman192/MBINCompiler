using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62CFD8C91069500E, NameHash = 0x549307DF)]
    public class GcShipWeaponData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Projectile;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 Reticle;
        [NMS(Index = 4)]
        /* 0x20 */ public float AutoAimAngle;
        [NMS(Index = 5)]
        /* 0x24 */ public float AutoAimExtraAngle;
        [NMS(Index = 8)]
        /* 0x28 */ public float CoolRate;
        [NMS(Index = 7)]
        /* 0x2C */ public float OverheatCoolTime;
        [NMS(Index = 9)]
        /* 0x30 */ public GcRemoteWeapons RemoteType;
        [NMS(Index = 1)]
        /* 0x34 */ public GcStatsTypes Stat;
        [NMS(Index = 2)]
        /* 0x38 */ public bool IsProjectile;
        [NMS(Index = 6)]
        /* 0x39 */ public bool ShowOverheatSwitch;
    }
}

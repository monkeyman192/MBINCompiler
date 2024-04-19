using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5542551BC66E93E, NameHash = 0x4484F9F6C0F33596)]
    public class GcSentinelMechWeaponData : NMSTemplate
    {
        /* 0x00 */ public GcVehicleWeaponMuzzleData MuzzleData;
        /* 0x20 */ public NMSString0x10 Id;
        /* 0x30 */ public NMSString0x10 Projectile;
        /* 0x40 */ public float AttackAngle;
        /* 0x44 */ public float CooldownTimeMax;
        /* 0x48 */ public float CooldownTimeMin;
        /* 0x4C */ public float ExplosionRadius;
        /* 0x50 */ public float FireInterval;
        /* 0x54 */ public float IdealRange;
        /* 0x58 */ public float InheritInitialVelocity;
        /* 0x5C */ public float MaxRange;
        /* 0x60 */ public float MinRange;
        /* 0x64 */ public int NumShotsMax;
        /* 0x68 */ public int NumShotsMin;
        /* 0x6C */ public int ProjectilesPerShot;
        /* 0x70 */ public float ProjectileSpread;
        /* 0x74 */ public GcMechWeaponLocation ShootLocation;
        /* 0x78 */ public GcAudioWwiseEvents StartFireAudioEvent;
        /* 0x7C */ public GcAudioWwiseEvents StopFireAudioEvent;
    }
}

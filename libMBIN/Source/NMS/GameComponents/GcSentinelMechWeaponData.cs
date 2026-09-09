using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD1F687744782176, NameHash = 0xBFA48A64)]
    public class GcSentinelMechWeaponData : NMSTemplate
    {
        [NMS(Index = 27)]
        /* 0x00 */ public Colour LaserLightColour;
        [NMS(Index = 26)]
        /* 0x10 */ public Vector3f LaserLightOffset;
        [NMS(Index = 9)]
        /* 0x20 */ public GcVehicleWeaponMuzzleData MuzzleData;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Id;
        [NMS(Index = 21)]
        /* 0x50 */ public NMSString0x10 LaserID;
        [NMS(Index = 13)]
        /* 0x60 */ public NMSString0x10 Projectile;
        [NMS(Index = 7)]
        /* 0x70 */ public float AttackAngle;
        [NMS(Index = 12)]
        /* 0x74 */ public float ChargeTime;
        [NMS(Index = 3)]
        /* 0x78 */ public float CooldownTimeMax;
        [NMS(Index = 2)]
        /* 0x7C */ public float CooldownTimeMin;
        [NMS(Index = 4)]
        /* 0x80 */ public float IdealRange;
        [NMS(Index = 23)]
        /* 0x84 */ public float LaserFireTimeMax;
        [NMS(Index = 22)]
        /* 0x88 */ public float LaserFireTimeMin;
        [NMS(Index = 29)]
        /* 0x8C */ public float LaserLightAttackIntensity;
        [NMS(Index = 28)]
        /* 0x90 */ public float LaserLightChargeIntensity;
        [NMS(Index = 25)]
        /* 0x94 */ public float LaserSpringTimeMax;
        [NMS(Index = 24)]
        /* 0x98 */ public float LaserSpringTimeMin;
        [NMS(Index = 6)]
        /* 0x9C */ public float MaxRange;
        [NMS(Index = 5)]
        /* 0xA0 */ public float MinRange;
        [NMS(Index = 20)]
        /* 0xA4 */ public float ProjectileExplosionRadius;
        [NMS(Index = 16)]
        /* 0xA8 */ public float ProjectileFireInterval;
        [NMS(Index = 19)]
        /* 0xAC */ public float ProjectileInheritInitialVelocity;
        [NMS(Index = 18)]
        /* 0xB0 */ public int ProjectileNumShotsMax;
        [NMS(Index = 17)]
        /* 0xB4 */ public int ProjectileNumShotsMin;
        [NMS(Index = 14)]
        /* 0xB8 */ public int ProjectilesPerShot;
        [NMS(Index = 15)]
        /* 0xBC */ public float ProjectileSpread;
        // size: 0x2
        public enum SentinelMechWeaponTypeEnum : uint {
            Projectile,
            Laser,
        }
        [NMS(Index = 1)]
        /* 0xC0 */ public SentinelMechWeaponTypeEnum SentinelMechWeaponType;
        [NMS(Index = 8)]
        /* 0xC4 */ public GcMechWeaponLocation ShootLocation;
        [NMS(Index = 10)]
        /* 0xC8 */ public GcAudioWwiseEvents StartFireAudioEvent;
        [NMS(Index = 11)]
        /* 0xCC */ public GcAudioWwiseEvents StopFireAudioEvent;
    }
}

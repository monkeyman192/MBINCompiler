using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6EA8E87B108041A1, NameHash = 0xBFA48A64)]
    public class GcSentinelMechWeaponData : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public GcVehicleWeaponMuzzleData MuzzleData;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 Projectile;
        [NMS(Index = 12)]
        /* 0x40 */ public float AttackAngle;
        [NMS(Index = 8)]
        /* 0x44 */ public float CooldownTimeMax;
        [NMS(Index = 7)]
        /* 0x48 */ public float CooldownTimeMin;
        [NMS(Index = 13)]
        /* 0x4C */ public float ExplosionRadius;
        [NMS(Index = 4)]
        /* 0x50 */ public float FireInterval;
        [NMS(Index = 9)]
        /* 0x54 */ public float IdealRange;
        [NMS(Index = 14)]
        /* 0x58 */ public float InheritInitialVelocity;
        [NMS(Index = 11)]
        /* 0x5C */ public float MaxRange;
        [NMS(Index = 10)]
        /* 0x60 */ public float MinRange;
        [NMS(Index = 6)]
        /* 0x64 */ public int NumShotsMax;
        [NMS(Index = 5)]
        /* 0x68 */ public int NumShotsMin;
        [NMS(Index = 2)]
        /* 0x6C */ public int ProjectilesPerShot;
        [NMS(Index = 3)]
        /* 0x70 */ public float ProjectileSpread;
        [NMS(Index = 15)]
        /* 0x74 */ public GcMechWeaponLocation ShootLocation;
        [NMS(Index = 17)]
        /* 0x78 */ public GcAudioWwiseEvents StartFireAudioEvent;
        [NMS(Index = 18)]
        /* 0x7C */ public GcAudioWwiseEvents StopFireAudioEvent;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x106C1D0549336E3A, NameHash = 0xCAB38C6E)]
    public class GcSentinelQuadWeaponData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x10 ChargingIdleAnimId;
        [NMS(Index = 7)]
        /* 0x10 */ public NMSString0x10 FiringIdleAnimId;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 23)]
        /* 0x30 */ public NMSString0x10 LaunchProjectileAnimId;
        [NMS(Index = 9)]
        /* 0x40 */ public NMSString0x10 MuzzleFlashEffect;
        [NMS(Index = 15)]
        /* 0x50 */ public NMSString0x10 ProjectileId;
        [NMS(Index = 14)]
        /* 0x60 */ public float ChargeLightIntensity;
        [NMS(Index = 13)]
        /* 0x64 */ public float ChargeTime;
        [NMS(Index = 21)]
        /* 0x68 */ public float ExplosionRadius;
        [NMS(Index = 18)]
        /* 0x6C */ public float FireInterval;
        [NMS(Index = 2)]
        /* 0x70 */ public float FireTimeMax;
        [NMS(Index = 1)]
        /* 0x74 */ public float FireTimeMin;
        [NMS(Index = 22)]
        /* 0x78 */ public float InheritInitialVelocity;
        [NMS(Index = 5)]
        /* 0x7C */ public float MaxAttackAngle;
        [NMS(Index = 4)]
        /* 0x80 */ public float MaxRange;
        [NMS(Index = 3)]
        /* 0x84 */ public float MinRange;
        [NMS(Index = 16)]
        /* 0x88 */ public int NumProjectiles;
        [NMS(Index = 20)]
        /* 0x8C */ public int NumShotsMax;
        [NMS(Index = 19)]
        /* 0x90 */ public int NumShotsMin;
        [NMS(Index = 17)]
        /* 0x94 */ public float ProjectileSpread;
        [NMS(Index = 10)]
        /* 0x98 */ public GcAudioWwiseEvents StartFireAudioEvent;
        [NMS(Index = 11)]
        /* 0x9C */ public GcAudioWwiseEvents StopFireAudioEvent;
        [NMS(Index = 6)]
        /* 0xA0 */ public float Timeout;
        [NMS(Index = 8)]
        /* 0xA4 */ public NMSString0x20 ShootLocatorName;
    }
}

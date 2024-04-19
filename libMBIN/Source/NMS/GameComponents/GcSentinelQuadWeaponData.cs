using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x17132E7D82CD5C6E, NameHash = 0x9CD171737A52721E)]
    public class GcSentinelQuadWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ChargingIdleAnimId;
        /* 0x10 */ public NMSString0x10 FiringIdleAnimId;
        /* 0x20 */ public NMSString0x10 Id;
        /* 0x30 */ public NMSString0x10 LaunchProjectileAnimId;
        /* 0x40 */ public NMSString0x10 MuzzleFlashEffect;
        /* 0x50 */ public NMSString0x10 ProjectileId;
        /* 0x60 */ public float ChargeLightIntensity;
        /* 0x64 */ public float ChargeTime;
        /* 0x68 */ public float ExplosionRadius;
        /* 0x6C */ public float FireInterval;
        /* 0x70 */ public float FireTimeMax;
        /* 0x74 */ public float FireTimeMin;
        /* 0x78 */ public float InheritInitialVelocity;
        /* 0x7C */ public float MaxAttackAngle;
        /* 0x80 */ public float MaxRange;
        /* 0x84 */ public float MinRange;
        /* 0x88 */ public int NumProjectiles;
        /* 0x8C */ public int NumShotsMax;
        /* 0x90 */ public int NumShotsMin;
        /* 0x94 */ public float ProjectileSpread;
        /* 0x98 */ public GcAudioWwiseEvents StartFireAudioEvent;
        /* 0x9C */ public GcAudioWwiseEvents StopFireAudioEvent;
        /* 0xA0 */ public float Timeout;
        /* 0xA4 */ public NMSString0x20 ShootLocatorName;
    }
}

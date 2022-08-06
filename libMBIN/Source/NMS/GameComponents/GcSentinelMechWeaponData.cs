using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38A754BE41C7AC6A, NameHash = 0x4484F9F6C0F33596)]
    public class GcSentinelMechWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 Projectile;
        /* 0x20 */ public int ProjectilesPerShot;
        /* 0x24 */ public float ProjectileSpread;
        /* 0x28 */ public float FireInterval;
        /* 0x2C */ public int NumShotsMin;
        /* 0x30 */ public int NumShotsMax;
        /* 0x34 */ public float CooldownTimeMin;
        /* 0x38 */ public float CooldownTimeMax;
        /* 0x3C */ public float IdealRange;
        /* 0x40 */ public float MinRange;
        /* 0x44 */ public float MaxRange;
        /* 0x48 */ public float AttackAngle;
        /* 0x4C */ public float ExplosionRadius;
        /* 0x50 */ public float InheritInitialVelocity;
        /* 0x54 */ public GcMechWeaponLocation ShootLocation;
        /* 0x58 */ public GcVehicleWeaponMuzzleData MuzzleData;
        /* 0x78 */ public GcAudioWwiseEvents StartFireAudioEvent;
        /* 0x7C */ public GcAudioWwiseEvents StopFireAudioEvent;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD34E85AF0D1C9296, NameHash = 0x7652773CA720B160)]
    public class GcDroneWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 Projectile;
        /* 0x20 */ public int NumProjectiles;
        /* 0x24 */ public float ProjectileSpread;
        /* 0x28 */ public float FireRate;
        /* 0x2C */ public bool ChangeBarrelEachShot;
        /* 0x30 */ public float Timeout;
        /* 0x34 */ public int NumShotsMin;
        /* 0x38 */ public int NumShotsMax;
        /* 0x3C */ public float FireTimeMin;
        /* 0x40 */ public float FireTimeMax;
        /* 0x44 */ public float Range;
        /* 0x48 */ public float ExplosionRadius;
        /* 0x4C */ public float InheritInitialVelocity;
        /* 0x50 */ public float MoveDistanceMin;
        /* 0x54 */ public float MoveDistanceMax;
    }
}

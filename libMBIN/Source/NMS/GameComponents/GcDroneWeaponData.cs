namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16F8728F6FC68AAF, NameHash = 0x7652773CA720B160)]
    public class GcDroneWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 Projectile;
        /* 0x20 */ public float ExplosionRadius;
        /* 0x24 */ public float FireRate;
        /* 0x28 */ public float FireTimeMax;
        /* 0x2C */ public float FireTimeMin;
        /* 0x30 */ public float InheritInitialVelocity;
        /* 0x34 */ public float MoveDistanceMax;
        /* 0x38 */ public float MoveDistanceMin;
        /* 0x3C */ public int NumProjectiles;
        /* 0x40 */ public int NumShotsMax;
        /* 0x44 */ public int NumShotsMin;
        /* 0x48 */ public float ProjectileSpread;
        /* 0x4C */ public float Range;
        /* 0x50 */ public float Timeout;
        /* 0x54 */ public bool ChangeBarrelEachShot;
    }
}

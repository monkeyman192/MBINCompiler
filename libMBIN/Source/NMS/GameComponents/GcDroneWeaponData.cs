namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59E0744208C138FB, NameHash = 0x30534135)]
    public class GcDroneWeaponData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Projectile;
        [NMS(Index = 12)]
        /* 0x20 */ public float ExplosionRadius;
        [NMS(Index = 4)]
        /* 0x24 */ public float FireRate;
        [NMS(Index = 10)]
        /* 0x28 */ public float FireTimeMax;
        [NMS(Index = 9)]
        /* 0x2C */ public float FireTimeMin;
        [NMS(Index = 13)]
        /* 0x30 */ public float InheritInitialVelocity;
        [NMS(Index = 15)]
        /* 0x34 */ public float MoveDistanceMax;
        [NMS(Index = 14)]
        /* 0x38 */ public float MoveDistanceMin;
        [NMS(Index = 2)]
        /* 0x3C */ public int NumProjectiles;
        [NMS(Index = 8)]
        /* 0x40 */ public int NumShotsMax;
        [NMS(Index = 7)]
        /* 0x44 */ public int NumShotsMin;
        [NMS(Index = 3)]
        /* 0x48 */ public float ProjectileSpread;
        [NMS(Index = 11)]
        /* 0x4C */ public float Range;
        [NMS(Index = 6)]
        /* 0x50 */ public float Timeout;
        [NMS(Index = 5)]
        /* 0x54 */ public bool ChangeBarrelEachShot;
    }
}

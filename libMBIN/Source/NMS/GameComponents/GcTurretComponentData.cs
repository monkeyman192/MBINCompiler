namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9411927715FC9B8E, NameHash = 0x88530A815E5B1B46)]
    public class GcTurretComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LaserEffectId;
        /* 0x10 */ public NMSString0x10 LaserMuzzleChargeId;
        /* 0x20 */ public NMSString0x10 LaserMuzzleFlashId;
        /* 0x30 */ public NMSString0x10 MissileId;
        /* 0x40 */ public NMSString0x10 ProjectileId;
        /* 0x50 */ public NMSString0x10 ProjectileMuzzleFlashId;
        /* 0x60 */ public float BaseRotationAngleThreshold;
        // size: 0x3
        public enum GunTypeEnum : uint {
            Laser,
            Projectile,
            Missile,
        }
        /* 0x64 */ public GunTypeEnum GunType;
        /* 0x68 */ public float LevelledBurstCountExtra;
        /* 0x6C */ public float LevelledBurstTimeMultiplier;
        // size: 0x3
        public enum TargetFilterEnum : uint {
            Any,
            FreightersOnly,
            SmallShipsOnly,
        }
        /* 0x70 */ public TargetFilterEnum TargetFilter;
        /* 0x74 */ public float TurrentLaserShootTimeRandomExtraMax;
        /* 0x78 */ public float TurretAimOffset;
        /* 0x7C */ public float TurretAngle;
        /* 0x80 */ public int TurretBurstCount;
        /* 0x84 */ public float TurretBurstTime;
        /* 0x88 */ public float TurretDispersionAngle;
        /* 0x8C */ public float TurretLaserAbortDistance;
        /* 0x90 */ public float TurretLaserActiveTime;
        /* 0x94 */ public float TurretLaserChargeTime;
        /* 0x98 */ public float TurretLaserLength;
        /* 0x9C */ public float TurretLaserMoveSpeed;
        /* 0xA0 */ public float TurretLaserShootTime;
        /* 0xA4 */ public float TurretMaxDownAngle;
        /* 0xA8 */ public float TurretMaxPitchTurnSpeedDegPerSec;
        /* 0xAC */ public float TurretMaxYawTurnSpeedDegPerSec;
        /* 0xB0 */ public float TurretMissileLaunchSpeed;
        /* 0xB4 */ public float TurretMissileLaunchTime;
        /* 0xB8 */ public float TurretMissileRange;
        /* 0xBC */ public float TurretPitchSmoothTurnTime;
        /* 0xC0 */ public float TurretProjectileRange;
        /* 0xC4 */ public float TurretRange;
        /* 0xC8 */ public float TurretShootPauseTime;
        /* 0xCC */ public float TurretYawSmoothTurnTime;
        /* 0xD0 */ public bool CanMoveDuringBurst;
        /* 0xD1 */ public bool FireInTurretFacing;
        /* 0xD2 */ public bool HasFreighterAlertLight;
        /* 0xD3 */ public bool RemotePlayersCanDamage;
    }
}

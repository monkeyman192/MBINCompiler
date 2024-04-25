namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9411927715FC9B8E, NameHash = 0x88530A815E5B1B46)]
    public class GcTurretComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 LaserEffectId;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 LaserMuzzleChargeId;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 LaserMuzzleFlashId;
        [NMS(Index = 6)]
        /* 0x30 */ public NMSString0x10 MissileId;
        [NMS(Index = 4)]
        /* 0x40 */ public NMSString0x10 ProjectileId;
        [NMS(Index = 5)]
        /* 0x50 */ public NMSString0x10 ProjectileMuzzleFlashId;
        [NMS(Index = 37)]
        /* 0x60 */ public float BaseRotationAngleThreshold;
        // size: 0x3
        public enum GunTypeEnum : uint {
            Laser,
            Projectile,
            Missile,
        }
        [NMS(Index = 0)]
        /* 0x64 */ public GunTypeEnum GunType;
        [NMS(Index = 19)]
        /* 0x68 */ public float LevelledBurstCountExtra;
        [NMS(Index = 20)]
        /* 0x6C */ public float LevelledBurstTimeMultiplier;
        // size: 0x3
        public enum TargetFilterEnum : uint {
            Any,
            FreightersOnly,
            SmallShipsOnly,
        }
        [NMS(Index = 36)]
        /* 0x70 */ public TargetFilterEnum TargetFilter;
        [NMS(Index = 15)]
        /* 0x74 */ public float TurrentLaserShootTimeRandomExtraMax;
        [NMS(Index = 35)]
        /* 0x78 */ public float TurretAimOffset;
        [NMS(Index = 28)]
        /* 0x7C */ public float TurretAngle;
        [NMS(Index = 17)]
        /* 0x80 */ public int TurretBurstCount;
        [NMS(Index = 18)]
        /* 0x84 */ public float TurretBurstTime;
        [NMS(Index = 31)]
        /* 0x88 */ public float TurretDispersionAngle;
        [NMS(Index = 14)]
        /* 0x8C */ public float TurretLaserAbortDistance;
        [NMS(Index = 12)]
        /* 0x90 */ public float TurretLaserActiveTime;
        [NMS(Index = 13)]
        /* 0x94 */ public float TurretLaserChargeTime;
        [NMS(Index = 10)]
        /* 0x98 */ public float TurretLaserLength;
        [NMS(Index = 11)]
        /* 0x9C */ public float TurretLaserMoveSpeed;
        [NMS(Index = 9)]
        /* 0xA0 */ public float TurretLaserShootTime;
        [NMS(Index = 23)]
        /* 0xA4 */ public float TurretMaxDownAngle;
        [NMS(Index = 25)]
        /* 0xA8 */ public float TurretMaxPitchTurnSpeedDegPerSec;
        [NMS(Index = 24)]
        /* 0xAC */ public float TurretMaxYawTurnSpeedDegPerSec;
        [NMS(Index = 22)]
        /* 0xB0 */ public float TurretMissileLaunchSpeed;
        [NMS(Index = 21)]
        /* 0xB4 */ public float TurretMissileLaunchTime;
        [NMS(Index = 30)]
        /* 0xB8 */ public float TurretMissileRange;
        [NMS(Index = 27)]
        /* 0xBC */ public float TurretPitchSmoothTurnTime;
        [NMS(Index = 29)]
        /* 0xC0 */ public float TurretProjectileRange;
        [NMS(Index = 8)]
        /* 0xC4 */ public float TurretRange;
        [NMS(Index = 16)]
        /* 0xC8 */ public float TurretShootPauseTime;
        [NMS(Index = 26)]
        /* 0xCC */ public float TurretYawSmoothTurnTime;
        [NMS(Index = 33)]
        /* 0xD0 */ public bool CanMoveDuringBurst;
        [NMS(Index = 34)]
        /* 0xD1 */ public bool FireInTurretFacing;
        [NMS(Index = 7)]
        /* 0xD2 */ public bool HasFreighterAlertLight;
        [NMS(Index = 32)]
        /* 0xD3 */ public bool RemotePlayersCanDamage;
    }
}

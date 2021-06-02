using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB0, GUID = 0x9D323B47AF6E4A7F, NameHash = 0x88530A815E5B1B46)]
    public class GcTurretComponentData : NMSTemplate
    {
		public enum GunTypeEnum { Laser, Projectile, Missile }
		/* 0x00 */ public GunTypeEnum GunType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public NMSString0x10 LaserEffectId;
        /* 0x18 */ public NMSString0x10 LaserMuzzleFlashId;
        /* 0x28 */ public NMSString0x10 ProjectileId;
        /* 0x38 */ public NMSString0x10 ProjectileMuzzleFlashId;
        /* 0x48 */ public NMSString0x10 MissileId;
        /* 0x58 */ public bool HasFreighterAlertLight;
        /* 0x5C */ public float TurretRange;
        /* 0x60 */ public float TurretLaserShootTime;
        /* 0x64 */ public float TurretLaserLength;
        /* 0x68 */ public float TurretLaserMoveSpeed;
        /* 0x6C */ public float TurretLaserActiveTime;
        /* 0x70 */ public float TurretLaserAbortDistance;
        /* 0x74 */ public float TurretShootPauseTime;
        /* 0x78 */ public int TurretBurstCount;
        /* 0x7C */ public float TurretBurstTime;
        /* 0x80 */ public float TurretMissileLaunchTime;
        /* 0x84 */ public float TurretMissileLaunchSpeed;
        /* 0x88 */ public float TurretMaxDownAngle;
        /* 0x8C */ public float TurretSlerpFactor;
        /* 0x90 */ public float TurretAngle;
        /* 0x94 */ public float TurretProjectileRange;
        /* 0x98 */ public float TurretMissileRange;
        /* 0x9C */ public float TurretDispersionAngle;
        /* 0xA0 */ public bool RemotePlayersCanDamage;
        /* 0xA1 */ public bool CanMoveDuringBurst;
        /* 0xA2 */ public bool FireInTurretFacing;
        /* 0xA4 */ public float TurretSearchAngle;
        /* 0xA8 */ public float TurretSearchTime;
        /* 0xAC */ public float TurretAimOffset;
    }
}

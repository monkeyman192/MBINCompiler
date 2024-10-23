namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x70D09F375F37EEB9, NameHash = 0xE6052335)]
    public class GcCreatureJellyBossAttackData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public NMSString0x10 BroodSpawnID;
        [NMS(Index = 18)]
        /* 0x10 */ public NMSString0x10 OrbAttackProjectile;
        [NMS(Index = 15)]
        /* 0x20 */ public Vector2f OrbAttackCooldownRange;
        [NMS(Index = 9)]
        /* 0x28 */ public Vector2f SpawnBroodCooldownRange;
        [NMS(Index = 22)]
        /* 0x30 */ public float DelayBetweenOrbAttacks;
        [NMS(Index = 2)]
        /* 0x34 */ public float FadeInTime;
        [NMS(Index = 12)]
        /* 0x38 */ public int MaxBroodCountPreventSpawn;
        [NMS(Index = 5)]
        /* 0x3C */ public float MaxIdleRange;
        [NMS(Index = 4)]
        /* 0x40 */ public float MinIdleRange;
        [NMS(Index = 3)]
        /* 0x44 */ public float MinWaterDepth;
        [NMS(Index = 17)]
        /* 0x48 */ public int OrbAttackCount;
        [NMS(Index = 21)]
        /* 0x4C */ public float OrbAttackExplosionRadius;
        [NMS(Index = 20)]
        /* 0x50 */ public float OrbAttackLaunchSpeed;
        [NMS(Index = 14)]
        /* 0x54 */ public float OrbAttackPauseTime;
        [NMS(Index = 16)]
        /* 0x58 */ public float OrbAttackPickWeight;
        [NMS(Index = 19)]
        /* 0x5C */ public int OrbAttackProjectileCount;
        [NMS(Index = 11)]
        /* 0x60 */ public int SpawnBroodCount;
        [NMS(Index = 8)]
        /* 0x64 */ public float SpawnBroodPauseTime;
        [NMS(Index = 10)]
        /* 0x68 */ public float SpawnBroodPickWeight;
        [NMS(Index = 13)]
        /* 0x6C */ public bool CanOrbAttack;
        [NMS(Index = 6)]
        /* 0x6D */ public bool CanSpawnBrood;
        [NMS(Index = 0)]
        /* 0x6E */ public bool ExplodeOnPlayer;
        [NMS(Index = 1)]
        /* 0x6F */ public bool IsSpooky;
    }
}

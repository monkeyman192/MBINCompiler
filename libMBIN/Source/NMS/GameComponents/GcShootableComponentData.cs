using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD738ADAA47F952A5, NameHash = 0x77F1C814)]
    public class GcShootableComponentData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcProjectileImpactData ImpactOverrideData;
        [NMS(Index = 26)]
        /* 0x20 */ public NMSString0x10 DamageMultiplier;
        [NMS(Index = 7)]
        /* 0x30 */ public NMSString0x10 ImpactShakeEffect;
        [NMS(Index = 25)]
        /* 0x40 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 14)]
        /* 0x50 */ public float FiendCrimeModifier;
        [NMS(Index = 13)]
        /* 0x54 */ public GcFiendCrime FiendCrimeType;
        [NMS(Index = 8)]
        /* 0x58 */ public GcProjectileImpactType ForceImpactType;
        [NMS(Index = 0)]
        /* 0x5C */ public int Health;
        [NMS(Index = 11)]
        /* 0x60 */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 10)]
        /* 0x64 */ public int IncreaseWanted;
        [NMS(Index = 12)]
        /* 0x68 */ public float IncreaseWantedThresholdTime;
        [NMS(Index = 1)]
        /* 0x6C */ public int LevelledExtraHealth;
        [NMS(Index = 16)]
        /* 0x70 */ public int MinDamage;
        [NMS(Index = 15)]
        /* 0x74 */ public float RepairTime;
        [NMS(Index = 24)]
        /* 0x78 */ public NMSString0x20 NameOverride;
        [NMS(Index = 3)]
        /* 0x98 */ public bool AutoAimTarget;
        [NMS(Index = 22)]
        /* 0x99 */ public bool CouldCountAsArmourForParent;
        [NMS(Index = 19)]
        /* 0x9A */ public bool HitEffectEnabled;
        [NMS(Index = 20)]
        /* 0x9B */ public bool HitEffectEntireModel;
        [NMS(Index = 18)]
        /* 0x9C */ public bool IgnoreHitPush;
        [NMS(Index = 5)]
        /* 0x9D */ public bool IgnorePlayer;
        [NMS(Index = 23)]
        /* 0x9E */ public bool IgnoreTerrainEditKills;
        [NMS(Index = 6)]
        /* 0x9F */ public bool ImpactShake;
        [NMS(Index = 28)]
        /* 0xA0 */ public bool IsAffectedByPiercing;
        [NMS(Index = 21)]
        /* 0xA1 */ public bool IsArmoured;
        [NMS(Index = 27)]
        /* 0xA2 */ public bool IsPiercable;
        [NMS(Index = 4)]
        /* 0xA3 */ public bool PlayerOnly;
        [NMS(Index = 17)]
        /* 0xA4 */ public bool StaticUntilShot;
        [NMS(Index = 2)]
        /* 0xA5 */ public bool UseSpaceLevelForExtraHealth;
    }
}

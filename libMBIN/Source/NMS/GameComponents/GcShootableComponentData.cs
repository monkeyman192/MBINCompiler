using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD94984CEBE9D360E, NameHash = 0x77F1C814)]
    public class GcShootableComponentData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcProjectileImpactData ImpactOverrideData;
        [NMS(Index = 30)]
        /* 0x20 */ public NMSString0x10 DamageMultiplier;
        [NMS(Index = 7)]
        /* 0x30 */ public NMSString0x10 ImpactShakeEffect;
        [NMS(Index = 29)]
        /* 0x40 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 22)]
        /* 0x50 */ public float CapHealthForMissingArmour;
        [NMS(Index = 14)]
        /* 0x54 */ public float FiendCrimeModifier;
        [NMS(Index = 13)]
        /* 0x58 */ public GcFiendCrime FiendCrimeType;
        [NMS(Index = 8)]
        /* 0x5C */ public GcProjectileImpactType ForceImpactType;
        [NMS(Index = 0)]
        /* 0x60 */ public int Health;
        [NMS(Index = 11)]
        /* 0x64 */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 10)]
        /* 0x68 */ public int IncreaseWanted;
        [NMS(Index = 12)]
        /* 0x6C */ public float IncreaseWantedThresholdTime;
        [NMS(Index = 1)]
        /* 0x70 */ public int LevelledExtraHealth;
        [NMS(Index = 16)]
        /* 0x74 */ public int MinDamage;
        [NMS(Index = 15)]
        /* 0x78 */ public float RepairTime;
        [NMS(Index = 28)]
        /* 0x7C */ public NMSString0x20 NameOverride;
        [NMS(Index = 3)]
        /* 0x9C */ public bool AutoAimTarget;
        [NMS(Index = 26)]
        /* 0x9D */ public bool CopyDamageMultiplierChangesFromParent;
        [NMS(Index = 23)]
        /* 0x9E */ public bool CouldCountAsArmourForParent;
        [NMS(Index = 25)]
        /* 0x9F */ public bool CouldCountAsWeakPointForParent;
        [NMS(Index = 24)]
        /* 0xA0 */ public bool HasWeakPoints;
        [NMS(Index = 19)]
        /* 0xA1 */ public bool HitEffectEnabled;
        [NMS(Index = 20)]
        /* 0xA2 */ public bool HitEffectEntireModel;
        [NMS(Index = 18)]
        /* 0xA3 */ public bool IgnoreHitPush;
        [NMS(Index = 5)]
        /* 0xA4 */ public bool IgnorePlayer;
        [NMS(Index = 27)]
        /* 0xA5 */ public bool IgnoreTerrainEditKills;
        [NMS(Index = 6)]
        /* 0xA6 */ public bool ImpactShake;
        [NMS(Index = 32)]
        /* 0xA7 */ public bool IsAffectedByPiercing;
        [NMS(Index = 21)]
        /* 0xA8 */ public bool IsArmoured;
        [NMS(Index = 31)]
        /* 0xA9 */ public bool IsPiercable;
        [NMS(Index = 4)]
        /* 0xAA */ public bool PlayerOnly;
        [NMS(Index = 17)]
        /* 0xAB */ public bool StaticUntilShot;
        [NMS(Index = 2)]
        /* 0xAC */ public bool UseSpaceLevelForExtraHealth;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC141908707421651, NameHash = 0x387AC5FC8E642A15)]
    public class GcShootableComponentData : NMSTemplate
    {
        [NMS(Index = 25)]
        /* 0x00 */ public NMSString0x10 DamageMultiplier;
        [NMS(Index = 7)]
        /* 0x10 */ public NMSString0x10 ImpactShakeEffect;
        [NMS(Index = 24)]
        /* 0x20 */ public NMSString0x10 RequiredTech;
        [NMS(Index = 13)]
        /* 0x30 */ public float FiendCrimeModifier;
        [NMS(Index = 12)]
        /* 0x34 */ public GcFiendCrime FiendCrimeType;
        [NMS(Index = 8)]
        /* 0x38 */ public GcProjectileImpactType ForceImpactType;
        [NMS(Index = 0)]
        /* 0x3C */ public int Health;
        [NMS(Index = 10)]
        /* 0x40 */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 9)]
        /* 0x44 */ public int IncreaseWanted;
        [NMS(Index = 11)]
        /* 0x48 */ public float IncreaseWantedThresholdTime;
        [NMS(Index = 1)]
        /* 0x4C */ public int LevelledExtraHealth;
        [NMS(Index = 15)]
        /* 0x50 */ public int MinDamage;
        [NMS(Index = 14)]
        /* 0x54 */ public float RepairTime;
        [NMS(Index = 23)]
        /* 0x58 */ public NMSString0x20 NameOverride;
        [NMS(Index = 3)]
        /* 0x78 */ public bool AutoAimTarget;
        [NMS(Index = 21)]
        /* 0x79 */ public bool CouldCountAsArmourForParent;
        [NMS(Index = 18)]
        /* 0x7A */ public bool HitEffectEnabled;
        [NMS(Index = 19)]
        /* 0x7B */ public bool HitEffectEntireModel;
        [NMS(Index = 17)]
        /* 0x7C */ public bool IgnoreHitPush;
        [NMS(Index = 5)]
        /* 0x7D */ public bool IgnorePlayer;
        [NMS(Index = 22)]
        /* 0x7E */ public bool IgnoreTerrainEditKills;
        [NMS(Index = 6)]
        /* 0x7F */ public bool ImpactShake;
        [NMS(Index = 27)]
        /* 0x80 */ public bool IsAffectedByPiercing;
        [NMS(Index = 20)]
        /* 0x81 */ public bool IsArmoured;
        [NMS(Index = 26)]
        /* 0x82 */ public bool IsPiercable;
        [NMS(Index = 4)]
        /* 0x83 */ public bool PlayerOnly;
        [NMS(Index = 16)]
        /* 0x84 */ public bool StaticUntilShot;
        [NMS(Index = 2)]
        /* 0x85 */ public bool UseSpaceLevelForExtraHealth;
    }
}

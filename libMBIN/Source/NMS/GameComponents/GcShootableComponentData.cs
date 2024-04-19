using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC141908707421651, NameHash = 0x387AC5FC8E642A15)]
    public class GcShootableComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DamageMultiplier;
        /* 0x10 */ public NMSString0x10 ImpactShakeEffect;
        /* 0x20 */ public NMSString0x10 RequiredTech;
        /* 0x30 */ public float FiendCrimeModifier;
        /* 0x34 */ public GcFiendCrime FiendCrimeType;
        /* 0x38 */ public GcProjectileImpactType ForceImpactType;
        /* 0x3C */ public int Health;
        /* 0x40 */ public int IncreaseCorruptSentinelWanted;
        /* 0x44 */ public int IncreaseWanted;
        /* 0x48 */ public float IncreaseWantedThresholdTime;
        /* 0x4C */ public int LevelledExtraHealth;
        /* 0x50 */ public int MinDamage;
        /* 0x54 */ public float RepairTime;
        /* 0x58 */ public NMSString0x20 NameOverride;
        /* 0x78 */ public bool AutoAimTarget;
        /* 0x79 */ public bool CouldCountAsArmourForParent;
        /* 0x7A */ public bool HitEffectEnabled;
        /* 0x7B */ public bool HitEffectEntireModel;
        /* 0x7C */ public bool IgnoreHitPush;
        /* 0x7D */ public bool IgnorePlayer;
        /* 0x7E */ public bool IgnoreTerrainEditKills;
        /* 0x7F */ public bool ImpactShake;
        /* 0x80 */ public bool IsAffectedByPiercing;
        /* 0x81 */ public bool IsArmoured;
        /* 0x82 */ public bool IsPiercable;
        /* 0x83 */ public bool PlayerOnly;
        /* 0x84 */ public bool StaticUntilShot;
        /* 0x85 */ public bool UseSpaceLevelForExtraHealth;
    }
}

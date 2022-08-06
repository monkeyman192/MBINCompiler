using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x086FCB52AB4EF505, NameHash = 0x387AC5FC8E642A15)]
    public class GcShootableComponentData : NMSTemplate
    {
        /* 0x00 */ public int Health;
        /* 0x04 */ public bool AutoAimTarget;
        /* 0x05 */ public bool PlayerOnly;
        /* 0x06 */ public bool IgnorePlayer;
        /* 0x07 */ public bool ImpactShake;
        /* 0x08 */ public NMSString0x10 ImpactShakeEffect;
        /* 0x18 */ public GcProjectileImpactType ForceImpactType;
        /* 0x1C */ public int IncreaseWanted;
        /* 0x20 */ public float IncreaseWantedThresholdTime;
        /* 0x24 */ public GcFiendCrime FiendCrimeType;
        /* 0x28 */ public float FiendCrimeModifier;
        /* 0x2C */ public float RepairTime;
        /* 0x30 */ public int MinDamage;
        /* 0x34 */ public bool StaticUntilShot;
        /* 0x35 */ public bool IgnoreHitPush;
        /* 0x36 */ public bool HitEffectEnabled;
        /* 0x37 */ public bool HitEffectEntireModel;
        /* 0x38 */ public bool IsArmoured;
        /* 0x39 */ public bool CouldCountAsArmourForParent;
        /* 0x3A */ public bool IgnoreTerrainEditKills;
        /* 0x3B */ public NMSString0x20 NameOverride;
        /* 0x60 */ public NMSString0x10 RequiredTech;
        /* 0x70 */ public NMSString0x10 DamageMultiplier;
        /* 0x80 */ public bool IsPiercable;
        /* 0x81 */ public bool IsAffectedByPiercing;
    }
}

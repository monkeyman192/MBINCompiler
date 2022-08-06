using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC91A60F1E9F7E02, NameHash = 0x1AA966F8BA4E3153)]
    public class GcLaserBeamData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x80 BeamFile;
        /* 0x090 */ public NMSString0x80 BeamCoreFile;
        /* 0x110 */ public float Width;
        /* 0x114 */ public float HitWidth;
        /* 0x118 */ public float PulseFrequency;
        /* 0x11C */ public float PulseAmplitude;
        /* 0x120 */ public float StartTime;
        /* 0x124 */ public float EndTime;
        /* 0x128 */ public GcAudioWwiseEvents AudioStart;
        /* 0x12C */ public GcAudioWwiseEvents AudioStop;
        /* 0x130 */ public GcAudioWwiseEvents AudioOverheat;
        /* 0x134 */ public int DefaultDamage;
        /* 0x138 */ public float ExtraPlayerDamage;
        /* 0x13C */ public GcDamageType DamageType;
        /* 0x140 */ public float CriticalHitModifier;
        /* 0x148 */ public NMSString0x10 PlayerDamage;
        /* 0x158 */ public NMSString0x10 ImpactEffect;
        /* 0x168 */ public List<GcProjectileImpactData> Impacts;
        /* 0x178 */ public float HitRate;
        /* 0x17C */ public bool SingleHit;
        /* 0x180 */ public float RagdollPush;
        /* 0x184 */ public float PhysicsPush;
        /* 0x188 */ public float MiningHitRate;
        /* 0x18C */ public bool HasLight;
        /* 0x18D */ public bool CanMine;
        /* 0x18E */ public bool ApplyCombatLevelMultipliers;
        /* 0x190 */ public float DroneImpulse;
        /* 0x194 */ public float PiercingDamagePercentage;
        /* 0x198 */ public float LightIntensity;
        /* 0x1A0 */ public Colour LightColour;
        /* 0x1B0 */ public Colour Colour;
        /* 0x1C0 */ public Vector3f ImpactOffset;
        /* 0x1D0 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        /* 0x1E0 */ public List<GcCombatEffectDamageMultiplier> CombatEffectDamageMultipliers;
    }
}

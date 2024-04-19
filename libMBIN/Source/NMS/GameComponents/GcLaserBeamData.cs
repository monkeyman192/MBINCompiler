using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64CF78479D25D87B, NameHash = 0x1AA966F8BA4E3153)]
    public class GcLaserBeamData : NMSTemplate
    {
        /* 0x000 */ public Colour Colour;
        /* 0x010 */ public Vector3f ImpactOffset;
        /* 0x020 */ public Colour LightColour;
        /* 0x030 */ public List<GcCombatEffectDamageMultiplier> CombatEffectDamageMultipliers;
        /* 0x040 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        /* 0x050 */ public NMSString0x10 Id;
        /* 0x060 */ public NMSString0x10 ImpactEffect;
        /* 0x070 */ public List<GcProjectileImpactData> Impacts;
        /* 0x080 */ public NMSString0x10 PlayerDamage;
        /* 0x090 */ public GcAudioWwiseEvents AudioOverheat;
        /* 0x094 */ public GcAudioWwiseEvents AudioStart;
        /* 0x098 */ public GcAudioWwiseEvents AudioStop;
        /* 0x09C */ public float CriticalHitModifier;
        /* 0x0A0 */ public GcDamageType DamageType;
        /* 0x0A4 */ public int DefaultDamage;
        /* 0x0A8 */ public float DroneImpulse;
        /* 0x0AC */ public float EndTime;
        /* 0x0B0 */ public float ExtraPlayerDamage;
        /* 0x0B4 */ public float HitRate;
        /* 0x0B8 */ public float HitWidth;
        /* 0x0BC */ public float LightIntensity;
        /* 0x0C0 */ public float MiningHitRate;
        /* 0x0C4 */ public float PhysicsPush;
        /* 0x0C8 */ public float PiercingDamagePercentage;
        /* 0x0CC */ public float PulseAmplitude;
        /* 0x0D0 */ public float PulseFrequency;
        /* 0x0D4 */ public float RagdollPush;
        /* 0x0D8 */ public float Speed;
        /* 0x0DC */ public float StartTime;
        /* 0x0E0 */ public float Width;
        /* 0x0E4 */ public NMSString0x80 BeamCoreFile;
        /* 0x164 */ public NMSString0x80 BeamFile;
        /* 0x1E4 */ public NMSString0x80 BeamTipFile;
        /* 0x264 */ public bool ApplyCombatLevelMultipliers;
        /* 0x265 */ public bool CanMine;
        /* 0x266 */ public bool HasLight;
        /* 0x267 */ public bool SingleHit;
    }
}

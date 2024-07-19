using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE454F772069E74E8, NameHash = 0xFD1E1F96)]
    public class GcLaserBeamData : NMSTemplate
    {
        [NMS(Index = 32)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 33)]
        /* 0x010 */ public Vector3f ImpactOffset;
        [NMS(Index = 31)]
        /* 0x020 */ public Colour LightColour;
        [NMS(Index = 2)]
        /* 0x030 */ public VariableSizeString BeamCoreFile;
        [NMS(Index = 1)]
        /* 0x040 */ public VariableSizeString BeamFile;
        [NMS(Index = 3)]
        /* 0x050 */ public VariableSizeString BeamTipFile;
        [NMS(Index = 35)]
        /* 0x060 */ public List<GcCombatEffectDamageMultiplier> CombatEffectDamageMultipliers;
        [NMS(Index = 34)]
        /* 0x070 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        [NMS(Index = 0)]
        /* 0x080 */ public NMSString0x10 Id;
        [NMS(Index = 18)]
        /* 0x090 */ public NMSString0x10 ImpactEffect;
        [NMS(Index = 19)]
        /* 0x0A0 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Index = 17)]
        /* 0x0B0 */ public NMSString0x10 PlayerDamage;
        [NMS(Index = 12)]
        /* 0x0C0 */ public GcAudioWwiseEvents AudioOverheat;
        [NMS(Index = 10)]
        /* 0x0C4 */ public GcAudioWwiseEvents AudioStart;
        [NMS(Index = 11)]
        /* 0x0C8 */ public GcAudioWwiseEvents AudioStop;
        [NMS(Index = 16)]
        /* 0x0CC */ public float CriticalHitModifier;
        [NMS(Index = 15)]
        /* 0x0D0 */ public GcDamageType DamageType;
        [NMS(Index = 13)]
        /* 0x0D4 */ public int DefaultDamage;
        [NMS(Index = 28)]
        /* 0x0D8 */ public float DroneImpulse;
        [NMS(Index = 9)]
        /* 0x0DC */ public float EndTime;
        [NMS(Index = 14)]
        /* 0x0E0 */ public float ExtraPlayerDamage;
        [NMS(Index = 20)]
        /* 0x0E4 */ public float HitRate;
        [NMS(Index = 5)]
        /* 0x0E8 */ public float HitWidth;
        [NMS(Index = 30)]
        /* 0x0EC */ public float LightIntensity;
        [NMS(Index = 24)]
        /* 0x0F0 */ public float MiningHitRate;
        [NMS(Index = 23)]
        /* 0x0F4 */ public float PhysicsPush;
        [NMS(Index = 29)]
        /* 0x0F8 */ public float PiercingDamagePercentage;
        [NMS(Index = 7)]
        /* 0x0FC */ public float PulseAmplitude;
        [NMS(Index = 6)]
        /* 0x100 */ public float PulseFrequency;
        [NMS(Index = 22)]
        /* 0x104 */ public float RagdollPush;
        [NMS(Index = 36)]
        /* 0x108 */ public float Speed;
        [NMS(Index = 8)]
        /* 0x10C */ public float StartTime;
        [NMS(Index = 4)]
        /* 0x110 */ public float Width;
        [NMS(Index = 27)]
        /* 0x114 */ public bool ApplyCombatLevelMultipliers;
        [NMS(Index = 26)]
        /* 0x115 */ public bool CanMine;
        [NMS(Index = 25)]
        /* 0x116 */ public bool HasLight;
        [NMS(Index = 21)]
        /* 0x117 */ public bool SingleHit;
    }
}

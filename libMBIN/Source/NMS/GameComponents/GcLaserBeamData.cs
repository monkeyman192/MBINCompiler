using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x787AD7D04851995, NameHash = 0x1AA966F8BA4E3153)]
    public class GcLaserBeamData : NMSTemplate
    {
        [NMS(Index = 32)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 33)]
        /* 0x010 */ public Vector3f ImpactOffset;
        [NMS(Index = 31)]
        /* 0x020 */ public Colour LightColour;
        [NMS(Index = 35)]
        /* 0x030 */ public List<GcCombatEffectDamageMultiplier> CombatEffectDamageMultipliers;
        [NMS(Index = 34)]
        /* 0x040 */ public List<GcImpactCombatEffectData> CombatEffectsOnImpact;
        [NMS(Index = 0)]
        /* 0x050 */ public NMSString0x10 Id;
        [NMS(Index = 18)]
        /* 0x060 */ public NMSString0x10 ImpactEffect;
        [NMS(Index = 19)]
        /* 0x070 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Index = 17)]
        /* 0x080 */ public NMSString0x10 PlayerDamage;
        [NMS(Index = 12)]
        /* 0x090 */ public GcAudioWwiseEvents AudioOverheat;
        [NMS(Index = 10)]
        /* 0x094 */ public GcAudioWwiseEvents AudioStart;
        [NMS(Index = 11)]
        /* 0x098 */ public GcAudioWwiseEvents AudioStop;
        [NMS(Index = 16)]
        /* 0x09C */ public float CriticalHitModifier;
        [NMS(Index = 15)]
        /* 0x0A0 */ public GcDamageType DamageType;
        [NMS(Index = 13)]
        /* 0x0A4 */ public int DefaultDamage;
        [NMS(Index = 28)]
        /* 0x0A8 */ public float DroneImpulse;
        [NMS(Index = 9)]
        /* 0x0AC */ public float EndTime;
        [NMS(Index = 14)]
        /* 0x0B0 */ public float ExtraPlayerDamage;
        [NMS(Index = 20)]
        /* 0x0B4 */ public float HitRate;
        [NMS(Index = 5)]
        /* 0x0B8 */ public float HitWidth;
        [NMS(Index = 30)]
        /* 0x0BC */ public float LightIntensity;
        [NMS(Index = 24)]
        /* 0x0C0 */ public float MiningHitRate;
        [NMS(Index = 23)]
        /* 0x0C4 */ public float PhysicsPush;
        [NMS(Index = 29)]
        /* 0x0C8 */ public float PiercingDamagePercentage;
        [NMS(Index = 7)]
        /* 0x0CC */ public float PulseAmplitude;
        [NMS(Index = 6)]
        /* 0x0D0 */ public float PulseFrequency;
        [NMS(Index = 22)]
        /* 0x0D4 */ public float RagdollPush;
        [NMS(Index = 36)]
        /* 0x0D8 */ public float Speed;
        [NMS(Index = 8)]
        /* 0x0DC */ public float StartTime;
        [NMS(Index = 4)]
        /* 0x0E0 */ public float Width;
        [NMS(Index = 2)]
        /* 0x0E4 */ public NMSString0x80 BeamCoreFile;
        [NMS(Index = 1)]
        /* 0x164 */ public NMSString0x80 BeamFile;
        [NMS(Index = 3)]
        /* 0x1E4 */ public NMSString0x80 BeamTipFile;
        [NMS(Index = 27)]
        /* 0x264 */ public bool ApplyCombatLevelMultipliers;
        [NMS(Index = 26)]
        /* 0x265 */ public bool CanMine;
        [NMS(Index = 25)]
        /* 0x266 */ public bool HasLight;
        [NMS(Index = 21)]
        /* 0x267 */ public bool SingleHit;
    }
}

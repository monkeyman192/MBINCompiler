using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47F64C18328AE3BF, NameHash = 0x419E50F8E497D496)]
    public class GcWeatherEffect : NMSTemplate
    {
        [NMS(Index = 40)]
        /* 0x000 */ public NMSTemplate EffectData;
        [NMS(Index = 1)]
        /* 0x050 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 6)]
        /* 0x070 */ public NMSString0x10 BlockedByCluster;
        [NMS(Index = 2)]
        /* 0x080 */ public List<GcWeightedFilename> Effects;
        [NMS(Index = 5)]
        /* 0x090 */ public NMSString0x10 ForcedOnByHazard;
        [NMS(Index = 0)]
        /* 0x0A0 */ public NMSString0x10 Id;
        [NMS(Index = 23)]
        /* 0x0B0 */ public GcAudioWwiseEvents Audio;
        [NMS(Index = 14)]
        /* 0x0B4 */ public float ChanceOfPlanetBeingExtreme;
        [NMS(Index = 28)]
        /* 0x0B8 */ public float ClusterMaxLifetime;
        [NMS(Index = 27)]
        /* 0x0BC */ public float ClusterMinLifetime;
        [NMS(Index = 26)]
        /* 0x0C0 */ public float ClusterSpawnChance;
        [NMS(Index = 20)]
        /* 0x0C4 */ public float FadeoutStart;
        [NMS(Index = 25)]
        /* 0x0C8 */ public float ImpactGiftChance;
        [NMS(Index = 4)]
        /* 0x0CC */ public int MaxHazardsOfThisTypeActive;
        [NMS(Index = 19)]
        /* 0x0D0 */ public float MaxLifetime;
        [NMS(Index = 17)]
        /* 0x0D4 */ public float MaxSpawnDistance;
        [NMS(Index = 11)]
        /* 0x0D8 */ public float MaxSpawnScale;
        [NMS(Index = 18)]
        /* 0x0DC */ public float MinLifetime;
        [NMS(Index = 16)]
        /* 0x0E0 */ public float MinSpawnDistance;
        [NMS(Index = 10)]
        /* 0x0E4 */ public float MinSpawnScale;
        [NMS(Index = 35)]
        /* 0x0E8 */ public float MoveSpeed;
        [NMS(Index = 31)]
        /* 0x0EC */ public float PatchMaxRadius;
        [NMS(Index = 33)]
        /* 0x0F0 */ public int PatchMaxSpawns;
        [NMS(Index = 29)]
        /* 0x0F4 */ public float PatchMaxTimeSpawnOffset;
        [NMS(Index = 30)]
        /* 0x0F8 */ public float PatchMinRadius;
        [NMS(Index = 32)]
        /* 0x0FC */ public int PatchMinSpawns;
        [NMS(Index = 34)]
        /* 0x100 */ public float PatchScaling;
        [NMS(Index = 12)]
        /* 0x104 */ public int SpawnAttemptsPerRegion;
        [NMS(Index = 15)]
        /* 0x108 */ public float SpawnChancePerSecondExtreme;
        [NMS(Index = 13)]
        /* 0x10C */ public float SpawnChancePerSecondPerAttempt;
        // size: 0x5
        public enum SpawnConditionsEnum : uint {
            Anytime,
            DuringStorm,
            AtNight,
            NotInStorm,
            AtNightNotInStorm,
        }
        [NMS(Index = 3)]
        /* 0x110 */ public SpawnConditionsEnum SpawnConditions;
        [NMS(Index = 39)]
        /* 0x114 */ public float WanderMaxArcDeg;
        [NMS(Index = 37)]
        /* 0x118 */ public float WanderMaxRadius;
        [NMS(Index = 38)]
        /* 0x11C */ public float WanderMinArcDeg;
        [NMS(Index = 36)]
        /* 0x120 */ public float WanderMinRadius;
        // size: 0x3
        public enum WeatherEffectBehaviourEnum : uint {
            Static,
            Wander,
            ChasePlayer,
        }
        [NMS(Index = 7)]
        /* 0x124 */ public WeatherEffectBehaviourEnum WeatherEffectBehaviour;
        // size: 0x3
        public enum WeatherEffectSpawnTypeEnum : uint {
            Single,
            Cluster,
            Patch,
        }
        [NMS(Index = 8)]
        /* 0x128 */ public WeatherEffectSpawnTypeEnum WeatherEffectSpawnType;
        [NMS(Index = 24)]
        /* 0x12C */ public NMSString0x80 ImpactGift;
        [NMS(Index = 22)]
        /* 0x1AC */ public bool FadeoutAudio;
        [NMS(Index = 21)]
        /* 0x1AD */ public bool FadeoutVisuals;
        [NMS(Index = 9)]
        /* 0x1AE */ public bool RandomRotationAroundUp;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52FB6EA52279B36, NameHash = 0xBCBC706D)]
    public class GcWeatherEffect : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x10 BlockedByCluster;
        [NMS(Index = 40)]
        /* 0x30 */ public NMSTemplate EffectData;
        [NMS(Index = 2)]
        /* 0x40 */ public List<GcWeightedFilename> Effects;
        [NMS(Index = 5)]
        /* 0x50 */ public NMSString0x10 ForcedOnByHazard;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x10 Id;
        [NMS(Index = 24)]
        /* 0x70 */ public VariableSizeString ImpactGift;
        [NMS(Index = 23)]
        /* 0x80 */ public GcAudioWwiseEvents Audio;
        [NMS(Index = 14)]
        /* 0x84 */ public float ChanceOfPlanetBeingExtreme;
        [NMS(Index = 28)]
        /* 0x88 */ public float ClusterMaxLifetime;
        [NMS(Index = 27)]
        /* 0x8C */ public float ClusterMinLifetime;
        [NMS(Index = 26)]
        /* 0x90 */ public float ClusterSpawnChance;
        [NMS(Index = 20)]
        /* 0x94 */ public float FadeoutStart;
        [NMS(Index = 25)]
        /* 0x98 */ public float ImpactGiftChance;
        [NMS(Index = 4)]
        /* 0x9C */ public int MaxHazardsOfThisTypeActive;
        [NMS(Index = 19)]
        /* 0xA0 */ public float MaxLifetime;
        [NMS(Index = 17)]
        /* 0xA4 */ public float MaxSpawnDistance;
        [NMS(Index = 11)]
        /* 0xA8 */ public float MaxSpawnScale;
        [NMS(Index = 18)]
        /* 0xAC */ public float MinLifetime;
        [NMS(Index = 16)]
        /* 0xB0 */ public float MinSpawnDistance;
        [NMS(Index = 10)]
        /* 0xB4 */ public float MinSpawnScale;
        [NMS(Index = 35)]
        /* 0xB8 */ public float MoveSpeed;
        [NMS(Index = 31)]
        /* 0xBC */ public float PatchMaxRadius;
        [NMS(Index = 33)]
        /* 0xC0 */ public int PatchMaxSpawns;
        [NMS(Index = 29)]
        /* 0xC4 */ public float PatchMaxTimeSpawnOffset;
        [NMS(Index = 30)]
        /* 0xC8 */ public float PatchMinRadius;
        [NMS(Index = 32)]
        /* 0xCC */ public int PatchMinSpawns;
        [NMS(Index = 34)]
        /* 0xD0 */ public float PatchScaling;
        [NMS(Index = 12)]
        /* 0xD4 */ public int SpawnAttemptsPerRegion;
        [NMS(Index = 15)]
        /* 0xD8 */ public float SpawnChancePerSecondExtreme;
        [NMS(Index = 13)]
        /* 0xDC */ public float SpawnChancePerSecondPerAttempt;
        // size: 0x5
        public enum SpawnConditionsEnum : uint {
            Anytime,
            DuringStorm,
            AtNight,
            NotInStorm,
            AtNightNotInStorm,
        }
        [NMS(Index = 3)]
        /* 0xE0 */ public SpawnConditionsEnum SpawnConditions;
        [NMS(Index = 39)]
        /* 0xE4 */ public float WanderMaxArcDeg;
        [NMS(Index = 37)]
        /* 0xE8 */ public float WanderMaxRadius;
        [NMS(Index = 38)]
        /* 0xEC */ public float WanderMinArcDeg;
        [NMS(Index = 36)]
        /* 0xF0 */ public float WanderMinRadius;
        // size: 0x3
        public enum WeatherEffectBehaviourEnum : uint {
            Static,
            Wander,
            ChasePlayer,
        }
        [NMS(Index = 7)]
        /* 0xF4 */ public WeatherEffectBehaviourEnum WeatherEffectBehaviour;
        // size: 0x3
        public enum WeatherEffectSpawnTypeEnum : uint {
            Single,
            Cluster,
            Patch,
        }
        [NMS(Index = 8)]
        /* 0xF8 */ public WeatherEffectSpawnTypeEnum WeatherEffectSpawnType;
        [NMS(Index = 22)]
        /* 0xFC */ public bool FadeoutAudio;
        [NMS(Index = 21)]
        /* 0xFD */ public bool FadeoutVisuals;
        [NMS(Index = 9)]
        /* 0xFE */ public bool RandomRotationAroundUp;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D55D8E2E6F5C9D7, NameHash = 0x419E50F8E497D496)]
    public class GcWeatherEffect : NMSTemplate
    {
        /* 0x000 */ public NMSTemplate EffectData;
        /* 0x050 */ public NMSString0x20A OSDMessage;
        /* 0x070 */ public NMSString0x10 BlockedByCluster;
        /* 0x080 */ public List<GcWeightedFilename> Effects;
        /* 0x090 */ public NMSString0x10 ForcedOnByHazard;
        /* 0x0A0 */ public NMSString0x10 Id;
        /* 0x0B0 */ public GcAudioWwiseEvents Audio;
        /* 0x0B4 */ public float ChanceOfPlanetBeingExtreme;
        /* 0x0B8 */ public float ClusterMaxLifetime;
        /* 0x0BC */ public float ClusterMinLifetime;
        /* 0x0C0 */ public float ClusterSpawnChance;
        /* 0x0C4 */ public float FadeoutStart;
        /* 0x0C8 */ public float ImpactGiftChance;
        /* 0x0CC */ public int MaxHazardsOfThisTypeActive;
        /* 0x0D0 */ public float MaxLifetime;
        /* 0x0D4 */ public float MaxSpawnDistance;
        /* 0x0D8 */ public float MaxSpawnScale;
        /* 0x0DC */ public float MinLifetime;
        /* 0x0E0 */ public float MinSpawnDistance;
        /* 0x0E4 */ public float MinSpawnScale;
        /* 0x0E8 */ public float MoveSpeed;
        /* 0x0EC */ public float PatchMaxRadius;
        /* 0x0F0 */ public int PatchMaxSpawns;
        /* 0x0F4 */ public float PatchMaxTimeSpawnOffset;
        /* 0x0F8 */ public float PatchMinRadius;
        /* 0x0FC */ public int PatchMinSpawns;
        /* 0x100 */ public float PatchScaling;
        /* 0x104 */ public int SpawnAttemptsPerRegion;
        /* 0x108 */ public float SpawnChancePerSecondExtreme;
        /* 0x10C */ public float SpawnChancePerSecondPerAttempt;
        // size: 0x5
        public enum SpawnConditionsEnum : uint {
            Anytime,
            DuringStorm,
            AtNight,
            NotInStorm,
            AtNightNotInStorm,
        }
        /* 0x110 */ public SpawnConditionsEnum SpawnConditions;
        /* 0x114 */ public float WanderMaxArcDeg;
        /* 0x118 */ public float WanderMaxRadius;
        /* 0x11C */ public float WanderMinArcDeg;
        /* 0x120 */ public float WanderMinRadius;
        // size: 0x3
        public enum WeatherEffectBehaviourEnum : uint {
            Static,
            Wander,
            ChasePlayer,
        }
        /* 0x124 */ public WeatherEffectBehaviourEnum WeatherEffectBehaviour;
        // size: 0x3
        public enum WeatherEffectSpawnTypeEnum : uint {
            Single,
            Cluster,
            Patch,
        }
        /* 0x128 */ public WeatherEffectSpawnTypeEnum WeatherEffectSpawnType;
        /* 0x12C */ public NMSString0x80 ImpactGift;
        /* 0x1AC */ public bool FadeoutAudio;
        /* 0x1AD */ public bool FadeoutVisuals;
        /* 0x1AE */ public bool RandomRotationAroundUp;
    }
}

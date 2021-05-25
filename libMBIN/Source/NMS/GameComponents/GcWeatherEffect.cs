using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1C0, GUID = 0x9F315BB206C6CFB4, NameHash = 0x419E50F8E497D496)]
    public class GcWeatherEffect : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string OSDMessage;
        /* 0x030 */ public List<GcWeightedFilename> Effects;
        public enum SpawnConditionsEnum { Anytime, DuringStorm, AtNight, NotInStorm, AtNightNotInStorm };
        /* 0x040 */ public SpawnConditionsEnum SpawnConditions;
        /* 0x044 */ public int MaxHazardsOfThisTypeActive;
        /* 0x048 */ public bool AllowedInCreative;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x49 */ public byte[] Padding49;
        [NMS(Size = 0x10)]
        /* 0x050 */ public string ForcedOnByHazard;
        [NMS(Size = 0x10)]
        /* 0x060 */ public string BlockedByCluster;
        public enum WeatherEffectBehaviourEnum { Static, Wander, ChasePlayer };
        /* 0x070 */ public WeatherEffectBehaviourEnum WeatherEffectBehaviour;
        public enum WeatherEffectSpawnTypeEnum { Single, Cluster, Patch };
        /* 0x074 */ public WeatherEffectSpawnTypeEnum WeatherEffectSpawnType;
        /* 0x078 */ public bool RandomRotationAroundUp;
        /* 0x07C */ public float MinSpawnScale;
        /* 0x080 */ public float MaxSpawnScale;
        /* 0x084 */ public int SpawnAttemptsPerRegion;
        /* 0x088 */ public float SpawnChancePerSecondPerAttempt;
        /* 0x08C */ public float ChanceOfPlanetBeingExtreme;
        /* 0x090 */ public float SpawnChancePerSecondExtreme;
        /* 0x094 */ public float MinSpawnDistance;
        /* 0x098 */ public float MaxSpawnDistance;
        /* 0x09C */ public float MinLifetime;
        /* 0x0A0 */ public float MaxLifetime;
        /* 0x0A4 */ public float FadeoutStart;
        /* 0x0A8 */ public bool FadeoutVisuals;
        /* 0x0A9 */ public bool FadeoutAudio;
        /* 0x0AC */ public GcAudioWwiseEvents Audio;
        [NMS(Size = 0x80)]
        /* 0x0B0 */ public string ImpactGift;
        /* 0x130 */ public float ImpactGiftChance;
        /* 0x134 */ public float ClusterSpawnChance;
        /* 0x138 */ public float ClusterMinLifetime;
        /* 0x13C */ public float ClusterMaxLifetime;
        /* 0x140 */ public float PatchMaxTimeSpawnOffset;
        /* 0x144 */ public float PatchMinRadius;
        /* 0x148 */ public float PatchMaxRadius;
        /* 0x14C */ public int PatchMinSpawns;
        /* 0x150 */ public int PatchMaxSpawns;
        /* 0x154 */ public float PatchScaling;
        /* 0x158 */ public float MoveSpeed;
        /* 0x15C */ public float WanderMinRadius;
        /* 0x160 */ public float WanderMaxRadius;
        /* 0x164 */ public float WanderMinArcDeg;
        /* 0x168 */ public float WanderMaxArcDeg;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x16C */ public byte[] Padding16C;
        /* 0x170 */ public NMSTemplate EffectData;
    }
}

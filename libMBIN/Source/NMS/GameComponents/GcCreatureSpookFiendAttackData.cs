using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50A5B9792897FD1B, NameHash = 0x64F53EE9)]
    public class GcCreatureSpookFiendAttackData : NMSTemplate
    {
        [NMS(Index = 16)]
        /* 0x00 */ public NMSString0x10 SpitAttackAnim;
        [NMS(Index = 6)]
        /* 0x10 */ public Vector2f DespawnSpookGoneTime;
        [NMS(Index = 10)]
        /* 0x18 */ public Vector2f FollowDistanceOscillationRange;
        [NMS(Index = 12)]
        /* 0x20 */ public Vector2f FollowHeightOscillationRange;
        [NMS(Index = 14)]
        /* 0x28 */ public Vector2f FollowSpeedOscillationRange;
        [NMS(Index = 1)]
        /* 0x30 */ public Vector2f HideDuration;
        [NMS(Index = 26)]
        /* 0x38 */ public Vector2f KamikazeCooldown;
        [NMS(Index = 31)]
        /* 0x40 */ public Vector2f KamikazePickWeightRange;
        [NMS(Index = 30)]
        /* 0x48 */ public Vector2f KamikazeThreatLevelRange;
        [NMS(Index = 24)]
        /* 0x50 */ public Vector2f NullAttackCooldown;
        [NMS(Index = 3)]
        /* 0x58 */ public Vector2f PostAttackMinVisibleDuration;
        [NMS(Index = 2)]
        /* 0x60 */ public Vector2f RevealDuration;
        [NMS(Index = 25)]
        /* 0x68 */ public Vector2f SpitAttackCooldown;
        [NMS(Index = 29)]
        /* 0x70 */ public Vector2f SpitPickWeightRange;
        [NMS(Index = 28)]
        /* 0x78 */ public Vector2f SpitThreatLevelRange;
        [NMS(Index = 37)]
        /* 0x80 */ public Vector2f ThreatLevelHealthScale;
        [NMS(Index = 36)]
        /* 0x88 */ public Vector2f ThreatLevelTimeAliveScale;
        [NMS(Index = 8)]
        /* 0x90 */ public float ApproachDistance;
        [NMS(Index = 7)]
        /* 0x94 */ public float DespawnFadeTime;
        [NMS(Index = 5)]
        /* 0x98 */ public float DespawnMinLifetime;
        [NMS(Index = 0)]
        /* 0x9C */ public float FadeTime;
        [NMS(Index = 11)]
        /* 0xA0 */ public float FollowDistanceOscillationPeriod;
        [NMS(Index = 13)]
        /* 0xA4 */ public float FollowHeightOscillationPeriod;
        [NMS(Index = 15)]
        /* 0xA8 */ public float FollowSpeedOscillationPeriod;
        [NMS(Index = 19)]
        /* 0xAC */ public GcAudioWwiseEvents KamikazeAudioEventBegin;
        [NMS(Index = 20)]
        /* 0xB0 */ public GcAudioWwiseEvents KamikazeAudioEventEnd;
        [NMS(Index = 23)]
        /* 0xB4 */ public float KamikazeCommitDistance;
        [NMS(Index = 22)]
        /* 0xB8 */ public float KamikazeMaxTurnRate;
        [NMS(Index = 21)]
        /* 0xBC */ public int MaxSimultaneousKamikaze;
        [NMS(Index = 27)]
        /* 0xC0 */ public float NullAttackWeight;
        [NMS(Index = 9)]
        /* 0xC4 */ public float ReapproachDistance;
        [NMS(Index = 17)]
        /* 0xC8 */ public int SpitAttackAnimFrame;
        [NMS(Index = 18)]
        /* 0xCC */ public float SpitAttackPauseTime;
        [NMS(Index = 35)]
        /* 0xD0 */ public float ThreatLevelHealthWeight;
        [NMS(Index = 33)]
        /* 0xD4 */ public float ThreatLevelSpookWeight;
        [NMS(Index = 34)]
        /* 0xD8 */ public float ThreatLevelTimeAliveWeight;
        [NMS(Index = 4)]
        /* 0xDC */ public bool DespawnWhenSpookGone;
        [NMS(Index = 32)]
        /* 0xDD */ public bool UseSpookMeterOutsidePermanentSpook;
    }
}

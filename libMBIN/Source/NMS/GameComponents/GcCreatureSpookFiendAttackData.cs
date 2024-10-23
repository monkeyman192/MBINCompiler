using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15F40B49ADC50818, NameHash = 0x64F53EE9)]
    public class GcCreatureSpookFiendAttackData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x10 SpitAttackAnim;
        [NMS(Index = 6)]
        /* 0x10 */ public Vector2f FollowDistanceOscillationRange;
        [NMS(Index = 8)]
        /* 0x18 */ public Vector2f FollowHeightOscillationRange;
        [NMS(Index = 10)]
        /* 0x20 */ public Vector2f FollowSpeedOscillationRange;
        [NMS(Index = 1)]
        /* 0x28 */ public Vector2f HideDuration;
        [NMS(Index = 20)]
        /* 0x30 */ public Vector2f KamikazeCooldown;
        [NMS(Index = 25)]
        /* 0x38 */ public Vector2f KamikazePickWeightRange;
        [NMS(Index = 24)]
        /* 0x40 */ public Vector2f KamikazeThreatLevelRange;
        [NMS(Index = 18)]
        /* 0x48 */ public Vector2f NullAttackCooldown;
        [NMS(Index = 3)]
        /* 0x50 */ public Vector2f PostAttackMinVisibleDuration;
        [NMS(Index = 2)]
        /* 0x58 */ public Vector2f RevealDuration;
        [NMS(Index = 19)]
        /* 0x60 */ public Vector2f SpitAttackCooldown;
        [NMS(Index = 23)]
        /* 0x68 */ public Vector2f SpitPickWeightRange;
        [NMS(Index = 22)]
        /* 0x70 */ public Vector2f SpitThreatLevelRange;
        [NMS(Index = 30)]
        /* 0x78 */ public Vector2f ThreatLevelHealthScale;
        [NMS(Index = 29)]
        /* 0x80 */ public Vector2f ThreatLevelTimeAliveScale;
        [NMS(Index = 4)]
        /* 0x88 */ public float ApproachDistance;
        [NMS(Index = 0)]
        /* 0x8C */ public float FadeTime;
        [NMS(Index = 7)]
        /* 0x90 */ public float FollowDistanceOscillationPeriod;
        [NMS(Index = 9)]
        /* 0x94 */ public float FollowHeightOscillationPeriod;
        [NMS(Index = 11)]
        /* 0x98 */ public float FollowSpeedOscillationPeriod;
        [NMS(Index = 15)]
        /* 0x9C */ public GcAudioWwiseEvents KamikazeAudioEventBegin;
        [NMS(Index = 16)]
        /* 0xA0 */ public GcAudioWwiseEvents KamikazeAudioEventEnd;
        [NMS(Index = 17)]
        /* 0xA4 */ public int MaxSimultaneousKamikaze;
        [NMS(Index = 21)]
        /* 0xA8 */ public float NullAttackWeight;
        [NMS(Index = 5)]
        /* 0xAC */ public float ReapproachDistance;
        [NMS(Index = 13)]
        /* 0xB0 */ public int SpitAttackAnimFrame;
        [NMS(Index = 14)]
        /* 0xB4 */ public float SpitAttackPauseTime;
        [NMS(Index = 28)]
        /* 0xB8 */ public float ThreatLevelHealthWeight;
        [NMS(Index = 26)]
        /* 0xBC */ public float ThreatLevelSpookWeight;
        [NMS(Index = 27)]
        /* 0xC0 */ public float ThreatLevelTimeAliveWeight;
    }
}

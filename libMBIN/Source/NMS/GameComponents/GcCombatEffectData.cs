using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D56785A4FE5D6A, NameHash = 0xAB307BDA)]
    public class GcCombatEffectData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 DamageId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 ParticlesId;
        [NMS(Index = 6)]
        /* 0x20 */ public float DamageMergeTime;
        [NMS(Index = 8)]
        /* 0x24 */ public float DamageMinDistance;
        [NMS(Index = 7)]
        /* 0x28 */ public float DamageTimeBetweenNumbers;
        [NMS(Index = 3)]
        /* 0x2C */ public GcAudioWwiseEvents EndAudio;
        [NMS(Index = 2)]
        /* 0x30 */ public GcAudioWwiseEvents StartAudio;
        [NMS(Index = 4)]
        /* 0x34 */ public GcStatsTypes Stat;
        [NMS(Index = 5)]
        /* 0x38 */ public bool OverrideDamageNumberData;
    }
}

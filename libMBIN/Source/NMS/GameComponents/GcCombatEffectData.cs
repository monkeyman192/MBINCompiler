using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BBE69884E81E66F, NameHash = 0x6D475929020A9A4D)]
    public class GcCombatEffectData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DamageId;
        /* 0x10 */ public NMSString0x10 ParticlesId;
        /* 0x20 */ public float DamageMergeTime;
        /* 0x24 */ public float DamageMinDistance;
        /* 0x28 */ public float DamageTimeBetweenNumbers;
        /* 0x2C */ public GcAudioWwiseEvents EndAudio;
        /* 0x30 */ public GcAudioWwiseEvents StartAudio;
        /* 0x34 */ public GcStatsTypes Stat;
        /* 0x38 */ public bool OverrideDamageNumberData;
    }
}

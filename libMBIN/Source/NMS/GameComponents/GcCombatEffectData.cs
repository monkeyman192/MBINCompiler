using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x877389A1BA3F6510, NameHash = 0x6D475929020A9A4D)]
    public class GcCombatEffectData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DamageId;
        /* 0x10 */ public NMSString0x10 ParticlesId;
        /* 0x20 */ public GcAudioWwiseEvents StartAudio;
        /* 0x24 */ public GcAudioWwiseEvents EndAudio;
        /* 0x28 */ public GcStatsTypes Stat;
        /* 0x2C */ public bool OverrideDamageNumberData;
        /* 0x30 */ public float DamageMergeTime;
        /* 0x34 */ public float DamageTimeBetweenNumbers;
        /* 0x38 */ public float DamageMinDistance;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB85EE66B6963749, NameHash = 0x93BDA22E)]
    public class GcPlayerExperienceSpawnArchetypeData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x10 AppearAnim;
        [NMS(Index = 14)]
        /* 0x10 */ public List<NMSTemplate> BehaviourOverrides;
        [NMS(Index = 13)]
        /* 0x20 */ public NMSString0x10 BehaviourTreeOverride;
        [NMS(Index = 15)]
        /* 0x30 */ public List<NMSTemplate> BlackboardValues;
        [NMS(Index = 8)]
        /* 0x40 */ public NMSString0x10 DamageOverride;
        [NMS(Index = 9)]
        /* 0x50 */ public NMSString0x10 DamageReceivedMultiplier;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x10 GenerateResource;
        [NMS(Index = 0)]
        /* 0x70 */ public NMSString0x10 Id;
        [NMS(Index = 11)]
        /* 0x80 */ public float DespawnDistOverride;
        [NMS(Index = 7)]
        /* 0x84 */ public int HealthOverride;
        [NMS(Index = 3)]
        /* 0x88 */ public float Scale;
        [NMS(Index = 4)]
        /* 0x8C */ public float ScaleVariation;
        [NMS(Index = 10)]
        /* 0x90 */ public float SpawnDistOverride;
        [NMS(Index = 6)]
        /* 0x94 */ public float SpeedMultiplier;
        [NMS(Index = 2)]
        /* 0x98 */ public GcCreatureTypes Type;
        [NMS(Index = 12)]
        /* 0x9C */ public bool AllowSpawnInAir;
    }
}

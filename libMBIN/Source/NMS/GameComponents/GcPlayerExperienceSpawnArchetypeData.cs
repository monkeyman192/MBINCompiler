using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x466BF1A485C3550F, NameHash = 0x3D6AF30F10DB0EAA)]
    public class GcPlayerExperienceSpawnArchetypeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 GenerateResource;
        /* 0x20 */ public GcCreatureTypes Type;
        /* 0x24 */ public float Scale;
        /* 0x28 */ public float ScaleVariation;
        /* 0x30 */ public NMSString0x10 AppearAnim;
        /* 0x40 */ public float SpeedMultiplier;
        /* 0x44 */ public int HealthOverride;
        /* 0x48 */ public NMSString0x10 DamageOverride;
        /* 0x58 */ public NMSString0x10 DamageReceivedMultiplier;
        /* 0x68 */ public float SpawnDistOverride;
        /* 0x6C */ public float DespawnDistOverride;
        /* 0x70 */ public NMSString0x10 BehaviourTreeOverride;
        /* 0x80 */ public List<NMSTemplate> BehaviourOverrides;
        /* 0x90 */ public List<NMSTemplate> BlackboardValues;
    }
}

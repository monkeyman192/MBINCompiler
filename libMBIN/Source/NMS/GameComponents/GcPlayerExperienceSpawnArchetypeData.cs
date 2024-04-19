using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA963EDDC14C7CA3B, NameHash = 0x3D6AF30F10DB0EAA)]
    public class GcPlayerExperienceSpawnArchetypeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AppearAnim;
        /* 0x10 */ public List<NMSTemplate> BehaviourOverrides;
        /* 0x20 */ public NMSString0x10 BehaviourTreeOverride;
        /* 0x30 */ public List<NMSTemplate> BlackboardValues;
        /* 0x40 */ public NMSString0x10 DamageOverride;
        /* 0x50 */ public NMSString0x10 DamageReceivedMultiplier;
        /* 0x60 */ public NMSString0x10 GenerateResource;
        /* 0x70 */ public NMSString0x10 Id;
        /* 0x80 */ public float DespawnDistOverride;
        /* 0x84 */ public int HealthOverride;
        /* 0x88 */ public float Scale;
        /* 0x8C */ public float ScaleVariation;
        /* 0x90 */ public float SpawnDistOverride;
        /* 0x94 */ public float SpeedMultiplier;
        /* 0x98 */ public GcCreatureTypes Type;
    }
}

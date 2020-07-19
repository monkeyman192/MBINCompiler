using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x98428D092A9B70D9, NameHash = 0x3D6AF30F10DB0EAA)]
    public class GcPlayerExperienceSpawnArchetypeData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public GcCreatureTypes Type;
        /* 0x14 */ public float Scale;
        /* 0x18 */ public float ScaleVariation;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] Padding1C;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string AppearAnim;
        /* 0x30 */ public float SpeedMultiplier;
        /* 0x34 */ public int HealthOverride;
        [NMS(Size = 0x10)]
        /* 0x38 */ public string DamageOverride;
        [NMS(Size = 0x10)]
        /* 0x48 */ public string DamageReceivedMultiplier;
        /* 0x58 */ public float SpawnDistOverride;
        /* 0x5C */ public float DespawnDistOverride;
        /* 0x60 */ public List<NMSTemplate> BehaviourOverrides;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA681D58DC8F97BB8, NameHash = 0xCC070D1A8B81739E)]
    public class GcCreatureSpawnComponentData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement SpecificModel;
        /* 0x2A8 */ public NMSString0x10 Creature;
        /* 0x2B8 */ public GcSeed Seed;
        /* 0x2C8 */ public List<GcSpawnComponentOption> SpawnOptionList;
        /* 0x2D8 */ public NMSString0x10 TriggerID;
        /* 0x2E8 */ public GcCreatureTypes CreatureType;
        /* 0x2EC */ public int FunctionKey;
        /* 0x2F0 */ public float Scale;
        /* 0x2F4 */ public GcAISpaceshipTypes ShipAIOverride;
        // size: 0x4
        public enum SpawnerModeEnum : uint {
            Hidden,
            Visible,
            HideOnSpawn,
            HiddenTimer,
        }
        /* 0x2F8 */ public SpawnerModeEnum SpawnerMode;
        /* 0x2FC */ public float StartTimeMax;
        /* 0x300 */ public float StartTimeMin;
        /* 0x304 */ public float TriggerDistance;
        /* 0x308 */ public NMSString0x80 Model;
        /* 0x388 */ public bool SpawnAlert;
    }
}

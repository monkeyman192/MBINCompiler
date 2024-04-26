using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA681D58DC8F97BB8, NameHash = 0xCC070D1A8B81739E)]
    public class GcCreatureSpawnComponentData : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x000 */ public GcResourceElement SpecificModel;
        [NMS(Index = 2)]
        /* 0x2A8 */ public NMSString0x10 Creature;
        [NMS(Index = 5)]
        /* 0x2B8 */ public GcSeed Seed;
        [NMS(Index = 14)]
        /* 0x2C8 */ public List<GcSpawnComponentOption> SpawnOptionList;
        [NMS(Index = 0)]
        /* 0x2D8 */ public NMSString0x10 TriggerID;
        [NMS(Index = 3)]
        /* 0x2E8 */ public GcCreatureTypes CreatureType;
        [NMS(Index = 6)]
        /* 0x2EC */ public int FunctionKey;
        [NMS(Index = 8)]
        /* 0x2F0 */ public float Scale;
        [NMS(Index = 4)]
        /* 0x2F4 */ public GcAISpaceshipTypes ShipAIOverride;
        // size: 0x4
        public enum SpawnerModeEnum : uint {
            Hidden,
            Visible,
            HideOnSpawn,
            HiddenTimer,
        }
        [NMS(Index = 12)]
        /* 0x2F8 */ public SpawnerModeEnum SpawnerMode;
        [NMS(Index = 10)]
        /* 0x2FC */ public float StartTimeMax;
        [NMS(Index = 9)]
        /* 0x300 */ public float StartTimeMin;
        [NMS(Index = 7)]
        /* 0x304 */ public float TriggerDistance;
        [NMS(Index = 1)]
        /* 0x308 */ public NMSString0x80 Model;
        [NMS(Index = 11)]
        /* 0x388 */ public bool SpawnAlert;
    }
}

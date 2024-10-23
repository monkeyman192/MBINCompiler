using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0D4397B5AD232F, NameHash = 0x7505BE5F)]
    public class GcCreatureSpawnComponentData : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public GcResourceElement SpecificModel;
        [NMS(Index = 2)]
        /* 0x48 */ public NMSString0x10 Creature;
        [NMS(Index = 1)]
        /* 0x58 */ public VariableSizeString Model;
        [NMS(Index = 5)]
        /* 0x68 */ public GcSeed Seed;
        [NMS(Index = 14)]
        /* 0x78 */ public List<GcSpawnComponentOption> SpawnOptionList;
        [NMS(Index = 0)]
        /* 0x88 */ public NMSString0x10 TriggerID;
        [NMS(Index = 3)]
        /* 0x98 */ public GcCreatureTypes CreatureType;
        [NMS(Index = 6)]
        /* 0x9C */ public int FunctionKey;
        [NMS(Index = 8)]
        /* 0xA0 */ public float Scale;
        [NMS(Index = 4)]
        /* 0xA4 */ public GcAISpaceshipTypes ShipAIOverride;
        // size: 0x4
        public enum SpawnerModeEnum : uint {
            Hidden,
            Visible,
            HideOnSpawn,
            HiddenTimer,
        }
        [NMS(Index = 12)]
        /* 0xA8 */ public SpawnerModeEnum SpawnerMode;
        [NMS(Index = 10)]
        /* 0xAC */ public float StartTimeMax;
        [NMS(Index = 9)]
        /* 0xB0 */ public float StartTimeMin;
        [NMS(Index = 7)]
        /* 0xB4 */ public float TriggerDistance;
        [NMS(Index = 11)]
        /* 0xB8 */ public bool SpawnAlert;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D2AFA77B6C80574, NameHash = 0xCC070D1A8B81739E)]
    public class GcCreatureSpawnComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 TriggerID;
        /* 0x010 */ public NMSString0x80 Model;
        /* 0x090 */ public NMSString0x10 Creature;
        /* 0x0A0 */ public GcCreatureTypes CreatureType;
        /* 0x0A4 */ public GcAISpaceshipTypes ShipAIOverride;
        /* 0x0A8 */ public GcSeed Seed;
        /* 0x0B8 */ public int FunctionKey;
        /* 0x0BC */ public float TriggerDistance;
        /* 0x0C0 */ public float Scale;
        /* 0x0C4 */ public float StartTimeMin;
        /* 0x0C8 */ public float StartTimeMax;
        /* 0x0CC */ public bool SpawnAlert;
        // size: 0x4
        public enum SpawnerModeEnum { Hidden, Visible, HideOnSpawn, HiddenTimer }
        /* 0x0D0 */ public SpawnerModeEnum SpawnerMode;
        /* 0x0D8 */ public GcResourceElement SpecificModel;
        /* 0x380 */ public List<GcSpawnComponentOption> SpawnOptionList;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x390, GUID = 0x5C45360A79CFEBB8, NameHash = 0xCC070D1A8B81739E)]
    public class GcCreatureSpawnComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string TriggerID;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Model;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string Creature;

        /* 0x0A0 */ public GcCreatureTypes CreatureType;
        /* 0x0A4 */ public GcAISpaceshipTypes ShipAIOverride;
        /* 0x0A8 */ public GcSeed Seed;
        /* 0x0B8 */ public int FunctionKey;
        /* 0x0BC */ public float TriggerDistance;
        /* 0x0C0 */ public float Scale;
        /* 0x0C4 */ public float StartTimeMin;
        /* 0x0C8 */ public float StartTimeMax;
        /* 0x0CC */ public bool SpawnAlert;
		public enum SpawnerModeEnum { Hidden, Visible, HideOnSpawn, HiddenTimer }
		public SpawnerModeEnum SpawnerMode;

        [NMS(Size = 4, Ignore = true)]
        /* 0x0D4 */ public byte[] PaddingD4;

        /* 0x0D8 */ public GcResourceElement SpecificModel;
        /* 0x380 */ public List<GcSpawnComponentOption> SpawnOptionList;
    }
}

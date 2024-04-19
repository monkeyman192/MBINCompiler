using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57D664ECDFC788E7, NameHash = 0x9803054FC61F20F4)]
    public class GcBackgroundSpaceEncounterInfo : NMSTemplate
    {
        /* 0x00 */ public GcPulseEncounterSpawnObject Encounter;
        /* 0xA8 */ public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions;
        /* 0xC0 */ public NMSString0x10 Id;
        /* 0xD0 */ public float DespawnDistance;
        /* 0xD4 */ public float MinDuration;
        /* 0xD8 */ public float SelectionWeighting;
        /* 0xDC */ public float SpawnChance;
        /* 0xE0 */ public float SpawnDistance;
    }
}

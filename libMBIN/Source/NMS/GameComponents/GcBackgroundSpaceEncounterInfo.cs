using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x171E55E3181B731E, NameHash = 0x9803054FC61F20F4)]
    public class GcBackgroundSpaceEncounterInfo : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcPulseEncounterSpawnObject Encounter;
        [NMS(Index = 1)]
        /* 0xA8 */ public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 0)]
        /* 0xC0 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0xD0 */ public float DespawnDistance;
        [NMS(Index = 5)]
        /* 0xD4 */ public float MinDuration;
        [NMS(Index = 2)]
        /* 0xD8 */ public float SelectionWeighting;
        [NMS(Index = 3)]
        /* 0xDC */ public float SpawnChance;
        [NMS(Index = 4)]
        /* 0xE0 */ public float SpawnDistance;
    }
}

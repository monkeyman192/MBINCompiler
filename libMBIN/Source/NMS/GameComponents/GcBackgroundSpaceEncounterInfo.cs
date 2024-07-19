using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1935CE5BB5B04829, NameHash = 0x37EBD7AD)]
    public class GcBackgroundSpaceEncounterInfo : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcPulseEncounterSpawnObject Encounter;
        [NMS(Index = 1)]
        /* 0x40 */ public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x68 */ public float DespawnDistance;
        [NMS(Index = 5)]
        /* 0x6C */ public float MinDuration;
        [NMS(Index = 2)]
        /* 0x70 */ public float SelectionWeighting;
        [NMS(Index = 3)]
        /* 0x74 */ public float SpawnChance;
        [NMS(Index = 4)]
        /* 0x78 */ public float SpawnDistance;
    }
}

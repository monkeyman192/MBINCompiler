using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A365352B89094AF, NameHash = 0x9803054FC61F20F4)]
    public class GcBackgroundSpaceEncounterInfo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions;
        /* 0x14 */ public float SelectionWeighting;
        /* 0x18 */ public float SpawnChance;
        /* 0x1C */ public float SpawnDistance;
        /* 0x20 */ public float MinDuration;
        /* 0x24 */ public float DespawnDistance;
        /* 0x28 */ public GcPulseEncounterSpawnObject Encounter;
    }
}

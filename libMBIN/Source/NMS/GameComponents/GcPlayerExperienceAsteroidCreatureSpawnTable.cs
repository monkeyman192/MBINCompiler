using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4301C9F5629C95B7, NameHash = 0xC49FE6E5B9227EF6)]
    public class GcPlayerExperienceAsteroidCreatureSpawnTable : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> LargeAsteroidSpawns;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> MediumAsteroidSpawns;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> SmallAsteroidSpawns;
        [NMS(Index = 4)]
        /* 0x30 */ public float LargeAsteroidSpawnPercent;
        [NMS(Index = 2)]
        /* 0x34 */ public float MediumAsteroidSpawnPercent;
        [NMS(Index = 0)]
        /* 0x38 */ public float SmallAsteroidSpawnPercent;
    }
}

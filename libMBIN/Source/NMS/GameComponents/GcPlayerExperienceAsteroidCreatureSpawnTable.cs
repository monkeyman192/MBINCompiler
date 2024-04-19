using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13686FB01961A6D, NameHash = 0xC49FE6E5B9227EF6)]
    public class GcPlayerExperienceAsteroidCreatureSpawnTable : NMSTemplate
    {
        /* 0x00 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> LargeAsteroidSpawns;
        /* 0x10 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> MediumAsteroidSpawns;
        /* 0x20 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> SmallAsteroidSpawns;
        /* 0x30 */ public float LargeAsteroidSpawnPercent;
        /* 0x34 */ public float MediumAsteroidSpawnPercent;
        /* 0x38 */ public float SmallAsteroidSpawnPercent;
    }
}

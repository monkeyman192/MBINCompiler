using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16DD11D831797409, NameHash = 0xC49FE6E5B9227EF6)]
    public class GcPlayerExperienceAsteroidCreatureSpawnTable : NMSTemplate
    {
        /* 0x00 */ public float SmallAsteroidSpawnPercent;
        /* 0x08 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> SmallAsteroidSpawns;
        /* 0x18 */ public float MediumAsteroidSpawnPercent;
        /* 0x20 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> MediumAsteroidSpawns;
        /* 0x30 */ public float LargeAsteroidSpawnPercent;
        /* 0x38 */ public List<GcPlayerExperienceAsteroidCreatureSpawnData> LargeAsteroidSpawns;
    }
}

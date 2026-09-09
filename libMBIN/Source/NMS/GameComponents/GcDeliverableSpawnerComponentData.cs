using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC4CEA885206F375, NameHash = 0xCB8DA6A6)]
    public class GcDeliverableSpawnerComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcDeliverableSpawnEntry> SpawnEntries;
    }
}

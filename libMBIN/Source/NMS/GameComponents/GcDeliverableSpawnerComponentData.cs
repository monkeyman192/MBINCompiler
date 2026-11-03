using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD839C067418F5010, NameHash = 0xCB8DA6A6)]
    public class GcDeliverableSpawnerComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcDeliverableSpawnEntry> SpawnEntries;
        [NMS(Index = 1)]
        /* 0x10 */ public float SpawnInterval;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D6FF674931C56B1, NameHash = 0x3500C026)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcObjectSpawnData> Objects;
        [NMS(Index = 1)]
        /* 0x10 */ public int MaxObjectsToSpawn;
        [NMS(Index = 0)]
        /* 0x14 */ public GcTerrainTileType TileType;
    }
}

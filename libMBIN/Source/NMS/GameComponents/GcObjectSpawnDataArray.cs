using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6ADF54CB6B64DA5A, NameHash = 0x3AAEFA9CCB9353C1)]
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

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6ADF54CB6B64DA5A, NameHash = 0x3AAEFA9CCB9353C1)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        /* 0x00 */ public List<GcObjectSpawnData> Objects;
        /* 0x10 */ public int MaxObjectsToSpawn;
        /* 0x14 */ public GcTerrainTileType TileType;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x37D0C7E8CADBB122, NameHash = 0x3AAEFA9CCB9353C1)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        public GcTerrainTileType TileType;
        public int MaxObjectsToSpawn;
        public List<GcObjectSpawnData> ObjectData;
    }
}

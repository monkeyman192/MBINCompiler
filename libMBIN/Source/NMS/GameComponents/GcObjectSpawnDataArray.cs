using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xA48AC8DE553048A2, NameHash = 0x3AAEFA9CCB9353C1)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        public GcTerrainTileType TileType;
        public int MaxObjectsToSpawn;
        public List<GcObjectSpawnData> ObjectData;
    }
}

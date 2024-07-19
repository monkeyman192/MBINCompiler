using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24F1439CE47BA82, NameHash = 0x2C6E32AD)]
    public class GcPlanetaryNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkNavMeshBuildParams BaseParams;
        [NMS(Index = 1)]
        /* 0x28 */ public int CellsPerVoxelHeight;
        [NMS(Index = 0)]
        /* 0x2C */ public int CellsPerVoxelWidth;
    }
}

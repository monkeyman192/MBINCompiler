using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xA40DF40B252660EA, NameHash = 0xDC4113AA)]
    public class GcNavigationGlobals : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public TkVolumeNavMeshBuildParams FreighterBaseNavMeshBuildParams;
        [NMS(Index = 5)]
        /* 0x060 */ public TkVolumeNavMeshBuildParams NexusNavMeshBuildParams;
        [NMS(Index = 4)]
        /* 0x0C0 */ public TkVolumeNavMeshBuildParams SpaceStationNavMeshBuildParams;
        [NMS(Index = 2)]
        /* 0x120 */ public GcPlanetaryNavMeshBuildParams PlanetaryNavMeshBuildParams;
        [NMS(Index = 0)]
        /* 0x150 */ public int MaxAsyncTileBuildsInFlight;
        [NMS(Index = 1)]
        /* 0x154 */ public int PlanetaryNavMeshLod;
    }
}

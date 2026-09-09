using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xF5E8BBDC3178163E, NameHash = 0xDC4113AA)]
    public class GcNavigationGlobals : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkVolumeNavMeshBuildParams FreighterBaseNavMeshBuildParams;
        [NMS(Index = 4)]
        /* 0x0A0 */ public TkVolumeNavMeshBuildParams NexusNavMeshBuildParams;
        [NMS(Index = 3)]
        /* 0x140 */ public TkVolumeNavMeshBuildParams SpaceStationNavMeshBuildParams;
        [NMS(Index = 0)]
        /* 0x1E0 */ public int MaxAsyncTileBuildsInFlight;
        [NMS(Index = 1)]
        /* 0x1E4 */ public int PlanetaryNavMeshLod;
    }
}

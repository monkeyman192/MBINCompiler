using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xE15A295A664BAB06, NameHash = 0xD1D7201E3228DD7B)]
    public class GcSimulationGlobals : NMSTemplate
    {
        /* 0x000 */ public List<NMSString0x80> AtlasStationAnomalies;
        /* 0x010 */ public List<NMSString0x80> BlackHoleAnomalies;
        /* 0x020 */ public List<GcMultitoolPoolData> MultitoolPool;
        /* 0x030 */ public List<NMSString0x80> PlanetTerrainMaterials;
        /* 0x040 */ public List<NMSString0x80> PrefetchMaterialResources;
        /* 0x050 */ public List<NMSString0x80> PrefetchScenegraphResources;
        /* 0x060 */ public List<NMSString0x80> PrefetchTextureResources;
        /* 0x070 */ public ulong ProceduralBuildingsGenerationSeed;
        /* 0x078 */ public float WarpTunnelScale;
        /* 0x07C */ public NMSString0x80 AbandonedSpaceStationFile;
        /* 0x0FC */ public NMSString0x80 BlackHoleTunnelFile;
        /* 0x17C */ public NMSString0x80 HeavyAirAbandonedFreighter;
        /* 0x1FC */ public NMSString0x80 HeavyAirCave;
        /* 0x27C */ public NMSString0x80 HeavyAirSpaceStorm;
        /* 0x2FC */ public NMSString0x80 HeavyAirUnderwater;
        /* 0x37C */ public NMSString0x80 NexusExteriorFile;
        /* 0x3FC */ public NMSString0x80 NexusFile;
        /* 0x47C */ public NMSString0x80 None;
        /* 0x4FC */ public NMSString0x80 PirateSystemSpaceStationFile;
        /* 0x57C */ public NMSString0x80 PlaceMarkerFile;
        /* 0x5FC */ public NMSString0x80 PlacementDroneFile;
        /* 0x67C */ public NMSString0x80 PlanetAtmosphereFile;
        /* 0x6FC */ public NMSString0x80 PlanetAtmosphereMaterialFile;
        /* 0x77C */ public NMSString0x80 PlanetMaterialFile;
        /* 0x7FC */ public NMSString0x80 PlanetRingFile;
        /* 0x87C */ public NMSString0x80 PlanetRingMaterialFile;
        /* 0x8FC */ public NMSString0x80 PlaterWaterMaterialFile;
        /* 0x97C */ public NMSString0x80 PortalStoryTunnelFile;
        /* 0x9FC */ public NMSString0x80 PortalTunnelFile;
        /* 0xA7C */ public NMSString0x80 SpaceStationFile;
        /* 0xAFC */ public NMSString0x80 StartingSceneFile;
        /* 0xB7C */ public NMSString0x80 TeleportTunnelFile;
        /* 0xBFC */ public NMSString0x80 WarpTunnelFile;
    }
}

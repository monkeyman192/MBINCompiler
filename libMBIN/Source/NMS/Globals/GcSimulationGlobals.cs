using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xE15A295A664BAB06, NameHash = 0xD1D7201E3228DD7B)]
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public List<NMSString0x80> AtlasStationAnomalies;
        [NMS(Index = 9)]
        /* 0x010 */ public List<NMSString0x80> BlackHoleAnomalies;
        [NMS(Index = 1)]
        /* 0x020 */ public List<GcMultitoolPoolData> MultitoolPool;
        [NMS(Index = 25)]
        /* 0x030 */ public List<NMSString0x80> PlanetTerrainMaterials;
        [NMS(Index = 18)]
        /* 0x040 */ public List<NMSString0x80> PrefetchMaterialResources;
        [NMS(Index = 17)]
        /* 0x050 */ public List<NMSString0x80> PrefetchScenegraphResources;
        [NMS(Index = 26)]
        /* 0x060 */ public List<NMSString0x80> PrefetchTextureResources;
        [NMS(Index = 2)]
        /* 0x070 */ public ulong ProceduralBuildingsGenerationSeed;
        [NMS(Index = 27)]
        /* 0x078 */ public float WarpTunnelScale;
        [NMS(Index = 7)]
        /* 0x07C */ public NMSString0x80 AbandonedSpaceStationFile;
        [NMS(Index = 29)]
        /* 0x0FC */ public NMSString0x80 BlackHoleTunnelFile;
        [NMS(Index = 15)]
        /* 0x17C */ public NMSString0x80 HeavyAirAbandonedFreighter;
        [NMS(Index = 13)]
        /* 0x1FC */ public NMSString0x80 HeavyAirCave;
        [NMS(Index = 16)]
        /* 0x27C */ public NMSString0x80 HeavyAirSpaceStorm;
        [NMS(Index = 14)]
        /* 0x2FC */ public NMSString0x80 HeavyAirUnderwater;
        [NMS(Index = 5)]
        /* 0x37C */ public NMSString0x80 NexusExteriorFile;
        [NMS(Index = 4)]
        /* 0x3FC */ public NMSString0x80 NexusFile;
        [NMS(Index = 11)]
        /* 0x47C */ public NMSString0x80 None;
        [NMS(Index = 8)]
        /* 0x4FC */ public NMSString0x80 PirateSystemSpaceStationFile;
        [NMS(Index = 6)]
        /* 0x57C */ public NMSString0x80 PlaceMarkerFile;
        [NMS(Index = 12)]
        /* 0x5FC */ public NMSString0x80 PlacementDroneFile;
        [NMS(Index = 19)]
        /* 0x67C */ public NMSString0x80 PlanetAtmosphereFile;
        [NMS(Index = 20)]
        /* 0x6FC */ public NMSString0x80 PlanetAtmosphereMaterialFile;
        [NMS(Index = 23)]
        /* 0x77C */ public NMSString0x80 PlanetMaterialFile;
        [NMS(Index = 21)]
        /* 0x7FC */ public NMSString0x80 PlanetRingFile;
        [NMS(Index = 22)]
        /* 0x87C */ public NMSString0x80 PlanetRingMaterialFile;
        [NMS(Index = 24)]
        /* 0x8FC */ public NMSString0x80 PlaterWaterMaterialFile;
        [NMS(Index = 32)]
        /* 0x97C */ public NMSString0x80 PortalStoryTunnelFile;
        [NMS(Index = 31)]
        /* 0x9FC */ public NMSString0x80 PortalTunnelFile;
        [NMS(Index = 3)]
        /* 0xA7C */ public NMSString0x80 SpaceStationFile;
        [NMS(Index = 0)]
        /* 0xAFC */ public NMSString0x80 StartingSceneFile;
        [NMS(Index = 30)]
        /* 0xB7C */ public NMSString0x80 TeleportTunnelFile;
        [NMS(Index = 28)]
        /* 0xBFC */ public NMSString0x80 WarpTunnelFile;
    }
}

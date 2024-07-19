using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xC3B79873C9707DFE, NameHash = 0xA8487890)]
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public VariableSizeString AbandonedSpaceStationFile;
        [NMS(Index = 10)]
        /* 0x010 */ public List<VariableSizeString> AtlasStationAnomalies;
        [NMS(Index = 9)]
        /* 0x020 */ public List<VariableSizeString> BlackHoleAnomalies;
        [NMS(Index = 29)]
        /* 0x030 */ public VariableSizeString BlackHoleTunnelFile;
        [NMS(Index = 15)]
        /* 0x040 */ public VariableSizeString HeavyAirAbandonedFreighter;
        [NMS(Index = 13)]
        /* 0x050 */ public VariableSizeString HeavyAirCave;
        [NMS(Index = 16)]
        /* 0x060 */ public VariableSizeString HeavyAirSpaceStorm;
        [NMS(Index = 14)]
        /* 0x070 */ public VariableSizeString HeavyAirUnderwater;
        [NMS(Index = 1)]
        /* 0x080 */ public List<GcMultitoolPoolData> MultitoolPool;
        [NMS(Index = 5)]
        /* 0x090 */ public VariableSizeString NexusExteriorFile;
        [NMS(Index = 4)]
        /* 0x0A0 */ public VariableSizeString NexusFile;
        [NMS(Index = 11)]
        /* 0x0B0 */ public VariableSizeString None;
        [NMS(Index = 8)]
        /* 0x0C0 */ public VariableSizeString PirateSystemSpaceStationFile;
        [NMS(Index = 6)]
        /* 0x0D0 */ public VariableSizeString PlaceMarkerFile;
        [NMS(Index = 12)]
        /* 0x0E0 */ public VariableSizeString PlacementDroneFile;
        [NMS(Index = 19)]
        /* 0x0F0 */ public VariableSizeString PlanetAtmosphereFile;
        [NMS(Index = 20)]
        /* 0x100 */ public VariableSizeString PlanetAtmosphereMaterialFile;
        [NMS(Index = 23)]
        /* 0x110 */ public VariableSizeString PlanetMaterialFile;
        [NMS(Index = 21)]
        /* 0x120 */ public VariableSizeString PlanetRingFile;
        [NMS(Index = 22)]
        /* 0x130 */ public VariableSizeString PlanetRingMaterialFile;
        [NMS(Index = 25)]
        /* 0x140 */ public List<VariableSizeString> PlanetTerrainMaterials;
        [NMS(Index = 24)]
        /* 0x150 */ public VariableSizeString PlaterWaterMaterialFile;
        [NMS(Index = 32)]
        /* 0x160 */ public VariableSizeString PortalStoryTunnelFile;
        [NMS(Index = 31)]
        /* 0x170 */ public VariableSizeString PortalTunnelFile;
        [NMS(Index = 18)]
        /* 0x180 */ public List<VariableSizeString> PrefetchMaterialResources;
        [NMS(Index = 17)]
        /* 0x190 */ public List<VariableSizeString> PrefetchScenegraphResources;
        [NMS(Index = 26)]
        /* 0x1A0 */ public List<VariableSizeString> PrefetchTextureResources;
        [NMS(Index = 3)]
        /* 0x1B0 */ public VariableSizeString SpaceStationFile;
        [NMS(Index = 0)]
        /* 0x1C0 */ public VariableSizeString StartingSceneFile;
        [NMS(Index = 30)]
        /* 0x1D0 */ public VariableSizeString TeleportTunnelFile;
        [NMS(Index = 28)]
        /* 0x1E0 */ public VariableSizeString WarpTunnelFile;
        [NMS(Index = 2)]
        /* 0x1F0 */ public ulong ProceduralBuildingsGenerationSeed;
        [NMS(Index = 27)]
        /* 0x1F8 */ public float WarpTunnelScale;
    }
}

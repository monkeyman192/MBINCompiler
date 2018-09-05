namespace libMBIN.Models.Structs
{
    public class GcSimulationGlobals : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0 */ public string StartingSceneFile;
        [NMS(Size = 0x80)]
        /* 0x80 */ public string MultitoolFile;
        /* 0x100 */ public long ProceduralBuildingsGenerationSeed;
        [NMS(Size = 0x80)]
        /* 0x108 */ public string SpaceStationFile;
        [NMS(Size = 0x80)]
        /* 0x188 */ public string PlaceMarkerFile;
        [NMS(Size = 0x80)]
        /* 0x208 */ public string AbandonedSpaceStationFile;
        [NMS(Size = 0x80)]
        /* 0x288 */ public string BlackHoleAnomalies;
        [NMS(Size = 0xC)]
        /* 0x308 */ public NMSString0x80[] AtlasStationAnomalies;
        [NMS(Size = 0x80)]
        /* 0x908 */ public string SpaceAnomalyFile;
        [NMS(Size = 0x80)]
        /* 0x988 */ public string None;
        [NMS(Size = 0x80)]
        /* 0xA08 */ public string PlacementDroneFile;
        [NMS(Size = 0x80)]
        /* 0xA88 */ public string HeavyAirCave;
        [NMS(Size = 0x80)]
        /* 0xB08 */ public string HeavyAirUnderwater;
        [NMS(Size = 3)]
        /* 0xB88 */ public NMSString0x80[] PrefetchScenegraphResources;
        [NMS(Size = 2)]
        /* 0xD08 */ public NMSString0x80[] PrefetchMaterialResources;
        [NMS(Size = 0x80)]
        /* 0xE08 */ public string PlanetAtmosphereFile;
        [NMS(Size = 0x80)]
        /* 0xE88 */ public string PlanetAtmosphereMaterialFile;
        [NMS(Size = 0x80)]
        /* 0xF08 */ public string PlanetRingFile;
        [NMS(Size = 0x80)]
        /* 0xF88 */ public string PlanetRingMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x1008 */ public string PlanetMaterialFile;
        [NMS(Size = 0x80)]
        /* 0x1088 */ public string PlaterWaterMaterialFile;
        [NMS(Size = 6)]
        /* 0x1108 */ public NMSString0x80[] PlanetTerrainMaterials;
        [NMS(Size = 0x10)]
        /* 0x1408 */ public NMSString0x80[] PrefetchTextureResources;
        [NMS(Size = 0x80)]
        /* 0x1C08 */ public string WarpTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1C88 */ public string BlackHoleTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1D08 */ public string TeleportTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1D88 */ public string PortalTunnelFile;
        [NMS(Size = 0x80)]
        /* 0x1E08 */ public string PortalStoryTunnelFile;
    }
}

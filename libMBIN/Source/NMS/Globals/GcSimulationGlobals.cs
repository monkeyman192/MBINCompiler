using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x3FEF7F584D60D980, NameHash = 0xD1D7201E3228DD7B)]
    public class GcSimulationGlobals : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 StartingSceneFile;
        /* 0x080 */ public List<GcMultitoolPoolData> MultitoolPool;
        /* 0x090 */ public ulong ProceduralBuildingsGenerationSeed;
        /* 0x098 */ public NMSString0x80 SpaceStationFile;
        /* 0x118 */ public NMSString0x80 NexusFile;
        /* 0x198 */ public NMSString0x80 NexusExteriorFile;
        /* 0x218 */ public NMSString0x80 PlaceMarkerFile;
        /* 0x298 */ public NMSString0x80 AbandonedSpaceStationFile;
        /* 0x318 */ public NMSString0x80 PirateSystemSpaceStationFile;
        /* 0x398 */ public List<NMSString0x80> BlackHoleAnomalies;
        /* 0x3A8 */ public List<NMSString0x80> AtlasStationAnomalies;
        /* 0x3B8 */ public NMSString0x80 None;
        /* 0x438 */ public NMSString0x80 PlacementDroneFile;
        /* 0x4B8 */ public NMSString0x80 HeavyAirCave;
        /* 0x538 */ public NMSString0x80 HeavyAirUnderwater;
        /* 0x5B8 */ public NMSString0x80 HeavyAirAbandonedFreighter;
        /* 0x638 */ public NMSString0x80 HeavyAirSpaceStorm;
        /* 0x6B8 */ public List<NMSString0x80> PrefetchScenegraphResources;
        /* 0x6C8 */ public List<NMSString0x80> PrefetchMaterialResources;
        /* 0x6D8 */ public NMSString0x80 PlanetAtmosphereFile;
        /* 0x758 */ public NMSString0x80 PlanetAtmosphereMaterialFile;
        /* 0x7D8 */ public NMSString0x80 PlanetRingFile;
        /* 0x858 */ public NMSString0x80 PlanetRingMaterialFile;
        /* 0x8D8 */ public NMSString0x80 PlanetMaterialFile;
        /* 0x958 */ public NMSString0x80 PlaterWaterMaterialFile;
        /* 0x9D8 */ public List<NMSString0x80> PlanetTerrainMaterials;
        /* 0x9E8 */ public List<NMSString0x80> PrefetchTextureResources;
        /* 0x9F8 */ public float WarpTunnelScale;
        /* 0x9FC */ public NMSString0x80 WarpTunnelFile;
        /* 0xA7C */ public NMSString0x80 BlackHoleTunnelFile;
        /* 0xAFC */ public NMSString0x80 TeleportTunnelFile;
        /* 0xB7C */ public NMSString0x80 PortalTunnelFile;
        /* 0xBFC */ public NMSString0x80 PortalStoryTunnelFile;
    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0xBF0, GUID = 0x49EEE64199B4DFF2, NameHash = 0xD1D7201E3228DD7B)]
    public class GcSimulationGlobals : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 StartingSceneFile;
        /* 0x080 */ public NMSString0x80 MultitoolFile;
        /* 0x100 */ public ulong ProceduralBuildingsGenerationSeed;
        /* 0x108 */ public NMSString0x80 SpaceStationFile;
        /* 0x188 */ public NMSString0x80 NexusFile;
        /* 0x208 */ public NMSString0x80 NexusExteriorFile;
        /* 0x288 */ public NMSString0x80 PlaceMarkerFile;
        /* 0x308 */ public NMSString0x80 AbandonedSpaceStationFile;
        /* 0x388 */ public List<NMSString0x80> BlackHoleAnomalies;
        /* 0x398 */ public List<NMSString0x80> AtlasStationAnomalies;
        /* 0x3A8 */ public NMSString0x80 None;
        /* 0x428 */ public NMSString0x80 PlacementDroneFile;
        /* 0x4A8 */ public NMSString0x80 HeavyAirCave;
        /* 0x528 */ public NMSString0x80 HeavyAirUnderwater;
        /* 0x5A8 */ public NMSString0x80 HeavyAirAbandonedFreighter;
        /* 0x628 */ public List<NMSString0x80> PrefetchScenegraphResources;
        /* 0x638 */ public List<NMSString0x80> PrefetchMaterialResources;
        /* 0x648 */ public NMSString0x80 PlanetAtmosphereFile;
        /* 0x6C8 */ public NMSString0x80 PlanetAtmosphereMaterialFile;
        /* 0x748 */ public NMSString0x80 PlanetRingFile;
        /* 0x7C8 */ public NMSString0x80 PlanetRingMaterialFile;
        /* 0x848 */ public NMSString0x80 PlanetMaterialFile;
        /* 0x8C8 */ public NMSString0x80 PlaterWaterMaterialFile;
        /* 0x948 */ public List<NMSString0x80> PlanetTerrainMaterials;
        /* 0x958 */ public List<NMSString0x80> PrefetchTextureResources;
        /* 0x968 */ public float WarpTunnelScale;
        /* 0x96C */ public NMSString0x80 WarpTunnelFile;
        /* 0x9EC */ public NMSString0x80 BlackHoleTunnelFile;
        /* 0xA6C */ public NMSString0x80 TeleportTunnelFile;
        /* 0xAEC */ public NMSString0x80 PortalTunnelFile;
        /* 0xB6C */ public NMSString0x80 PortalStoryTunnelFile;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xBEC */ public byte[] EndPadding;
    }
}

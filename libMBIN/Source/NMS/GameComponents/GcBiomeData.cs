using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5EA924B84E8AD457, NameHash = 0x2FD5560612237D4D)]
    public class GcBiomeData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 TextureFile;
        /* 0x080 */ public NMSString0x80 OverlayFile;
        /* 0x100 */ public NMSString0x80 TileTypesFile;
        /* 0x180 */ public NMSString0x80 ColourPaletteFile;
        /* 0x200 */ public NMSString0x80 LegacyColourPaletteFile;
        /* 0x280 */ public GcMiningSubstanceData MiningSubstance1;
        /* 0x28C */ public GcMiningSubstanceData MiningSubstance2;
        /* 0x298 */ public GcMiningSubstanceData MiningSubstance3;
        /* 0x2A4 */ public float FuelMultiplier;
        /* 0x2B0 */ public GcPlanetWaterData Water;
        /* 0x430 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x440 */ public GcWeatherWeightings[] WeatherOptions;
        /* 0x540 */ public Vector2f WeatherChangeTime;
        /* 0x550 */ public GcBiomeCloudSettings CloudSettings;
        /* 0x5A0 */ public GcTerrainControls Terrain;
        /* 0x618 */ public List<GcScreenFilterOption> FilterOptions;
        /* 0x628 */ public NMSString0x20A FloraLifeLocID;
    }
}

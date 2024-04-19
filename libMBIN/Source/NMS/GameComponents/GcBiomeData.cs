using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CBE36B08EA2C89, NameHash = 0x2FD5560612237D4D)]
    public class GcBiomeData : NMSTemplate
    {
        /* 0x000 */ public GcPlanetWaterData Water;
        /* 0x180 */ public GcBiomeCloudSettings CloudSettings;
        /* 0x1D0 */ public NMSString0x20A FloraLifeLocID;
        /* 0x1F0 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        /* 0x200 */ public List<GcScreenFilterOption> FilterOptions;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x210 */ public GcWeatherWeightings[] WeatherOptions;
        /* 0x310 */ public GcTerrainControls Terrain;
        /* 0x388 */ public GcMiningSubstanceData MiningSubstance1;
        /* 0x394 */ public GcMiningSubstanceData MiningSubstance2;
        /* 0x3A0 */ public GcMiningSubstanceData MiningSubstance3;
        /* 0x3AC */ public Vector2f WeatherChangeTime;
        /* 0x3B4 */ public float FuelMultiplier;
        /* 0x3B8 */ public NMSString0x80 ColourPaletteFile;
        /* 0x438 */ public NMSString0x80 LegacyColourPaletteFile;
        /* 0x4B8 */ public NMSString0x80 OverlayFile;
        /* 0x538 */ public NMSString0x80 TextureFile;
        /* 0x5B8 */ public NMSString0x80 TileTypesFile;
    }
}

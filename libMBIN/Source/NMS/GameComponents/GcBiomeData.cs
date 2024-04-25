using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CBE36B08EA2C89, NameHash = 0x2FD5560612237D4D)]
    public class GcBiomeData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public GcPlanetWaterData Water;
        [NMS(Index = 13)]
        /* 0x180 */ public GcBiomeCloudSettings CloudSettings;
        [NMS(Index = 16)]
        /* 0x1D0 */ public NMSString0x20A FloraLifeLocID;
        [NMS(Index = 10)]
        /* 0x1F0 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        [NMS(Index = 15)]
        /* 0x200 */ public List<GcScreenFilterOption> FilterOptions;
        [NMS(Index = 11, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x210 */ public GcWeatherWeightings[] WeatherOptions;
        [NMS(Index = 14)]
        /* 0x310 */ public GcTerrainControls Terrain;
        [NMS(Index = 5)]
        /* 0x388 */ public GcMiningSubstanceData MiningSubstance1;
        [NMS(Index = 6)]
        /* 0x394 */ public GcMiningSubstanceData MiningSubstance2;
        [NMS(Index = 7)]
        /* 0x3A0 */ public GcMiningSubstanceData MiningSubstance3;
        [NMS(Index = 12)]
        /* 0x3AC */ public Vector2f WeatherChangeTime;
        [NMS(Index = 8)]
        /* 0x3B4 */ public float FuelMultiplier;
        [NMS(Index = 3)]
        /* 0x3B8 */ public NMSString0x80 ColourPaletteFile;
        [NMS(Index = 4)]
        /* 0x438 */ public NMSString0x80 LegacyColourPaletteFile;
        [NMS(Index = 1)]
        /* 0x4B8 */ public NMSString0x80 OverlayFile;
        [NMS(Index = 0)]
        /* 0x538 */ public NMSString0x80 TextureFile;
        [NMS(Index = 2)]
        /* 0x5B8 */ public NMSString0x80 TileTypesFile;
    }
}

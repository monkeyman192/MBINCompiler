using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CE0F372B4EC0F32, NameHash = 0x79FEF5EB)]
    public class GcBiomeData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public GcPlanetWaterData Water;
        [NMS(Index = 14)]
        /* 0x1B0 */ public GcBiomeCloudSettings CloudSettings;
        [NMS(Index = 17)]
        /* 0x210 */ public NMSString0x20A FloraLifeLocID;
        [NMS(Index = 3)]
        /* 0x230 */ public VariableSizeString ColourPaletteFile;
        [NMS(Index = 10)]
        /* 0x240 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        [NMS(Index = 16)]
        /* 0x250 */ public List<GcScreenFilterOption> FilterOptions;
        [NMS(Index = 4)]
        /* 0x260 */ public VariableSizeString LegacyColourPaletteFile;
        [NMS(Index = 1)]
        /* 0x270 */ public VariableSizeString OverlayFile;
        [NMS(Index = 0)]
        /* 0x280 */ public VariableSizeString TextureFile;
        [NMS(Index = 2)]
        /* 0x290 */ public VariableSizeString TileTypesFile;
        [NMS(Index = 11, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x2A0 */ public GcWeatherWeightings[] WeatherOptions;
        [NMS(Index = 15)]
        /* 0x3E0 */ public GcTerrainControls Terrain;
        [NMS(Index = 5)]
        /* 0x458 */ public GcMiningSubstanceData MiningSubstance1;
        [NMS(Index = 6)]
        /* 0x464 */ public GcMiningSubstanceData MiningSubstance2;
        [NMS(Index = 7)]
        /* 0x470 */ public GcMiningSubstanceData MiningSubstance3;
        [NMS(Index = 12)]
        /* 0x47C */ public Vector2f WeatherChangeTime;
        [NMS(Index = 13)]
        /* 0x484 */ public float DarknessVariation;
        [NMS(Index = 8)]
        /* 0x488 */ public float FuelMultiplier;
    }
}

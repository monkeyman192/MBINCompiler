using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x491B5F597EF2D5DD, NameHash = 0x17A032B6)]
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x0000 */ public GcPlanetColourData Colours;
        [NMS(Index = 14)]
        /* 0x1B90 */ public GcPlanetWaterData Water;
        [NMS(Index = 12)]
        /* 0x1D40 */ public GcPlanetWeatherData Weather;
        [NMS(Index = 11, Size = 0x17)]
        /* 0x1EC0 */ public Colour[] TileColours;
        [NMS(Index = 25)]
        /* 0x2030 */ public GcPlanetRingData Rings;
        [NMS(Index = 16)]
        /* 0x2090 */ public TkVoxelGeneratorData Terrain;
        [NMS(Index = 22)]
        /* 0x31E0 */ public GcPlanetGenerationIntermediateData GenerationData;
        [NMS(Index = 19)]
        /* 0x3338 */ public GcEnvironmentSpawnData SpawnData;
        [NMS(Index = 21)]
        /* 0x3398 */ public GcPlanetBuildingData BuildingData;
        [NMS(Index = 13)]
        /* 0x33E0 */ public GcPlanetCloudProperties Clouds;
        [NMS(Index = 6)]
        /* 0x3428 */ public NMSString0x10 CommonSubstanceID;
        [NMS(Index = 9)]
        /* 0x3438 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        [NMS(Index = 8)]
        /* 0x3448 */ public NMSString0x10 RareSubstanceID;
        [NMS(Index = 15)]
        /* 0x3458 */ public VariableSizeString TerrainFile;
        [NMS(Index = 18)]
        /* 0x3468 */ public List<int> TileTypeIndices;
        [NMS(Index = 7)]
        /* 0x3478 */ public NMSString0x10 UncommonSubstanceID;
        [NMS(Index = 3)]
        /* 0x3488 */ public GcPlanetHazardData Hazard;
        [NMS(Index = 23, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x34EC */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        [NMS(Index = 5)]
        /* 0x354C */ public GcBuildingDensityLevels BuildingLevel;
        [NMS(Index = 2)]
        /* 0x3550 */ public GcPlanetLife CreatureLife;
        [NMS(Index = 28)]
        /* 0x3554 */ public float FuelMultiplier;
        [NMS(Index = 20)]
        /* 0x3558 */ public GcAlienRace InhabitingRace;
        [NMS(Index = 1)]
        /* 0x355C */ public GcPlanetLife Life;
        // size: 0x2
        public enum ResourceLevelEnum : uint {
            Low,
            High,
        }
        [NMS(Index = 4)]
        /* 0x3560 */ public ResourceLevelEnum ResourceLevel;
        [NMS(Index = 17)]
        /* 0x3564 */ public int TileTypeSet;
        [NMS(Index = 24)]
        /* 0x3568 */ public GcPlanetInfo PlanetInfo;
        [NMS(Index = 0)]
        /* 0x3A6E */ public NMSString0x80 Name;
        [NMS(Index = 27)]
        /* 0x3AEE */ public bool InAbandonedSystem;
        [NMS(Index = 26)]
        /* 0x3AEF */ public bool InEmptySystem;
    }
}

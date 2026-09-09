using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86CD44C3FA1F7AD5, NameHash = 0x17A032B6)]
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x0000 */ public GcPlanetColourData Colours;
        [NMS(Index = 14)]
        /* 0x1CE0 */ public GcPlanetWeatherData Weather;
        [NMS(Index = 13, Size = 0x17)]
        /* 0x1E60 */ public Colour[] TileColours;
        [NMS(Index = 27)]
        /* 0x1FD0 */ public GcPlanetRingData Rings;
        [NMS(Index = 18)]
        /* 0x2030 */ public TkVoxelGeneratorData Terrain;
        [NMS(Index = 24)]
        /* 0x3180 */ public GcPlanetGenerationIntermediateData GenerationData;
        [NMS(Index = 21)]
        /* 0x32D8 */ public GcEnvironmentSpawnData SpawnData;
        [NMS(Index = 23)]
        /* 0x3338 */ public GcPlanetBuildingData BuildingData;
        [NMS(Index = 15)]
        /* 0x3388 */ public GcPlanetCloudProperties Clouds;
        [NMS(Index = 6)]
        /* 0x33D0 */ public NMSString0x10 CommonSubstanceID;
        [NMS(Index = 11)]
        /* 0x33E0 */ public List<NMSString0x10> CreatureIDs;
        [NMS(Index = 10)]
        /* 0x33F0 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        [NMS(Index = 8)]
        /* 0x3400 */ public NMSString0x10 RareSubstanceID;
        [NMS(Index = 17)]
        /* 0x3410 */ public GcFilename TerrainFile;
        [NMS(Index = 20)]
        /* 0x3420 */ public List<int> TileTypeIndices;
        [NMS(Index = 7)]
        /* 0x3430 */ public NMSString0x10 UncommonSubstanceID;
        [NMS(Index = 3)]
        /* 0x3440 */ public GcPlanetHazardData Hazard;
        [NMS(Index = 25, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x34B8 */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        [NMS(Index = 16)]
        /* 0x3518 */ public GcPlanetWaterData Water;
        [NMS(Index = 5)]
        /* 0x3528 */ public GcBuildingDensityLevels BuildingLevel;
        [NMS(Index = 2)]
        /* 0x352C */ public GcPlanetLife CreatureLife;
        [NMS(Index = 31)]
        /* 0x3530 */ public float FuelMultiplier;
        [NMS(Index = 22)]
        /* 0x3534 */ public GcAlienRace InhabitingRace;
        [NMS(Index = 1)]
        /* 0x3538 */ public GcPlanetLife Life;
        [NMS(Index = 32)]
        /* 0x353C */ public int PlanetIndex;
        // size: 0x2
        public enum ResourceLevelEnum : uint {
            Low,
            High,
        }
        [NMS(Index = 4)]
        /* 0x3540 */ public ResourceLevelEnum ResourceLevel;
        [NMS(Index = 19)]
        /* 0x3544 */ public int TileTypeSet;
        [NMS(Index = 26)]
        /* 0x3548 */ public GcPlanetInfo PlanetInfo;
        [NMS(Index = 0)]
        /* 0x3A4E */ public NMSString0x80 Name;
        [NMS(Index = 9)]
        /* 0x3ACE */ public bool HasScrap;
        [NMS(Index = 29)]
        /* 0x3ACF */ public bool InAbandonedSystem;
        [NMS(Index = 28)]
        /* 0x3AD0 */ public bool InEmptySystem;
        [NMS(Index = 30)]
        /* 0x3AD1 */ public bool InGasGiantSystem;
    }
}

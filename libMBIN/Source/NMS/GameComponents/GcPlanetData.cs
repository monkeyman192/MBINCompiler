using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEAA440AFB0C1436, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x0000 */ public GcPlanetColourData Colours;
        [NMS(Index = 14)]
        /* 0x1B90 */ public GcPlanetWaterData Water;
        [NMS(Index = 11, Size = 0x17)]
        /* 0x1D10 */ public Colour[] TileColours;
        [NMS(Index = 12)]
        /* 0x1E80 */ public GcPlanetWeatherData Weather;
        [NMS(Index = 25)]
        /* 0x1FD0 */ public GcPlanetRingData Rings;
        [NMS(Index = 16)]
        /* 0x2030 */ public TkVoxelGeneratorData Terrain;
        [NMS(Index = 22)]
        /* 0x3570 */ public GcPlanetGenerationIntermediateData GenerationData;
        [NMS(Index = 19)]
        /* 0x39D8 */ public GcEnvironmentSpawnData SpawnData;
        [NMS(Index = 21)]
        /* 0x3A38 */ public GcPlanetBuildingData BuildingData;
        [NMS(Index = 13)]
        /* 0x3A80 */ public GcPlanetCloudProperties Clouds;
        [NMS(Index = 6)]
        /* 0x3AC0 */ public NMSString0x10 CommonSubstanceID;
        [NMS(Index = 9)]
        /* 0x3AD0 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        [NMS(Index = 8)]
        /* 0x3AE0 */ public NMSString0x10 RareSubstanceID;
        [NMS(Index = 18)]
        /* 0x3AF0 */ public List<int> TileTypeIndices;
        [NMS(Index = 7)]
        /* 0x3B00 */ public NMSString0x10 UncommonSubstanceID;
        [NMS(Index = 23, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x3B10 */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        [NMS(Index = 3)]
        /* 0x3B70 */ public GcPlanetHazardData Hazard;
        [NMS(Index = 5)]
        /* 0x3BC0 */ public GcBuildingDensityLevels BuildingLevel;
        [NMS(Index = 2)]
        /* 0x3BC4 */ public GcPlanetLife CreatureLife;
        [NMS(Index = 28)]
        /* 0x3BC8 */ public float FuelMultiplier;
        [NMS(Index = 20)]
        /* 0x3BCC */ public GcAlienRace InhabitingRace;
        [NMS(Index = 1)]
        /* 0x3BD0 */ public GcPlanetLife Life;
        // size: 0x2
        public enum ResourceLevelEnum : uint {
            Low,
            High,
        }
        [NMS(Index = 4)]
        /* 0x3BD4 */ public ResourceLevelEnum ResourceLevel;
        [NMS(Index = 17)]
        /* 0x3BD8 */ public int TileTypeSet;
        [NMS(Index = 24)]
        /* 0x3BDC */ public GcPlanetInfo PlanetInfo;
        [NMS(Index = 0)]
        /* 0x40E1 */ public NMSString0x80 Name;
        [NMS(Index = 15)]
        /* 0x4161 */ public NMSString0x80 TerrainFile;
        [NMS(Index = 27)]
        /* 0x41E1 */ public bool InAbandonedSystem;
        [NMS(Index = 26)]
        /* 0x41E2 */ public bool InEmptySystem;
    }
}

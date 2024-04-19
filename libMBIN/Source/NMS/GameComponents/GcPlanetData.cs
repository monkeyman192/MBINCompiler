using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x612ED200C9C258B0, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        /* 0x0000 */ public GcPlanetColourData Colours;
        /* 0x1B90 */ public GcPlanetWaterData Water;
        [NMS(Size = 0x17)]
        /* 0x1D10 */ public Colour[] TileColours;
        /* 0x1E80 */ public GcPlanetWeatherData Weather;
        /* 0x1FD0 */ public GcPlanetRingData Rings;
        /* 0x2030 */ public TkVoxelGeneratorData Terrain;
        /* 0x3570 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x39D8 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3A38 */ public GcPlanetBuildingData BuildingData;
        /* 0x3A80 */ public GcPlanetCloudProperties Clouds;
        /* 0x3AC0 */ public NMSString0x10 CommonSubstanceID;
        /* 0x3AD0 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x3AE0 */ public NMSString0x10 RareSubstanceID;
        /* 0x3AF0 */ public List<int> TileTypeIndices;
        /* 0x3B00 */ public NMSString0x10 UncommonSubstanceID;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x3B10 */ public GcPlanetGroundCombatData[] GroundCombatDataPerDifficulty;
        /* 0x3B70 */ public GcPlanetHazardData Hazard;
        /* 0x3BC0 */ public GcBuildingDensityLevels BuildingLevel;
        /* 0x3BC4 */ public GcPlanetLife CreatureLife;
        /* 0x3BC8 */ public float FuelMultiplier;
        /* 0x3BCC */ public GcAlienRace InhabitingRace;
        /* 0x3BD0 */ public GcPlanetLife Life;
        // size: 0x2
        public enum ResourceLevelEnum : uint {
            Low,
            High,
        }
        /* 0x3BD4 */ public ResourceLevelEnum ResourceLevel;
        /* 0x3BD8 */ public int TileTypeSet;
        /* 0x3BDC */ public GcPlanetInfo PlanetInfo;
        /* 0x40E1 */ public NMSString0x80 Name;
        /* 0x4161 */ public NMSString0x80 TerrainFile;
        /* 0x41E1 */ public bool InAbandonedSystem;
        /* 0x41E2 */ public bool InEmptySystem;
    }
}

using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3BB0)]
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public string Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;
        
        public enum ResourceLevelEnum { Low, High }
        /* 0x00D8 */ public ResourceLevelEnum ResourceLevel;

        /* 0x00DC */ public GcBuildingDensityLevels BuildingLevel;
        
        [NMS(Size = 0x10)]
        /* 0x00E0 */ public string CommonSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x00F0 */ public string UncommonSubstanceID;
        [NMS(Size = 0x10)]
        /* 0x0100 */ public string RareSubstanceID;
        
        /* 0x0110 */ public List<NMSString0x10> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;

        [NMS(Size = 0x17)]
        /* 0x17E0 */ public Colour[] TileColours;
        /* 0x1950 */ public GcPlanetWeatherData Weather;
        /* 0x1AA0 */ public GcPlanetCloudProperties Clouds;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1AC8 */ public byte[] Padding1AC8; 
        /* 0x1AD0 */ public GcPlanetWaterData Water;
        [NMS(Size = 0x80)]
        /* 0x1CA0 */ public string TerrainFile;
        /* 0x1D20 */ public TkVoxelGeneratorData Terrain;
        /* 0x32F0 */ public int TileTypeSet;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x32F4 */ public byte[] Padding32F4; 
        /* 0x32F8 */ public List<int> TileTypeIndices;
        /* 0x3308 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3368 */ public GcAlienRace InhabitingRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x336C */ public byte[] Padding336C; 
        /* 0x3370 */ public GcPlanetBuildingData BuildingData;
        /* 0x33E0 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x37B0 */ public Vector2f SentinelTimer;
        /* 0x37B8 */ public Vector2f FlybyTimer;
        /* 0x37C0 */ public GcPlanetInfo PlanetInfo;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x3B42 */ public byte[] Padding3B42; 
        /* 0x3B44 */ public GcPlanetSentinelData SentinelData;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3B4C */ public byte[] Padding3B4C; 
        /* 0x3B50 */ public GcPlanetRingData Rings;

    }
}

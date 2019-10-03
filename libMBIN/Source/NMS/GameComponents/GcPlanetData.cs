using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3BF0, GUID = 0xEA135C851740A564, NameHash = 0x25EDFA0EC4C3AF0A)]
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
        
        /* 0x0110 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;

        [NMS(Size = 0x17)]
        /* 0x17E0 */ public Colour[] TileColours;
        /* 0x1950 */ public GcPlanetWeatherData Weather;
        /* 0x1AA0 */ public GcPlanetCloudProperties Clouds;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1AC8 */ public byte[] Padding1AC8; 
        /* 0x1AD0 */ public GcPlanetWaterData Water;
        [NMS(Size = 0x80)]
        /* 0x1C50 */ public string TerrainFile;
        /* 0x1CD0 */ public TkVoxelGeneratorData Terrain;
        /* 0x32A0 */ public int TileTypeSet;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x32A4 */ public byte[] Padding32A4; 
        /* 0x32A8 */ public List<int> TileTypeIndices;
        /* 0x32B8 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3318 */ public GcAlienRace InhabitingRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x331C */ public byte[] Padding331C; 
        /* 0x3320 */ public GcPlanetBuildingData BuildingData;
        /* 0x3390 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x37E0 */ public Vector2f SentinelTimer;
        /* 0x37E8 */ public Vector2f FlybyTimer;
        /* 0x37F0 */ public GcPlanetInfo PlanetInfo;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x3B73 */ public byte[] Padding3B73; 
        /* 0x3B74 */ public GcPlanetSentinelData SentinelData;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3B7C */ public byte[] Padding3B7C; 
        /* 0x3B80 */ public GcPlanetRingData Rings;
        /* 0x3BE0 */ public bool InEmptySystem;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x3BE1 */ public byte[] EndPadding;

    }
}

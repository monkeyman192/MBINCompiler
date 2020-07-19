using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3D40, GUID = 0x59703BCB6D488120, NameHash = 0x25EDFA0EC4C3AF0A)]
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
        /* 0x1930 */ public Colour[] TileColours;
        /* 0x1AA0 */ public GcPlanetWeatherData Weather;
        /* 0x1BF0 */ public GcPlanetCloudProperties Clouds;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1C18 */ public byte[] Padding1C18; 
        /* 0x1C20 */ public GcPlanetWaterData Water;
        [NMS(Size = 0x80)]
        /* 0x1DA0 */ public string TerrainFile;
        /* 0x1E20 */ public TkVoxelGeneratorData Terrain;
        /* 0x33F0 */ public int TileTypeSet;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x33F4 */ public byte[] Padding33F4; 
        /* 0x33F8 */ public List<int> TileTypeIndices;
        /* 0x3408 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3468 */ public GcAlienRace InhabitingRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x346C */ public byte[] Padding346C; 
        /* 0x3470 */ public GcPlanetBuildingData BuildingData;
        /* 0x34E0 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x3930 */ public Vector2f SentinelTimer;
        /* 0x3938 */ public Vector2f FlybyTimer;
        /* 0x3940 */ public GcPlanetInfo PlanetInfo;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x3CC3 */ public byte[] Padding3CC3; 
        /* 0x3CC4 */ public GcPlanetSentinelData SentinelData;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3CCC */ public byte[] Padding3CCC; 
        /* 0x3CD0 */ public GcPlanetRingData Rings;
        /* 0x3D30 */ public bool InEmptySystem;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x3D31 */ public byte[] EndPadding;

    }
}

using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3D80, GUID = 0x3B32E4127BBB1770, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;
        public enum ResourceLevelEnum { Low, High }
        /* 0x00D8 */ public ResourceLevelEnum ResourceLevel;
        /* 0x00DC */ public GcBuildingDensityLevels BuildingLevel;
        /* 0x00E0 */ public NMSString0x10 CommonSubstanceID;
        /* 0x00F0 */ public NMSString0x10 UncommonSubstanceID;
        /* 0x0100 */ public NMSString0x10 RareSubstanceID;
        /* 0x0110 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;
        [NMS(Size = 0x17)]
        /* 0x1930 */ public Colour[] TileColours;
        /* 0x1AA0 */ public GcPlanetWeatherData Weather;
        /* 0x1C00 */ public GcPlanetCloudProperties Clouds;
        /* 0x1C40 */ public GcPlanetWaterData Water;
        /* 0x1DC0 */ public NMSString0x80 TerrainFile;
        /* 0x1E40 */ public TkVoxelGeneratorData Terrain;
        /* 0x3410 */ public int TileTypeSet;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3414 */ public byte[] Padding3414; 
        /* 0x3418 */ public List<int> TileTypeIndices;
        /* 0x3428 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x3488 */ public GcAlienRace InhabitingRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x348C */ public byte[] Padding348C; 
        /* 0x3490 */ public GcPlanetBuildingData BuildingData;
        /* 0x3500 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x3968 */ public Vector2f SentinelTimer;
        /* 0x3970 */ public Vector2f FlybyTimer;
        /* 0x3978 */ public GcPlanetInfo PlanetInfo;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x3CFB */ public byte[] Padding3CFB; 
        /* 0x3CFC */ public GcPlanetSentinelData SentinelData;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3D04 */ public byte[] Padding3D04; 
        /* 0x3D10 */ public GcPlanetRingData Rings;
        /* 0x3D70 */ public bool InEmptySystem;
        /* 0x3D71 */ public bool InAbandonedSystem;
        /* 0x3D74 */ public float FuelMultiplier;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3D78 */ public byte[] EndPadding;
    }
}


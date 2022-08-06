using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE775EECEA7BCF980, NameHash = 0x25EDFA0EC4C3AF0A)]
    public class GcPlanetData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Name;
        /* 0x0080 */ public GcPlanetLife Life;
        /* 0x0084 */ public GcPlanetLife CreatureLife;
        /* 0x0088 */ public GcPlanetHazardData Hazard;
        // size: 0x2
        public enum ResourceLevelEnum { Low, High }
        /* 0x00D8 */ public ResourceLevelEnum ResourceLevel;
        /* 0x00DC */ public GcBuildingDensityLevels BuildingLevel;
        /* 0x00E0 */ public NMSString0x10 CommonSubstanceID;
        /* 0x00F0 */ public NMSString0x10 UncommonSubstanceID;
        /* 0x0100 */ public NMSString0x10 RareSubstanceID;
        /* 0x0110 */ public List<GcPlanetDataResourceHint> ExtraResourceHints;
        /* 0x0120 */ public GcPlanetColourData Colours;
        [NMS(Size = 0x17)]
        /* 0x1A80 */ public Colour[] TileColours;
        /* 0x1BF0 */ public GcPlanetWeatherData Weather;
        /* 0x1D50 */ public GcPlanetCloudProperties Clouds;
        /* 0x1D90 */ public GcPlanetWaterData Water;
        /* 0x1F10 */ public NMSString0x80 TerrainFile;
        /* 0x1F90 */ public TkVoxelGeneratorData Terrain;
        /* 0x3560 */ public int TileTypeSet;
        /* 0x3568 */ public List<int> TileTypeIndices;
        /* 0x3578 */ public GcEnvironmentSpawnData SpawnData;
        /* 0x35D8 */ public GcAlienRace InhabitingRace;
        /* 0x35E0 */ public GcPlanetBuildingData BuildingData;
        /* 0x3628 */ public GcPlanetGenerationIntermediateData GenerationData;
        /* 0x3A90 */ public Vector2f SentinelTimer;
        /* 0x3A98 */ public Vector2f FlybyTimer;
        /* 0x3AA0 */ public GcPlanetInfo PlanetInfo;
        /* 0x3E24 */ public GcPlanetSentinelData SentinelData;
        /* 0x3E30 */ public GcPlanetRingData Rings;
        /* 0x3E90 */ public bool InEmptySystem;
        /* 0x3E91 */ public bool InAbandonedSystem;
        /* 0x3E94 */ public float FuelMultiplier;
    }
}

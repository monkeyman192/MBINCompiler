using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1DA0, Alignment = 0x10, GUID = 0xE5A2E6412933D6B3, NameHash = 0x9B09276BB2795541)]
    public class GcSolarSystemData : NMSTemplate {

        /* 0x0000 */ public GcSeed Seed;
        [NMS(Size = 0x80)]
        /* 0x0010 */ public string Name;
        /* 0x0090 */ public GcSolarSystemClass Class;
        /* 0x0094 */ public GcGalaxyStarTypes StarType;
        /* 0x0098 */ public int Planets;
        [NMS(Size = 8)]
        /* 0x00A0 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 8)]
        /* 0x0120 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Size = 8)]
        /* 0x0360 */ public int[] PlanetOrbits;
        /* 0x0380 */ public Vector4f SunPosition;
        [NMS(Size = 0x10)]
        /* 0x0390 */ public string AsteroidSubstanceID;
        /* 0x03A0 */ public int NumTradeRoutes;
        /* 0x03A4 */ public int NumVisibleTradeRoutes;
        /* 0x03A8 */ public int MaxNumFreighters;
        /* 0x03AC */ public bool StartWithFreighters;

        /* 0x03B0 */ public Vector2f FreighterTimer;
        /* 0x03B8 */ public Vector2f PirateTimer;
        /* 0x03C0 */ public Vector2f FlybyTimer;

        /* 0x03D0 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x0510 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x0524 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x0538 */ public List<GcSolarSystemLocator> Locators;
        /* 0x0548 */ public List<NMSTemplate> AsteroidGenerators;

		public enum AsteroidLevelEnum { NoRares, SomeRares, LotsOfRares }
		/* 0x0558 */ public AsteroidLevelEnum AsteroidLevel;
        
        /* 0x0560 */ public GcPlanetColourData PlanetColours;
        
        /* 0x1C20 */ public GcLightProperties Light;
        /* 0x1C50 */ public GcSpaceSkyProperties Sky;
        
        /* 0x1CF0 */ public GcScreenFilters ScreenFilter;
        
        [NMS(Size = 0x80)] 
        /* 0x1CF4 */ public string HeavyAir;
        
        /* 0x1D78 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        /* 0x1D88 */ public GcAlienRace InhabitingRace;
        /* 0x1D8C */ public GcPlanetTradingData TradingData;
        /* 0x1D94 */ public GcPlayerConflictData ConflictData;
        
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1D98 */ public byte[] Padding1DA0;
        
    }

}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2B492508DB5AF13, NameHash = 0xC6DB83D2)]
    public class GcSolarSystemData : NMSTemplate
    {
        [NMS(Index = 27)]
        /* 0x0000 */ public GcPlanetColourData Colours;
        [NMS(Index = 9, Size = 0x20, MxmlName = "Space Poi Positions")]
        /* 0x1CE0 */ public Vector3f[] SpacePoiPositions;
        [NMS(Index = 21)]
        /* 0x1EE0 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        [NMS(Index = 29)]
        /* 0x2020 */ public GcSpaceSkyProperties Sky;
        [NMS(Index = 5, Size = 0x8, MxmlName = "Planet Positions")]
        /* 0x20C0 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 28)]
        /* 0x2140 */ public GcLightProperties Light;
        [NMS(Index = 10)]
        /* 0x2170 */ public Vector3f SunPosition;
        [NMS(Index = 6, Size = 0x8, MxmlName = "Planet Generation Inputs")]
        /* 0x2180 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Index = 25)]
        /* 0x2440 */ public List<NMSTemplate> AsteroidGenerators;
        [NMS(Index = 11)]
        /* 0x2450 */ public NMSString0x10 AsteroidSubstanceID;
        [NMS(Index = 31)]
        /* 0x2460 */ public GcFilename HeavyAir;
        [NMS(Index = 24)]
        /* 0x2470 */ public List<GcSolarSystemLocator> Locators;
        [NMS(Index = 0)]
        /* 0x2480 */ public GcSeed Seed;
        [NMS(Index = 33)]
        /* 0x2490 */ public GcSeed SentinelCrashSiteShipSeed;
        [NMS(Index = 32)]
        /* 0x24A0 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        [NMS(Index = 7, Size = 0x8, MxmlName = "Planet Orbits")]
        /* 0x24B0 */ public int[] PlanetOrbits;
        [NMS(Index = 23)]
        /* 0x24D0 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        [NMS(Index = 22)]
        /* 0x24E4 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        [NMS(Index = 19)]
        /* 0x24F8 */ public Vector2f FlybyTimer;
        [NMS(Index = 16)]
        /* 0x2500 */ public Vector2f FreighterTimer;
        [NMS(Index = 18)]
        /* 0x2508 */ public Vector2f PlanetPirateTimer;
        [NMS(Index = 20)]
        /* 0x2510 */ public Vector2f PoliceTimer;
        [NMS(Index = 17)]
        /* 0x2518 */ public Vector2f SpacePirateTimer;
        [NMS(Index = 35)]
        /* 0x2520 */ public GcPlanetTradingData TradingData;
        // size: 0x3
        public enum AsteroidLevelEnum : uint {
            NoRares,
            SomeRares,
            LotsOfRares,
        }
        [NMS(Index = 26)]
        /* 0x2528 */ public AsteroidLevelEnum AsteroidLevel;
        [NMS(Index = 2)]
        /* 0x252C */ public GcSolarSystemClass Class;
        [NMS(Index = 36)]
        /* 0x2530 */ public GcPlayerConflictData ConflictData;
        [NMS(Index = 34)]
        /* 0x2534 */ public GcAlienRace InhabitingRace;
        [NMS(Index = 14)]
        /* 0x2538 */ public int MaxNumFreighters;
        [NMS(Index = 12)]
        /* 0x253C */ public int NumTradeRoutes;
        [NMS(Index = 13)]
        /* 0x2540 */ public int NumVisibleTradeRoutes;
        [NMS(Index = 4)]
        /* 0x2544 */ public int Planets;
        [NMS(Index = 8)]
        /* 0x2548 */ public int PrimePlanets;
        [NMS(Index = 30)]
        /* 0x254C */ public GcScreenFilters ScreenFilter;
        [NMS(Index = 3)]
        /* 0x2550 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 1)]
        /* 0x2554 */ public NMSString0x80 Name;
        [NMS(Index = 15)]
        /* 0x25D4 */ public bool StartWithFreighters;
    }
}

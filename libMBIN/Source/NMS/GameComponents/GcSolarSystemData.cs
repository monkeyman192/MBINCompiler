using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E452D99E8C644F1, NameHash = 0xC6DB83D2)]
    public class GcSolarSystemData : NMSTemplate
    {
        [NMS(Index = 26)]
        /* 0x0000 */ public GcPlanetColourData Colours;
        [NMS(Index = 20)]
        /* 0x1B90 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        [NMS(Index = 28)]
        /* 0x1CD0 */ public GcSpaceSkyProperties Sky;
        [NMS(Index = 5, Size = 0x8)]
        /* 0x1D70 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 27)]
        /* 0x1DF0 */ public GcLightProperties Light;
        [NMS(Index = 9)]
        /* 0x1E20 */ public Vector3f SunPosition;
        [NMS(Index = 6, Size = 0x8)]
        /* 0x1E30 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Index = 24)]
        /* 0x20B0 */ public List<NMSTemplate> AsteroidGenerators;
        [NMS(Index = 10)]
        /* 0x20C0 */ public NMSString0x10 AsteroidSubstanceID;
        [NMS(Index = 30)]
        /* 0x20D0 */ public VariableSizeString HeavyAir;
        [NMS(Index = 23)]
        /* 0x20E0 */ public List<GcSolarSystemLocator> Locators;
        [NMS(Index = 0)]
        /* 0x20F0 */ public GcSeed Seed;
        [NMS(Index = 32)]
        /* 0x2100 */ public GcSeed SentinelCrashSiteShipSeed;
        [NMS(Index = 31)]
        /* 0x2110 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        [NMS(Index = 7, Size = 0x8)]
        /* 0x2120 */ public int[] PlanetOrbits;
        [NMS(Index = 22)]
        /* 0x2140 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        [NMS(Index = 21)]
        /* 0x2154 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        [NMS(Index = 18)]
        /* 0x2168 */ public Vector2f FlybyTimer;
        [NMS(Index = 15)]
        /* 0x2170 */ public Vector2f FreighterTimer;
        [NMS(Index = 17)]
        /* 0x2178 */ public Vector2f PlanetPirateTimer;
        [NMS(Index = 19)]
        /* 0x2180 */ public Vector2f PoliceTimer;
        [NMS(Index = 16)]
        /* 0x2188 */ public Vector2f SpacePirateTimer;
        [NMS(Index = 34)]
        /* 0x2190 */ public GcPlanetTradingData TradingData;
        // size: 0x3
        public enum AsteroidLevelEnum : uint {
            NoRares,
            SomeRares,
            LotsOfRares,
        }
        [NMS(Index = 25)]
        /* 0x2198 */ public AsteroidLevelEnum AsteroidLevel;
        [NMS(Index = 2)]
        /* 0x219C */ public GcSolarSystemClass Class;
        [NMS(Index = 35)]
        /* 0x21A0 */ public GcPlayerConflictData ConflictData;
        [NMS(Index = 33)]
        /* 0x21A4 */ public GcAlienRace InhabitingRace;
        [NMS(Index = 13)]
        /* 0x21A8 */ public int MaxNumFreighters;
        [NMS(Index = 11)]
        /* 0x21AC */ public int NumTradeRoutes;
        [NMS(Index = 12)]
        /* 0x21B0 */ public int NumVisibleTradeRoutes;
        [NMS(Index = 4)]
        /* 0x21B4 */ public int Planets;
        [NMS(Index = 8)]
        /* 0x21B8 */ public int PrimePlanets;
        [NMS(Index = 29)]
        /* 0x21BC */ public GcScreenFilters ScreenFilter;
        [NMS(Index = 3)]
        /* 0x21C0 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 1)]
        /* 0x21C4 */ public NMSString0x80 Name;
        [NMS(Index = 14)]
        /* 0x2244 */ public bool StartWithFreighters;
    }
}

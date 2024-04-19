using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFAC54E3E24D9E8E, NameHash = 0x9B09276BB2795541)]
    public class GcSolarSystemData : NMSTemplate
    {
        /* 0x0000 */ public GcPlanetColourData Colours;
        /* 0x1B90 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x1CD0 */ public GcSpaceSkyProperties Sky;
        [NMS(Size = 0x8)]
        /* 0x1D70 */ public Vector3f[] PlanetPositions;
        /* 0x1DF0 */ public GcLightProperties Light;
        /* 0x1E20 */ public Vector3f SunPosition;
        [NMS(Size = 0x8)]
        /* 0x1E30 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        /* 0x20B0 */ public List<NMSTemplate> AsteroidGenerators;
        /* 0x20C0 */ public NMSString0x10 AsteroidSubstanceID;
        /* 0x20D0 */ public List<GcSolarSystemLocator> Locators;
        /* 0x20E0 */ public GcSeed Seed;
        /* 0x20F0 */ public GcSeed SentinelCrashSiteShipSeed;
        /* 0x2100 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        [NMS(Size = 0x8)]
        /* 0x2110 */ public int[] PlanetOrbits;
        /* 0x2130 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x2144 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x2158 */ public Vector2f FlybyTimer;
        /* 0x2160 */ public Vector2f FreighterTimer;
        /* 0x2168 */ public Vector2f PlanetPirateTimer;
        /* 0x2170 */ public Vector2f PoliceTimer;
        /* 0x2178 */ public Vector2f SpacePirateTimer;
        /* 0x2180 */ public GcPlanetTradingData TradingData;
        // size: 0x3
        public enum AsteroidLevelEnum : uint {
            NoRares,
            SomeRares,
            LotsOfRares,
        }
        /* 0x2188 */ public AsteroidLevelEnum AsteroidLevel;
        /* 0x218C */ public GcSolarSystemClass Class;
        /* 0x2190 */ public GcPlayerConflictData ConflictData;
        /* 0x2194 */ public GcAlienRace InhabitingRace;
        /* 0x2198 */ public int MaxNumFreighters;
        /* 0x219C */ public int NumTradeRoutes;
        /* 0x21A0 */ public int NumVisibleTradeRoutes;
        /* 0x21A4 */ public int Planets;
        /* 0x21A8 */ public int PrimePlanets;
        /* 0x21AC */ public GcScreenFilters ScreenFilter;
        /* 0x21B0 */ public GcGalaxyStarTypes StarType;
        /* 0x21B4 */ public NMSString0x80 HeavyAir;
        /* 0x2234 */ public NMSString0x80 Name;
        /* 0x22B4 */ public bool StartWithFreighters;
    }
}

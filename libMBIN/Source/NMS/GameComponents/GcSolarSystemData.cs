using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53E9341D16A62CD2, NameHash = 0x9B09276BB2795541)]
    public class GcSolarSystemData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed Seed;
        /* 0x0010 */ public NMSString0x80 Name;
        /* 0x0090 */ public GcSolarSystemClass Class;
        /* 0x0094 */ public GcGalaxyStarTypes StarType;
        /* 0x0098 */ public int Planets;
        [NMS(Size = 8)]
        /* 0x00A0 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 8)]
        /* 0x0120 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Size = 8)]
        /* 0x03A0 */ public int[] PlanetOrbits;
        /* 0x03C0 */ public int PrimePlanets;
        /* 0x03D0 */ public Vector3f SunPosition;
        /* 0x03E0 */ public NMSString0x10 AsteroidSubstanceID;
        /* 0x03F0 */ public int NumTradeRoutes;
        /* 0x03F4 */ public int NumVisibleTradeRoutes;
        /* 0x03F8 */ public int MaxNumFreighters;
        /* 0x03FC */ public bool StartWithFreighters;
        /* 0x0400 */ public Vector2f FreighterTimer;
        /* 0x0408 */ public Vector2f SpacePirateTimer;
        /* 0x0410 */ public Vector2f PlanetPirateTimer;
        /* 0x0418 */ public Vector2f FlybyTimer;
        /* 0x0420 */ public Vector2f PoliceTimer;
        /* 0x0430 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x0570 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x0584 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x0598 */ public List<GcSolarSystemLocator> Locators;
        /* 0x05A8 */ public List<NMSTemplate> AsteroidGenerators;
        // size: 0x3
        public enum AsteroidLevelEnum { NoRares, SomeRares, LotsOfRares }
        /* 0x05B8 */ public AsteroidLevelEnum AsteroidLevel;
        /* 0x05C0 */ public GcPlanetColourData Colours;
        /* 0x1F20 */ public GcLightProperties Light;
        /* 0x1F50 */ public GcSpaceSkyProperties Sky;
        /* 0x2000 */ public GcScreenFilters ScreenFilter;
        /* 0x2004 */ public NMSString0x80 HeavyAir;
        /* 0x2088 */ public List<GcAISpaceshipPreloadCacheData> SystemShips;
        /* 0x2098 */ public GcAlienRace InhabitingRace;
        /* 0x209C */ public GcPlanetTradingData TradingData;
        /* 0x20A4 */ public GcPlayerConflictData ConflictData;
    }
}

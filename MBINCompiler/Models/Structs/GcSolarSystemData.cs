using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSolarSystemData : NMSTemplate
    {
        /* 0x0000 */ public GcSeed Seed;
        [NMS(Size = 0x80)]
        /* 0x0010 */ public string Name;
        /* 0x0090 */ public GcSolarSystemClass Class;
        /* 0x0094 */ public int Planets;
        [NMS(Size = 8, Ignore = true)]
        /* 0x0098 */ public byte[] Padding98;

        [NMS(Size = 8)]
        /* 0x00A0 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 8)]
        /* 0x0120 */ public GcPlanetGenerationInputData[] PlanetGenerationInputs;
        [NMS(Size = 8)]
        /* 0x0320 */ public int[] PlanetOrbits;
        /* 0x0340 */ public Vector4f SunPosition;
        [NMS(Size = 0x10)]
        /* 0x0350 */ public string AsteroidSubstanceID;
        /* 0x0360 */ public int NumTradeRoutes;
        /* 0x0364 */ public int NumVisibleTradeRoutes;
        /* 0x0368 */ public int MaxNumFreighters;
        /* 0x036C */ public bool StartWithFreighters;
        [NMS(Size = 3, Ignore = true)]
        /* 0x036D */ public byte[] Padding36D;

        /* 0x0370 */ public Vector2f FreighterTimer;
        /* 0x0378 */ public Vector2f PirateTimer;
        /* 0x0380 */ public Vector2f FlybyTimer;
        [NMS(Size = 8, Ignore = true)]
        /* 0x0388 */ public byte[] Padding388;
        /* 0x0390 */ public GcSpaceStationSpawnData SpaceStationSpawn;
        /* 0x04D0 */ public GcSolarSystemTraderSpawnData TraderSpawnOnOutposts;
        /* 0x04E4 */ public GcSolarSystemTraderSpawnData TraderSpawnInStations;
        /* 0x04F8 */ public List<GcSolarSystemLocator> Locators;
        /* 0x0508 */ public List<NMSTemplate> AsteroidGenerators;
        /* 0x0518 */ public int AsteroidLevel;
        public string[] AsteroidLevelValues()
        {
            return new[] { "NoRares", "SomeRares", "LotsOfRares" };
        }

        [NMS(Size = 4, Ignore = true)]
        /* 0x051C */ public byte[] Padding51C;
        /* 0x0520 */ public GcPlanetColourData Colours;
        /* 0x11F0 */ public GcLightProperties Light;
        /* 0x1220 */ public GcSpaceSkyProperties Sky;
        /* 0x12B0 */ public GcSpaceSkyColours SkyColours;
        [NMS(Size = 0x80)]
        /* 0x1360 */ public string HeavyAir;
        [NMS(Size = 6)]
        /* 0x13E0 */ public GcAISpaceshipPreloadCacheDataTable[] FactionShips;
        /* 0x1440 */ public GcAlienRace InhabitingRace;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x1444 */ public byte[] Padding1444;
    }
}

using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCAC0A58CA8F57796, NameHash = 0xEAC286274BBCA057)]
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        /* 0x000 */ public bool MassiveSolarSystems;
        /* 0x010 */ public Vector3f SolarSystemSize;
        /* 0x020 */ public float SolarSystemMaximumRadius;
        /* 0x024 */ public float SolarSystemMaximumRadiusMassive;
        /* 0x028 */ public bool GenerateMaximumSolarSystem;
        /* 0x02C */ public int GenerateForcedNumberPlanets;
        /* 0x030 */ public bool UseSingleRacePerSystem;
        /* 0x034 */ public Vector2f PerPlanetGenerationAngleChangeDegreesRange;
        /* 0x03C */ public Vector2f PerPlanetGenerationElevationChangeDegreesRange;
        /* 0x044 */ public Vector2f SpawnPointStationToPlanetInterpRange;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x04C */ public float[] ExtremePlanetChance;
        /* 0x05C */ public float StationSpawnAvoidRadius;
        /* 0x060 */ public int LocatorScatterMinCount;
        /* 0x064 */ public int LocatorScatterMaxCount;
        /* 0x068 */ public float LocatorScatterMaxDistanceFromPlanet;
        /* 0x06C */ public int LocatorScatterChanceOfCapitalShips;
        /* 0x070 */ public int LocatorScatterChanceOfPirates;
        /* 0x074 */ public float PlanetInvalidAsteroidZone;
        /* 0x078 */ public bool AsteroidsEnabled;
        /* 0x07C */ public float SparseAsteroidSpread;
        /* 0x080 */ public List<GcAsteroidSystemGenerationData> AsteroidSettings;
        /* 0x090 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        /* 0x098 */ public Vector2f RareAsteroidNoiseRangeLotsOfRares;
        /* 0x0A0 */ public float RareAsteroidSystemOddsYellow;
        /* 0x0A4 */ public float RareAsteroidSystemOddsGreen;
        /* 0x0A8 */ public float RareAsteroidSystemOddsBlue;
        /* 0x0AC */ public float RareAsteroidSystemOddsRed;
        /* 0x0B0 */ public bool AsteroidsCheckNoise;
        /* 0x0B4 */ public int AsteroidNoiseOctaves;
        /* 0x0B8 */ public TkCurveType AsteroidScaleVarianceCurve;
        /* 0x0BC */ public float AsteroidSomeRaresOdds;
        /* 0x0C0 */ public float AsteroidLotsOfRaresOdds;
        /* 0x0C4 */ public int RareAsteroidMinResources;
        /* 0x0C8 */ public int RareAsteroidMaxResources;
        /* 0x0D0 */ public NMSString0x10 RareAsteroidResource;
        /* 0x0E0 */ public int CommonAsteroidMinResources;
        /* 0x0E4 */ public int CommonAsteroidMaxResources;
        /* 0x0E8 */ public int FuelAsteroidMultiplier;
        /* 0x0EC */ public int CommonAsteroidResourceFuelMultiplier;
        /* 0x0F0 */ public NMSString0x10 CommonAsteroidResourceFuel;
        /* 0x100 */ public NMSString0x10 RareAsteroidResourceFuel;     // GEODE_SPACE
        /* 0x110 */ public NMSString0x10 CommonAsteroidResourceProduct;     // GEODE_ASTEROID
        /* 0x120 */ public NMSString0x10 CommonAsteroidResourceMain;
        /* 0x130 */ public NMSString0x10 CommonAsteroidResourceSecondary;
        /* 0x140 */ public NMSString0x10 RareAsteroidDataProduct;
        /* 0x150 */ public float CommonAsteroidResourceFuelOdds;
        /* 0x154 */ public float RareAsteroidResourceFuelOdds;
        /* 0x158 */ public float CommonAsteroidResourceProductOdds;
        /* 0x15C */ public float RareAsteroidDataProductOdds;
        /* 0x160 */ public float CommonAsteroidResourceSecondaryOdds;
        /* 0x164 */ public float LargeAsteroidFadeTime;
        /* 0x168 */ public float AsteroidSpaceStationAvoidRadius;
        /* 0x16C */ public float AsteroidAnomalyAvoidRadius;
        /* 0x170 */ public float AsteroidWarpInAreaAvoidRadius;
        /* 0x174 */ public float AsteroidCreatureRichSystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x178 */ public float[] AbandonedSystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x188 */ public float[] EmptySystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x198 */ public float[] PirateSystemProbability;
        /* 0x1A8 */ public int CivilianTraderSpaceshipsCacheCount;
        /* 0x1B0 */ public List<float> SpaceshipSpawnFreqMultipliers;
        /* 0x1C0 */ public List<GcAISpaceshipWeightingData> SpaceshipWeightings;
        /* 0x1D0 */ public float PirateClassShipOverrideProbability;
        /* 0x1D4 */ public float PirateClassShipOverrideProbabilityPirateSystem;
        /* 0x1D8 */ public float PlanetRingProbability;
        /* 0x1E0 */ public GcPlanetRingData PlanetRingsMin;
        /* 0x240 */ public GcPlanetRingData PlanetRingsMax;
        /* 0x2A0 */ public int PercentChanceExtraPrime;
    }
}

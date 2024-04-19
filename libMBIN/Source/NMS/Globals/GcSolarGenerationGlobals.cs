using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x27B8606CDF40F240, NameHash = 0xEAC286274BBCA057)]
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        /* 0x000 */ public GcPlanetRingData PlanetRingsMax;
        /* 0x060 */ public GcPlanetRingData PlanetRingsMin;
        /* 0x0C0 */ public Vector3f SolarSystemSize;
        /* 0x0D0 */ public List<GcAsteroidSystemGenerationData> AsteroidSettings;
        /* 0x0E0 */ public NMSString0x10 CommonAsteroidResourceFuel;
        /* 0x0F0 */ public NMSString0x10 CommonAsteroidResourceMain;
        /* 0x100 */ public NMSString0x10 CommonAsteroidResourceProduct;
        /* 0x110 */ public NMSString0x10 CommonAsteroidResourceSecondary;
        /* 0x120 */ public NMSString0x10 RareAsteroidDataProduct;
        /* 0x130 */ public NMSString0x10 RareAsteroidResource;
        /* 0x140 */ public NMSString0x10 RareAsteroidResourceFuel;
        /* 0x150 */ public List<float> SpaceshipSpawnFreqMultipliers;
        /* 0x160 */ public List<GcAISpaceshipWeightingData> SpaceshipWeightings;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x170 */ public float[] AbandonedSystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x180 */ public float[] EmptySystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x190 */ public float[] ExtremePlanetChance;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1A0 */ public float[] PirateSystemProbability;
        /* 0x1B0 */ public Vector2f PerPlanetGenerationAngleChangeDegreesRange;
        /* 0x1B8 */ public Vector2f PerPlanetGenerationElevationChangeDegreesRange;
        /* 0x1C0 */ public Vector2f RareAsteroidNoiseRangeLotsOfRares;
        /* 0x1C8 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        /* 0x1D0 */ public Vector2f SpawnPointStationToPlanetInterpRange;
        /* 0x1D8 */ public float AsteroidAnomalyAvoidRadius;
        /* 0x1DC */ public float AsteroidLotsOfRaresOdds;
        /* 0x1E0 */ public int AsteroidNoiseOctaves;
        /* 0x1E4 */ public float AsteroidSomeRaresOdds;
        /* 0x1E8 */ public float AsteroidSpaceStationAvoidRadius;
        /* 0x1EC */ public float AsteroidWarpInAreaAvoidRadius;
        /* 0x1F0 */ public float AsteroidCreatureRichSystemProbability;
        /* 0x1F4 */ public int CivilianTraderSpaceshipsCacheCount;
        /* 0x1F8 */ public int CommonAsteroidMaxResources;
        /* 0x1FC */ public int CommonAsteroidMinResources;
        /* 0x200 */ public int CommonAsteroidResourceFuelMultiplier;
        /* 0x204 */ public float CommonAsteroidResourceFuelOdds;
        /* 0x208 */ public float CommonAsteroidResourceProductOdds;
        /* 0x20C */ public float CommonAsteroidResourceSecondaryOdds;
        /* 0x210 */ public GcCombatTimerDifficultyOption CorruptSentinelBuildingCheckDifficulty;
        /* 0x214 */ public int FuelAsteroidMultiplier;
        /* 0x218 */ public int GenerateForcedNumberPlanets;
        /* 0x21C */ public float LargeAsteroidFadeTime;
        /* 0x220 */ public int LocatorScatterChanceOfCapitalShips;
        /* 0x224 */ public int LocatorScatterChanceOfPirates;
        /* 0x228 */ public int LocatorScatterMaxCount;
        /* 0x22C */ public float LocatorScatterMaxDistanceFromPlanet;
        /* 0x230 */ public int LocatorScatterMinCount;
        /* 0x234 */ public int PercentChanceExtraPrime;
        /* 0x238 */ public float PirateClassShipOverrideProbability;
        /* 0x23C */ public float PirateClassShipOverrideProbabilityPirateSystem;
        /* 0x240 */ public float PlanetInvalidAsteroidZone;
        /* 0x244 */ public float PlanetRingProbability;
        /* 0x248 */ public float RareAsteroidDataProductOdds;
        /* 0x24C */ public int RareAsteroidMaxResources;
        /* 0x250 */ public int RareAsteroidMinResources;
        /* 0x254 */ public float RareAsteroidResourceFuelOdds;
        /* 0x258 */ public float RareAsteroidSystemOddsBlue;
        /* 0x25C */ public float RareAsteroidSystemOddsGreen;
        /* 0x260 */ public float RareAsteroidSystemOddsRed;
        /* 0x264 */ public float RareAsteroidSystemOddsYellow;
        /* 0x268 */ public float SolarSystemMaximumRadius;
        /* 0x26C */ public float SolarSystemMaximumRadiusMassive;
        /* 0x270 */ public float SparseAsteroidSpread;
        /* 0x274 */ public float StationSpawnAvoidRadius;
        /* 0x278 */ public TkCurveType AsteroidScaleVarianceCurve;
        /* 0x279 */ public bool AsteroidsCheckNoise;
        /* 0x27A */ public bool AsteroidsEnabled;
        /* 0x27B */ public bool GenerateMaximumSolarSystem;
        /* 0x27C */ public bool MassiveSolarSystems;
        /* 0x27D */ public bool UseSingleRacePerSystem;
        /* 0x27E */ public bool UseCorruptSentinelLUT;
    }
}

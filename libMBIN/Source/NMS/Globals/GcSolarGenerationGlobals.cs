using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xD1C8C9AF5945E2DB, NameHash = 0x557E3282)]
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        [NMS(Index = 67)]
        /* 0x000 */ public GcPlanetRingData PlanetRingsMax;
        [NMS(Index = 66)]
        /* 0x060 */ public GcPlanetRingData PlanetRingsMin;
        [NMS(Index = 3, MxmlName = "Solar System Size")]
        /* 0x0C0 */ public Vector3f SolarSystemSize;
        [NMS(Index = 21)]
        /* 0x0D0 */ public List<GcAsteroidSystemGenerationData> AsteroidSettings;
        [NMS(Index = 41, MxmlName = "Common Asteroid Resource Fuel")]
        /* 0x0E0 */ public NMSString0x10 CommonAsteroidResourceFuel;
        [NMS(Index = 44, MxmlName = "Common Asteroid Resource Main")]
        /* 0x0F0 */ public NMSString0x10 CommonAsteroidResourceMain;
        [NMS(Index = 43, MxmlName = "Common Asteroid Resource Product")]
        /* 0x100 */ public NMSString0x10 CommonAsteroidResourceProduct;
        [NMS(Index = 45, MxmlName = "Common Asteroid Resource Secondary")]
        /* 0x110 */ public NMSString0x10 CommonAsteroidResourceSecondary;
        [NMS(Index = 46, MxmlName = "Rare Asteroid Data Product")]
        /* 0x120 */ public NMSString0x10 RareAsteroidDataProduct;
        [NMS(Index = 36, MxmlName = "Rare Asteroid Resource")]
        /* 0x130 */ public NMSString0x10 RareAsteroidResource;
        [NMS(Index = 42, MxmlName = "Rare Asteroid Resource Fuel")]
        /* 0x140 */ public NMSString0x10 RareAsteroidResourceFuel;
        [NMS(Index = 61)]
        /* 0x150 */ public List<float> SpaceshipSpawnFreqMultipliers;
        [NMS(Index = 62)]
        /* 0x160 */ public List<GcAISpaceshipWeightingData> SpaceshipWeightings;
        [NMS(Index = 57, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x170 */ public float[] AbandonedSystemProbability;
        [NMS(Index = 58, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x184 */ public float[] EmptySystemProbability;
        [NMS(Index = 12, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x198 */ public float[] ExtremePlanetChance;
        [NMS(Index = 59, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1AC */ public float[] PirateSystemProbability;
        [NMS(Index = 9, MxmlName = "Per Planet Generation Angle Change Degrees Range")]
        /* 0x1C0 */ public Vector2f PerPlanetGenerationAngleChangeDegreesRange;
        [NMS(Index = 10, MxmlName = "Per Planet Generation Elevation Change Degrees Range")]
        /* 0x1C8 */ public Vector2f PerPlanetGenerationElevationChangeDegreesRange;
        [NMS(Index = 23, MxmlName = "Rare Asteroid Noise Range Lots Of Rares")]
        /* 0x1D0 */ public Vector2f RareAsteroidNoiseRangeLotsOfRares;
        [NMS(Index = 22, MxmlName = "Rare Asteroid Noise Range Some Rares")]
        /* 0x1D8 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        [NMS(Index = 11, MxmlName = "Spawn Point Station To Planet Interp Range")]
        /* 0x1E0 */ public Vector2f SpawnPointStationToPlanetInterpRange;
        [NMS(Index = 54, MxmlName = "Asteroid Anomaly Avoid Radius")]
        /* 0x1E8 */ public float AsteroidAnomalyAvoidRadius;
        [NMS(Index = 33, MxmlName = "Asteroid Lots Of Rares Odds")]
        /* 0x1EC */ public float AsteroidLotsOfRaresOdds;
        [NMS(Index = 30, MxmlName = "Asteroid Noise Octaves")]
        /* 0x1F0 */ public int AsteroidNoiseOctaves;
        [NMS(Index = 32, MxmlName = "Asteroid Some Rares Odds")]
        /* 0x1F4 */ public float AsteroidSomeRaresOdds;
        [NMS(Index = 53, MxmlName = "Asteroid Space Station Avoid Radius")]
        /* 0x1F8 */ public float AsteroidSpaceStationAvoidRadius;
        [NMS(Index = 55, MxmlName = "Asteroid Warp In Area Avoid Radius")]
        /* 0x1FC */ public float AsteroidWarpInAreaAvoidRadius;
        [NMS(Index = 56)]
        /* 0x200 */ public float AsteroidCreatureRichSystemProbability;
        [NMS(Index = 60)]
        /* 0x204 */ public int CivilianTraderSpaceshipsCacheCount;
        [NMS(Index = 38, MxmlName = "Common Asteroid Max Resources")]
        /* 0x208 */ public int CommonAsteroidMaxResources;
        [NMS(Index = 37, MxmlName = "Common Asteroid Min Resources")]
        /* 0x20C */ public int CommonAsteroidMinResources;
        [NMS(Index = 40, MxmlName = "Common Asteroid Resource Fuel Multiplier")]
        /* 0x210 */ public int CommonAsteroidResourceFuelMultiplier;
        [NMS(Index = 47, MxmlName = "Common Asteroid Resource Fuel Odds")]
        /* 0x214 */ public float CommonAsteroidResourceFuelOdds;
        [NMS(Index = 49, MxmlName = "Common Asteroid Resource Product Odds")]
        /* 0x218 */ public float CommonAsteroidResourceProductOdds;
        [NMS(Index = 51, MxmlName = "Common Asteroid Resource Secondary Odds")]
        /* 0x21C */ public float CommonAsteroidResourceSecondaryOdds;
        [NMS(Index = 0)]
        /* 0x220 */ public GcCombatTimerDifficultyOption CorruptSentinelBuildingCheckDifficulty;
        [NMS(Index = 39, MxmlName = "Fuel Asteroid Multiplier")]
        /* 0x224 */ public int FuelAsteroidMultiplier;
        [NMS(Index = 7, MxmlName = "Generate Forced Number Planets")]
        /* 0x228 */ public int GenerateForcedNumberPlanets;
        [NMS(Index = 52, MxmlName = "Large Asteroid Fade Time")]
        /* 0x22C */ public float LargeAsteroidFadeTime;
        [NMS(Index = 17, MxmlName = "Locator Scatter Chance Of Capital Ships")]
        /* 0x230 */ public int LocatorScatterChanceOfCapitalShips;
        [NMS(Index = 18, MxmlName = "Locator Scatter Chance Of Pirates")]
        /* 0x234 */ public int LocatorScatterChanceOfPirates;
        [NMS(Index = 15, MxmlName = "Locator Scatter Max Count")]
        /* 0x238 */ public int LocatorScatterMaxCount;
        [NMS(Index = 16, MxmlName = "Locator Scatter Max Distance From Planet")]
        /* 0x23C */ public float LocatorScatterMaxDistanceFromPlanet;
        [NMS(Index = 14, MxmlName = "Locator Scatter Min Count")]
        /* 0x240 */ public int LocatorScatterMinCount;
        [NMS(Index = 68)]
        /* 0x244 */ public int PercentChanceExtraPrime;
        [NMS(Index = 63)]
        /* 0x248 */ public float PirateClassShipOverrideProbability;
        [NMS(Index = 64)]
        /* 0x24C */ public float PirateClassShipOverrideProbabilityPirateSystem;
        [NMS(Index = 19, MxmlName = "Planet Invalid Asteroid Zone")]
        /* 0x250 */ public float PlanetInvalidAsteroidZone;
        [NMS(Index = 65)]
        /* 0x254 */ public float PlanetRingProbability;
        [NMS(Index = 50, MxmlName = "Rare Asteroid Data Product Odds")]
        /* 0x258 */ public float RareAsteroidDataProductOdds;
        [NMS(Index = 35, MxmlName = "Rare Asteroid Max Resources")]
        /* 0x25C */ public int RareAsteroidMaxResources;
        [NMS(Index = 34, MxmlName = "Rare Asteroid Min Resources")]
        /* 0x260 */ public int RareAsteroidMinResources;
        [NMS(Index = 48, MxmlName = "Rare Asteroid Resource Fuel Odds")]
        /* 0x264 */ public float RareAsteroidResourceFuelOdds;
        [NMS(Index = 26, MxmlName = "Rare Asteroid System Odds Blue")]
        /* 0x268 */ public float RareAsteroidSystemOddsBlue;
        [NMS(Index = 25, MxmlName = "Rare Asteroid System Odds Green")]
        /* 0x26C */ public float RareAsteroidSystemOddsGreen;
        [NMS(Index = 28, MxmlName = "Rare Asteroid System Odds Purple")]
        /* 0x270 */ public float RareAsteroidSystemOddsPurple;
        [NMS(Index = 27, MxmlName = "Rare Asteroid System Odds Red")]
        /* 0x274 */ public float RareAsteroidSystemOddsRed;
        [NMS(Index = 24, MxmlName = "Rare Asteroid System Odds Yellow")]
        /* 0x278 */ public float RareAsteroidSystemOddsYellow;
        [NMS(Index = 4, MxmlName = "Solar System Maximum Radius")]
        /* 0x27C */ public float SolarSystemMaximumRadius;
        [NMS(Index = 5, MxmlName = "Solar System Maximum Radius Massive")]
        /* 0x280 */ public float SolarSystemMaximumRadiusMassive;
        [NMS(Index = 13, MxmlName = "Station Spawn Avoid Radius")]
        /* 0x284 */ public float StationSpawnAvoidRadius;
        [NMS(Index = 31, MxmlName = "Asteroid Scale Variance Curve")]
        /* 0x288 */ public TkCurveType AsteroidScaleVarianceCurve;
        [NMS(Index = 29, MxmlName = "Asteroids Check Noise")]
        /* 0x289 */ public bool AsteroidsCheckNoise;
        [NMS(Index = 20, MxmlName = "Asteroids Enabled")]
        /* 0x28A */ public bool AsteroidsEnabled;
        [NMS(Index = 6, MxmlName = "Generate Maximum Solar System")]
        /* 0x28B */ public bool GenerateMaximumSolarSystem;
        [NMS(Index = 2, MxmlName = "Massive Solar Systems")]
        /* 0x28C */ public bool MassiveSolarSystems;
        [NMS(Index = 8, MxmlName = "Use Single Race Per System")]
        /* 0x28D */ public bool UseSingleRacePerSystem;
        [NMS(Index = 1)]
        /* 0x28E */ public bool UseCorruptSentinelLUT;
    }
}

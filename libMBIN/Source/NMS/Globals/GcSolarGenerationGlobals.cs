using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x75D6409308B16DC7, NameHash = 0xEAC286274BBCA057)]
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        [NMS(Index = 67)]
        /* 0x000 */ public GcPlanetRingData PlanetRingsMax;
        [NMS(Index = 66)]
        /* 0x060 */ public GcPlanetRingData PlanetRingsMin;
        [NMS(Index = 3)]
        /* 0x0C0 */ public Vector3f SolarSystemSize;
        [NMS(Index = 22)]
        /* 0x0D0 */ public List<GcAsteroidSystemGenerationData> AsteroidSettings;
        [NMS(Index = 41)]
        /* 0x0E0 */ public NMSString0x10 CommonAsteroidResourceFuel;
        [NMS(Index = 44)]
        /* 0x0F0 */ public NMSString0x10 CommonAsteroidResourceMain;
        [NMS(Index = 43)]
        /* 0x100 */ public NMSString0x10 CommonAsteroidResourceProduct;
        [NMS(Index = 45)]
        /* 0x110 */ public NMSString0x10 CommonAsteroidResourceSecondary;
        [NMS(Index = 46)]
        /* 0x120 */ public NMSString0x10 RareAsteroidDataProduct;
        [NMS(Index = 36)]
        /* 0x130 */ public NMSString0x10 RareAsteroidResource;
        [NMS(Index = 42)]
        /* 0x140 */ public NMSString0x10 RareAsteroidResourceFuel;
        [NMS(Index = 61)]
        /* 0x150 */ public List<float> SpaceshipSpawnFreqMultipliers;
        [NMS(Index = 62)]
        /* 0x160 */ public List<GcAISpaceshipWeightingData> SpaceshipWeightings;
        [NMS(Index = 57, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x170 */ public float[] AbandonedSystemProbability;
        [NMS(Index = 58, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x180 */ public float[] EmptySystemProbability;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x190 */ public float[] ExtremePlanetChance;
        [NMS(Index = 59, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1A0 */ public float[] PirateSystemProbability;
        [NMS(Index = 9)]
        /* 0x1B0 */ public Vector2f PerPlanetGenerationAngleChangeDegreesRange;
        [NMS(Index = 10)]
        /* 0x1B8 */ public Vector2f PerPlanetGenerationElevationChangeDegreesRange;
        [NMS(Index = 24)]
        /* 0x1C0 */ public Vector2f RareAsteroidNoiseRangeLotsOfRares;
        [NMS(Index = 23)]
        /* 0x1C8 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        [NMS(Index = 11)]
        /* 0x1D0 */ public Vector2f SpawnPointStationToPlanetInterpRange;
        [NMS(Index = 54)]
        /* 0x1D8 */ public float AsteroidAnomalyAvoidRadius;
        [NMS(Index = 33)]
        /* 0x1DC */ public float AsteroidLotsOfRaresOdds;
        [NMS(Index = 30)]
        /* 0x1E0 */ public int AsteroidNoiseOctaves;
        [NMS(Index = 32)]
        /* 0x1E4 */ public float AsteroidSomeRaresOdds;
        [NMS(Index = 53)]
        /* 0x1E8 */ public float AsteroidSpaceStationAvoidRadius;
        [NMS(Index = 55)]
        /* 0x1EC */ public float AsteroidWarpInAreaAvoidRadius;
        [NMS(Index = 56)]
        /* 0x1F0 */ public float AsteroidCreatureRichSystemProbability;
        [NMS(Index = 60)]
        /* 0x1F4 */ public int CivilianTraderSpaceshipsCacheCount;
        [NMS(Index = 38)]
        /* 0x1F8 */ public int CommonAsteroidMaxResources;
        [NMS(Index = 37)]
        /* 0x1FC */ public int CommonAsteroidMinResources;
        [NMS(Index = 40)]
        /* 0x200 */ public int CommonAsteroidResourceFuelMultiplier;
        [NMS(Index = 47)]
        /* 0x204 */ public float CommonAsteroidResourceFuelOdds;
        [NMS(Index = 49)]
        /* 0x208 */ public float CommonAsteroidResourceProductOdds;
        [NMS(Index = 51)]
        /* 0x20C */ public float CommonAsteroidResourceSecondaryOdds;
        [NMS(Index = 0)]
        /* 0x210 */ public GcCombatTimerDifficultyOption CorruptSentinelBuildingCheckDifficulty;
        [NMS(Index = 39)]
        /* 0x214 */ public int FuelAsteroidMultiplier;
        [NMS(Index = 7)]
        /* 0x218 */ public int GenerateForcedNumberPlanets;
        [NMS(Index = 52)]
        /* 0x21C */ public float LargeAsteroidFadeTime;
        [NMS(Index = 17)]
        /* 0x220 */ public int LocatorScatterChanceOfCapitalShips;
        [NMS(Index = 18)]
        /* 0x224 */ public int LocatorScatterChanceOfPirates;
        [NMS(Index = 15)]
        /* 0x228 */ public int LocatorScatterMaxCount;
        [NMS(Index = 16)]
        /* 0x22C */ public float LocatorScatterMaxDistanceFromPlanet;
        [NMS(Index = 14)]
        /* 0x230 */ public int LocatorScatterMinCount;
        [NMS(Index = 68)]
        /* 0x234 */ public int PercentChanceExtraPrime;
        [NMS(Index = 63)]
        /* 0x238 */ public float PirateClassShipOverrideProbability;
        [NMS(Index = 64)]
        /* 0x23C */ public float PirateClassShipOverrideProbabilityPirateSystem;
        [NMS(Index = 19)]
        /* 0x240 */ public float PlanetInvalidAsteroidZone;
        [NMS(Index = 65)]
        /* 0x244 */ public float PlanetRingProbability;
        [NMS(Index = 50)]
        /* 0x248 */ public float RareAsteroidDataProductOdds;
        [NMS(Index = 35)]
        /* 0x24C */ public int RareAsteroidMaxResources;
        [NMS(Index = 34)]
        /* 0x250 */ public int RareAsteroidMinResources;
        [NMS(Index = 48)]
        /* 0x254 */ public float RareAsteroidResourceFuelOdds;
        [NMS(Index = 27)]
        /* 0x258 */ public float RareAsteroidSystemOddsBlue;
        [NMS(Index = 26)]
        /* 0x25C */ public float RareAsteroidSystemOddsGreen;
        [NMS(Index = 28)]
        /* 0x260 */ public float RareAsteroidSystemOddsRed;
        [NMS(Index = 25)]
        /* 0x264 */ public float RareAsteroidSystemOddsYellow;
        [NMS(Index = 4)]
        /* 0x268 */ public float SolarSystemMaximumRadius;
        [NMS(Index = 5)]
        /* 0x26C */ public float SolarSystemMaximumRadiusMassive;
        [NMS(Index = 21)]
        /* 0x270 */ public float SparseAsteroidSpread;
        [NMS(Index = 13)]
        /* 0x274 */ public float StationSpawnAvoidRadius;
        [NMS(Index = 31)]
        /* 0x278 */ public TkCurveType AsteroidScaleVarianceCurve;
        [NMS(Index = 29)]
        /* 0x279 */ public bool AsteroidsCheckNoise;
        [NMS(Index = 20)]
        /* 0x27A */ public bool AsteroidsEnabled;
        [NMS(Index = 6)]
        /* 0x27B */ public bool GenerateMaximumSolarSystem;
        [NMS(Index = 2)]
        /* 0x27C */ public bool MassiveSolarSystems;
        [NMS(Index = 8)]
        /* 0x27D */ public bool UseSingleRacePerSystem;
        [NMS(Index = 1)]
        /* 0x27E */ public bool UseCorruptSentinelLUT;
    }
}

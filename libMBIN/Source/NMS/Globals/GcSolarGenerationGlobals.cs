using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x2F0, GUID = 0xCF1B1EB60E963DD0, NameHash = 0xEAC286274BBCA057)]
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
        /* 0x074 */ public float DirectorLocatorBusyDistance;
        /* 0x078 */ public float DirectorLocatorBusyAngle;
        /* 0x07C */ public float PlanetInvalidAsteroidZone;
        /* 0x080 */ public bool AsteroidsEnabled;
        /* 0x081 */ public bool AsteroidsCheckNoise;
        /* 0x084 */ public float AsteroidNoiseScale;
        /* 0x088 */ public float AsteroidDetailNoiseScale;
        /* 0x08C */ public int AsteroidNoiseOctaves;
        /* 0x090 */ public float AsteroidNoiseMinCutoff;
        /* 0x094 */ public float AsteroidNoiseMaxCutoff;
        /* 0x098 */ public float AsteroidRotateMin;
        /* 0x09C */ public float AsteroidRotateMax;
        /* 0x0A0 */ public Vector2f AsteroidScaleVariance;
        /* 0x0A8 */ public float AsteroidFadeTime;
        /* 0x0AC */ public Vector2f AsteroidNoiseRange;
        /* 0x0B4 */ public Vector2f LargeAsteroidNoiseRange;
        /* 0x0BC */ public Vector2f RareAsteroidNoiseRangeFewRares;
        /* 0x0C4 */ public Vector2f RareAsteroidNoiseRangeSomeRares;
        /* 0x0CC */ public Vector2f RareAsteroidNoiseRangeLotsOfRares;
        /* 0x0D4 */ public float AsteroidSomeRaresOdds;
        /* 0x0D8 */ public float AsteroidLotsOfRaresOdds;
        /* 0x0DC */ public float AsteroidFadeRangeMin;
        /* 0x0E0 */ public float AsteroidFadeRangeMax;
        /* 0x0E4 */ public float AsteroidSpacing;
        /* 0x0E8 */ public float RareAsteroidScale;
        /* 0x0EC */ public int RareAsteroidMinResources;
        /* 0x0F0 */ public int RareAsteroidMaxResources;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0F4 */ public byte[] PaddingF4;
        /* 0x0F8 */ public NMSString0x10 RareAsteroidResource;
        /* 0x108 */ public int RareAsteroidHealth;
        /* 0x10C */ public float CommonAsteroidScale;
        /* 0x110 */ public int CommonAsteroidMinResources;
        /* 0x114 */ public int CommonAsteroidMaxResources;
        /* 0x118 */ public int CommonAsteroidResourceFuelMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x11C */ public byte[] Padding11C;
        /* 0x120 */ public NMSString0x10 CommonAsteroidResourceFuel;
        /* 0x130 */ public NMSString0x10 RareAsteroidResourceFuel;     // GEODE_SPACE
        /* 0x140 */ public NMSString0x10 CommonAsteroidResourceProduct;     // GEODE_ASTEROID
        /* 0x150 */ public NMSString0x10 CommonAsteroidResourceMain;
        /* 0x160 */ public NMSString0x10 CommonAsteroidResourceSecondary;
        /* 0x170 */ public NMSString0x10 RareAsteroidDataProduct;
        /* 0x180 */ public float CommonAsteroidResourceFuelOdds;
        /* 0x184 */ public float RareAsteroidResourceFuelOdds;
        /* 0x188 */ public float CommonAsteroidResourceProductOdds;
        /* 0x18C */ public float RareAsteroidDataProductOdds;
        /* 0x190 */ public float CommonAsteroidResourceSecondaryOdds;
        /* 0x194 */ public int CommonAsteroidHealth;
        /* 0x198 */ public float LargeAsteroidSpacing;
        /* 0x19C */ public float LargeAsteroidFadeTime;
        /* 0x1A0 */ public float LargeAsteroidFadeRangeMin;
        /* 0x1A4 */ public float LargeAsteroidFadeRangeMax;
        /* 0x1A8 */ public float LargeAsteroidMoveFadeTime;
        /* 0x1AC */ public float RingAsteroidScale;
        /* 0x1B0 */ public float RingAsteroidSpacing;
        /* 0x1B4 */ public float RingAsteroidFadeRangeMin;
        /* 0x1B8 */ public float RingAsteroidFadeRangeMax;
        /* 0x1BC */ public int AsteroidMaxNumGenerates;
        /* 0x1C0 */ public int AsteroidMaxNumGeneratesPulseJump;
        /* 0x1C4 */ public float AsteroidSpaceStationAvoidRadius;
        /* 0x1C8 */ public float AsteroidAnomalyAvoidRadius;
        /* 0x1CC */ public float AsteroidWarpInAreaAvoidRadius;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1D0 */ public float[] AbandonedSystemProbability;
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x1E0 */ public float[] EmptySystemProbability;
        /* 0x1F0 */ public int CivilianTraderSpaceshipsCacheCount;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1F4 */ public byte[] Padding1F4;
        /* 0x1F8 */ public List<float> SpaceshipSpawnFreqMultipliers;
        /* 0x208 */ public List<GcAISpaceshipWeightingData> SpaceshipWeightings;
        /* 0x218 */ public float PlanetRingProbability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x21C */ public byte[] Padding21C;
        /* 0x220 */ public GcPlanetRingData PlanetRingsMin;
        /* 0x280 */ public GcPlanetRingData PlanetRingsMax;
        /* 0x2E0 */ public int PercentChanceExtraPrime;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2E4 */ public byte[] EndPadding;
    }
}

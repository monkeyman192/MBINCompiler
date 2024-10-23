using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6195603EA8537A99, NameHash = 0x9CE4FFF3)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        [NMS(Index = 34)]
        /* 0x00 */ public NMSString0x20A SamePlanetAsEvent;
        [NMS(Index = 29)]
        /* 0x20 */ public NMSString0x10 NeedsResourceHint;
        [NMS(Index = 36)]
        /* 0x30 */ public NMSString0x10 SystemNeedsResourceHint;
        [NMS(Index = 7)]
        /* 0x40 */ public GcPlanetTradingData TradingData;
        [NMS(Index = 42)]
        /* 0x48 */ public int MinPlanets;
        [NMS(Index = 25)]
        /* 0x4C */ public GcBiomeType NeedsBiomeType;
        [NMS(Index = 35)]
        /* 0x50 */ public int SamePlanetAsSeasonParty;
        [NMS(Index = 6)]
        /* 0x54 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 4)]
        /* 0x58 */ public GcGalaxyStarAnomaly UseAnomaly;
        [NMS(Index = 26)]
        /* 0x5C */ public GcBiomeSubType UseBiomeSubType;
        [NMS(Index = 5)]
        /* 0x60 */ public GcPlayerConflictData UseConflict;
        [NMS(Index = 3)]
        /* 0x64 */ public GcAlienRace UseRace;
        [NMS(Index = 8)]
        /* 0x68 */ public bool AllowUnsafeMatches;
        [NMS(Index = 21)]
        /* 0x69 */ public bool AnyBiomeNotWeirdOrDead;
        [NMS(Index = 23)]
        /* 0x6A */ public bool AnyInfestedBiome;
        [NMS(Index = 22)]
        /* 0x6B */ public bool AnyRGBBiome;
        [NMS(Index = 28)]
        /* 0x6C */ public bool NeedsAbandonedSystem;
        [NMS(Index = 24)]
        /* 0x6D */ public bool NeedsBiome;
        [NMS(Index = 15)]
        /* 0x6E */ public bool NeedsCorruptSentinelPlanet;
        [NMS(Index = 27)]
        /* 0x6F */ public bool NeedsEmptySystem;
        [NMS(Index = 19)]
        /* 0x70 */ public bool NeedsExtremeHazardPlanet;
        [NMS(Index = 16)]
        /* 0x71 */ public bool NeedsExtremeSentinelPlanet;
        [NMS(Index = 18)]
        /* 0x72 */ public bool NeedsExtremeWeatherPlanet;
        [NMS(Index = 13)]
        /* 0x73 */ public bool NeedsPrimePlanet;
        [NMS(Index = 14)]
        /* 0x74 */ public bool NeedsSentinels;
        [NMS(Index = 12)]
        /* 0x75 */ public bool NeedsWaterPlanet;
        [NMS(Index = 10)]
        /* 0x76 */ public bool NeverAllowAbandoned;
        [NMS(Index = 9)]
        /* 0x77 */ public bool NeverAllowEmpty;
        [NMS(Index = 17)]
        /* 0x78 */ public bool NeverAllowExtremeSentinelPlanet;
        [NMS(Index = 20)]
        /* 0x79 */ public bool NeverAllowExtremeWeatherPlanet;
        [NMS(Index = 11)]
        /* 0x7A */ public bool RequireUndiscovered;
        [NMS(Index = 30)]
        /* 0x7B */ public bool SuitableForCreatureDiscovery;
        [NMS(Index = 33)]
        /* 0x7C */ public bool SuitableForCreatureTaming;
        [NMS(Index = 32)]
        /* 0x7D */ public bool SuitableForRobotCreatureDiscovery;
        [NMS(Index = 31)]
        /* 0x7E */ public bool SuitableForWeirdCreatureDiscovery;
        [NMS(Index = 40)]
        /* 0x7F */ public bool SystemNeedsCorruptSentinelPlanet;
        [NMS(Index = 41)]
        /* 0x80 */ public bool SystemNeedsExtremeStormPlanet;
        [NMS(Index = 39)]
        /* 0x81 */ public bool SystemNeedsInfestedPlanet;
        [NMS(Index = 37)]
        /* 0x82 */ public bool SystemNeedsWater;
        [NMS(Index = 38)]
        /* 0x83 */ public bool SystemNeedsWeirdPlanet;
        [NMS(Index = 0)]
        /* 0x84 */ public bool UseStarType;
        [NMS(Index = 2)]
        /* 0x85 */ public bool UseTrading;
        [NMS(Index = 1)]
        /* 0x86 */ public bool UseWealth;
    }
}

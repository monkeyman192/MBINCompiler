using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0773BB420CCA13B, NameHash = 0x9CE4FFF3)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        [NMS(Index = 33)]
        /* 0x00 */ public NMSString0x20A SamePlanetAsEvent;
        [NMS(Index = 28)]
        /* 0x20 */ public NMSString0x10 NeedsResourceHint;
        [NMS(Index = 7)]
        /* 0x30 */ public GcPlanetTradingData TradingData;
        [NMS(Index = 24)]
        /* 0x38 */ public GcBiomeType NeedsBiomeType;
        [NMS(Index = 34)]
        /* 0x3C */ public int SamePlanetAsSeasonParty;
        [NMS(Index = 6)]
        /* 0x40 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 4)]
        /* 0x44 */ public GcGalaxyStarAnomaly UseAnomaly;
        [NMS(Index = 25)]
        /* 0x48 */ public GcBiomeSubType UseBiomeSubType;
        [NMS(Index = 5)]
        /* 0x4C */ public GcPlayerConflictData UseConflict;
        [NMS(Index = 3)]
        /* 0x50 */ public GcAlienRace UseRace;
        [NMS(Index = 8)]
        /* 0x54 */ public bool AllowUnsafeMatches;
        [NMS(Index = 20)]
        /* 0x55 */ public bool AnyBiomeNotWeirdOrDead;
        [NMS(Index = 22)]
        /* 0x56 */ public bool AnyInfestedBiome;
        [NMS(Index = 21)]
        /* 0x57 */ public bool AnyRGBBiome;
        [NMS(Index = 27)]
        /* 0x58 */ public bool NeedsAbandonedSystem;
        [NMS(Index = 23)]
        /* 0x59 */ public bool NeedsBiome;
        [NMS(Index = 15)]
        /* 0x5A */ public bool NeedsCorruptSentinelPlanet;
        [NMS(Index = 26)]
        /* 0x5B */ public bool NeedsEmptySystem;
        [NMS(Index = 19)]
        /* 0x5C */ public bool NeedsExtremeHazardPlanet;
        [NMS(Index = 16)]
        /* 0x5D */ public bool NeedsExtremeSentinelPlanet;
        [NMS(Index = 18)]
        /* 0x5E */ public bool NeedsExtremeWeatherPlanet;
        [NMS(Index = 13)]
        /* 0x5F */ public bool NeedsPrimePlanet;
        [NMS(Index = 14)]
        /* 0x60 */ public bool NeedsSentinels;
        [NMS(Index = 12)]
        /* 0x61 */ public bool NeedsWaterPlanet;
        [NMS(Index = 10)]
        /* 0x62 */ public bool NeverAllowAbandoned;
        [NMS(Index = 9)]
        /* 0x63 */ public bool NeverAllowEmpty;
        [NMS(Index = 17)]
        /* 0x64 */ public bool NeverAllowExtremeSentinelPlanet;
        [NMS(Index = 11)]
        /* 0x65 */ public bool RequireUndiscovered;
        [NMS(Index = 29)]
        /* 0x66 */ public bool SuitableForCreatureDiscovery;
        [NMS(Index = 32)]
        /* 0x67 */ public bool SuitableForCreatureTaming;
        [NMS(Index = 31)]
        /* 0x68 */ public bool SuitableForRobotCreatureDiscovery;
        [NMS(Index = 30)]
        /* 0x69 */ public bool SuitableForWeirdCreatureDiscovery;
        [NMS(Index = 0)]
        /* 0x6A */ public bool UseStarType;
        [NMS(Index = 2)]
        /* 0x6B */ public bool UseTrading;
        [NMS(Index = 1)]
        /* 0x6C */ public bool UseWealth;
    }
}

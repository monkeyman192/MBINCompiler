using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA5E6163960C68336, NameHash = 0xE523CFAD6AFB4BB6)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SamePlanetAsEvent;
        /* 0x20 */ public NMSString0x10 NeedsResourceHint;
        /* 0x30 */ public GcPlanetTradingData TradingData;
        /* 0x38 */ public GcBiomeType NeedsBiomeType;
        /* 0x3C */ public int SamePlanetAsSeasonParty;
        /* 0x40 */ public GcGalaxyStarTypes StarType;
        /* 0x44 */ public GcGalaxyStarAnomaly UseAnomaly;
        /* 0x48 */ public GcBiomeSubType UseBiomeSubType;
        /* 0x4C */ public GcPlayerConflictData UseConflict;
        /* 0x50 */ public GcAlienRace UseRace;
        /* 0x54 */ public bool AllowUnsafeMatches;
        /* 0x55 */ public bool AnyBiomeNotWeirdOrDead;
        /* 0x56 */ public bool AnyInfestedBiome;
        /* 0x57 */ public bool AnyRGBBiome;
        /* 0x58 */ public bool NeedsAbandonedSystem;
        /* 0x59 */ public bool NeedsBiome;
        /* 0x5A */ public bool NeedsCorruptSentinelPlanet;
        /* 0x5B */ public bool NeedsEmptySystem;
        /* 0x5C */ public bool NeedsExtremeHazardPlanet;
        /* 0x5D */ public bool NeedsExtremeSentinelPlanet;
        /* 0x5E */ public bool NeedsExtremeWeatherPlanet;
        /* 0x5F */ public bool NeedsPrimePlanet;
        /* 0x60 */ public bool NeedsSentinels;
        /* 0x61 */ public bool NeedsWaterPlanet;
        /* 0x62 */ public bool NeverAllowAbandoned;
        /* 0x63 */ public bool NeverAllowEmpty;
        /* 0x64 */ public bool NeverAllowExtremeSentinelPlanet;
        /* 0x65 */ public bool RequireUndiscovered;
        /* 0x66 */ public bool SuitableForCreatureDiscovery;
        /* 0x67 */ public bool SuitableForCreatureTaming;
        /* 0x68 */ public bool SuitableForWeirdCreatureDiscovery;
        /* 0x69 */ public bool UseStarType;
        /* 0x6A */ public bool UseTrading;
        /* 0x6B */ public bool UseWealth;
    }
}

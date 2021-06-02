using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x70, Alignment = 0x4, GUID = 0x0CEDBF75707F5C11, NameHash = 0xE523CFAD6AFB4BB6)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        /* 0x00 */ public bool UseStarType;
        /* 0x01 */ public bool UseWealth;
        /* 0x02 */ public bool UseTrading;
        /* 0x04 */ public GcAlienRace UseRace;
        /* 0x08 */ public GcGalaxyStarAnomaly UseAnomaly;
        /* 0x0C */ public GcPlayerConflictData UseConflict;
        /* 0x10 */ public GcGalaxyStarTypes StarType;
        /* 0x14 */ public GcPlanetTradingData TradingData;
        /* 0x1C */ public bool AllowUnsafeMatches;
        /* 0x1D */ public bool NeverAllowEmpty;
        /* 0x1E */ public bool NeverAllowAbandoned;
        /* 0x1F */ public bool RequireUndiscovered;
        /* 0x20 */ public bool NeedsWaterPlanet;
        /* 0x21 */ public bool NeedsExtremeSentinelPlanet;
        /* 0x22 */ public bool NeverAllowExtremeSentinelPlanet;
        /* 0x23 */ public bool NeedsExtremeWeatherPlanet;
        /* 0x24 */ public bool NeedsExtremeHazardPlanet;
        /* 0x25 */ public bool AnyBiomeNotWeirdOrDead;
        /* 0x26 */ public bool AnyRGBBiome;
        /* 0x27 */ public bool NeedsBiome;
        /* 0x28 */ public GcBiomeType NeedsBiomeType;
        /* 0x2C */ public GcBiomeSubType UseBiomeSubType;
        /* 0x30 */ public bool NeedsEmptySystem;
        /* 0x31 */ public bool NeedsAbandonedSystem;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x32 */ public byte[] Padding32;
        /* 0x38 */ public NMSString0x10 NeedsResourceHint;
        /* 0x48 */ public bool NeedsHighCreatureLevel;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x49 */ public byte[] Padding49;
        /* 0x50 */ public NMSString0x20 SamePlanetAsEvent;
    }
}

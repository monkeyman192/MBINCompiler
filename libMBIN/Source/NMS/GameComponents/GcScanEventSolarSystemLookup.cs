using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x4, Size = 0x68, GUID = 0xA11B1D7F918865AB, NameHash = 0xE523CFAD6AFB4BB6)]
    public class GcScanEventSolarSystemLookup : NMSTemplate
    {
        /* 0x00 */ public bool UseStarType;
        /* 0x01 */ public bool UseWealth;
        /* 0x02 */ public bool Usetrading;
        /* 0x04 */ public GcAlienRace Userace;
        /* 0x08 */ public GcGalaxyStarAnomaly UseAnomaly;
        /* 0x0C */ public GcPlayerConflictData UseConflict;
        /* 0x10 */ public GcGalaxyStarTypes StarType;
        /* 0x14 */ public GcPlanetTradingData TradingData;
        /* 0x1C */ public bool NeedsWaterPlanet;
        /* 0x1D */ public bool NeedsExtremeSentinelPlanet;
        /* 0x1E */ public bool NeedsExtremeWeatherPlanet;
        /* 0x1F */ public bool NeedsBiome;
        /* 0x20 */ public bool AnyRGBBiome;
        /* 0x24 */ public GcBiomeType NeedsBiomeType;
        /* 0x28 */ public bool NeedsEmptySystem;
        /* 0x29 */ public bool NeedsAbandonedSystem;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x2A */ public byte[] Padding2A;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string NeedsResourceHint;
        /* 0x40 */ public bool NeedsHighCreatureLevel;
        /* 0x41 */ public bool AllowUnsafeMatches;
        /* 0x42 */ public bool NeverAllowEmpty;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x43 */ public byte[] Padding43;
        [NMS(Size = 0x20)]
        /* 0x48 */ public string SamePlanetAsEvent;
    }
}

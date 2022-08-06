using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BD927B231CEF961, NameHash = 0xEDE680300A536215)]
    public class GcGalaxyStarAttributesData : NMSTemplate
    {
        /* 0x000 */ public GcGalaxyStarTypes Type;
        /* 0x004 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x008 */ public int NumberOfPlanets;
        /* 0x00C */ public int NumberOfPrimePlanets;
        [NMS(Size = 0x10)]
        /* 0x010 */ public GcPlanetSize[] PlanetSizes;
        [NMS(Size = 0x10)]
        /* 0x050 */ public int[] PlanetParentIndices;
        [NMS(Size = 0x10)]
        /* 0x090 */ public GcSeed[] PlanetSeeds;
        /* 0x190 */ public GcPlanetTradingData TradingData;
        /* 0x198 */ public GcPlayerConflictData ConflictData;
        /* 0x19C */ public GcAlienRace Race;
        /* 0x1A0 */ public bool AbandonedSystem;
        /* 0x1A1 */ public bool IsPirateSystem;
        /* 0x1A2 */ public bool IsSystemSafe;
    }
}

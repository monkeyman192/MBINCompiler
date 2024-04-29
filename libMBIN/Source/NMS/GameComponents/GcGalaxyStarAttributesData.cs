using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF46B7BC9D31929D1, NameHash = 0xEDE680300A536215)]
    public class GcGalaxyStarAttributesData : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x10)]
        /* 0x000 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 5, Size = 0x10)]
        /* 0x100 */ public int[] PlanetParentIndices;
        [NMS(Index = 4, Size = 0x10)]
        /* 0x140 */ public GcPlanetSize[] PlanetSizes;
        [NMS(Index = 7)]
        /* 0x180 */ public GcPlanetTradingData TradingData;
        [NMS(Index = 1)]
        /* 0x188 */ public GcGalaxyStarAnomaly Anomaly;
        [NMS(Index = 8)]
        /* 0x18C */ public GcPlayerConflictData ConflictData;
        [NMS(Index = 2)]
        /* 0x190 */ public int NumberOfPlanets;
        [NMS(Index = 3)]
        /* 0x194 */ public int NumberOfPrimePlanets;
        [NMS(Index = 9)]
        /* 0x198 */ public GcAlienRace Race;
        [NMS(Index = 0)]
        /* 0x19C */ public GcGalaxyStarTypes Type;
        [NMS(Index = 10)]
        /* 0x1A0 */ public bool AbandonedSystem;
        [NMS(Index = 11)]
        /* 0x1A1 */ public bool IsPirateSystem;
        [NMS(Index = 12)]
        /* 0x1A2 */ public bool IsSystemSafe;
    }
}

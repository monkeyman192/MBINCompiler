using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4C3376588E67EC4, NameHash = 0xEDE680300A536215)]
    public class GcGalaxyStarAttributesData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public GcSeed[] PlanetSeeds;
        [NMS(Size = 0x10)]
        /* 0x100 */ public int[] PlanetParentIndices;
        [NMS(Size = 0x10)]
        /* 0x140 */ public GcPlanetSize[] PlanetSizes;
        /* 0x180 */ public GcPlanetTradingData TradingData;
        /* 0x188 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x18C */ public GcPlayerConflictData ConflictData;
        /* 0x190 */ public int NumberOfPlanets;
        /* 0x194 */ public int NumberOfPrimePlanets;
        /* 0x198 */ public GcAlienRace Race;
        /* 0x19C */ public GcGalaxyStarTypes Type;
        /* 0x1A0 */ public bool AbandonedSystem;
        /* 0x1A1 */ public bool IsPirateSystem;
        /* 0x1A2 */ public bool IsSystemSafe;
    }
}

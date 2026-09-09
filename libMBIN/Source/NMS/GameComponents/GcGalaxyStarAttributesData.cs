using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x285B2B9584860125, NameHash = 0xA1DFF0E5)]
    public class GcGalaxyStarAttributesData : NMSTemplate
    {
        [NMS(Index = 9, Size = 0x20)]
        /* 0x000 */ public NMSString0x10[] SpacePoiIds;
        [NMS(Index = 8, Size = 0x20)]
        /* 0x200 */ public GcSeed[] SpacePoiSeeds;
        [NMS(Index = 6, Size = 0x10)]
        /* 0x400 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 10, Size = 0x20)]
        /* 0x500 */ public GcSpacePoiDiscoveryLevel[] SpacePoiInitialDiscoveryLevels;
        [NMS(Index = 7, Size = 0x20)]
        /* 0x580 */ public GcSpacePoiType[] SpacePoiTypes;
        [NMS(Index = 5, Size = 0x10)]
        /* 0x600 */ public int[] PlanetParentIndices;
        [NMS(Index = 4, Size = 0x10)]
        /* 0x640 */ public GcPlanetSize[] PlanetSizes;
        [NMS(Index = 12)]
        /* 0x680 */ public GcPlanetTradingData TradingData;
        [NMS(Index = 1)]
        /* 0x688 */ public GcGalaxyStarAnomaly Anomaly;
        [NMS(Index = 13)]
        /* 0x68C */ public GcPlayerConflictData ConflictData;
        [NMS(Index = 2)]
        /* 0x690 */ public int NumberOfPlanets;
        [NMS(Index = 3)]
        /* 0x694 */ public int NumberOfPrimePlanets;
        [NMS(Index = 11)]
        /* 0x698 */ public int NumberOfSpacePois;
        [NMS(Index = 14)]
        /* 0x69C */ public GcAlienRace Race;
        [NMS(Index = 0)]
        /* 0x6A0 */ public GcGalaxyStarTypes Type;
        [NMS(Index = 15)]
        /* 0x6A4 */ public bool AbandonedSystem;
        [NMS(Index = 19)]
        /* 0x6A5 */ public bool IsGasGiantSystem;
        [NMS(Index = 18)]
        /* 0x6A6 */ public bool IsGiantSystem;
        [NMS(Index = 16)]
        /* 0x6A7 */ public bool IsPirateSystem;
        [NMS(Index = 17)]
        /* 0x6A8 */ public bool IsSystemSafe;
    }
}

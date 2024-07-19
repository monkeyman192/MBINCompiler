namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21A746D0F922B571, NameHash = 0xC64CB688)]
    public class GcGalaxyVoxelAttributesData : NMSTemplate
    {
        [NMS(Index = 10, Size = 0xC)]
        /* 0x00 */ public int[] AtlasStationIndices;
        [NMS(Index = 9, Size = 0xC)]
        /* 0x30 */ public int[] BlackholeIndices;
        [NMS(Index = 3)]
        /* 0x60 */ public Vector2f TransitPopulationDistanceRange;
        [NMS(Index = 8)]
        /* 0x68 */ public int AtlasStationCount;
        [NMS(Index = 7)]
        /* 0x6C */ public int BlackholeCount;
        [NMS(Index = 5)]
        /* 0x70 */ public int GuideStarMinimumCount;
        [NMS(Index = 6)]
        /* 0x74 */ public int GuideStarRenegadeCount;
        [NMS(Index = 12)]
        /* 0x78 */ public int PurpleSystemsCount;
        [NMS(Index = 11)]
        /* 0x7C */ public int PurpleSystemsStart;
        [NMS(Index = 2)]
        /* 0x80 */ public float RegionColourValue;
        [NMS(Index = 4)]
        /* 0x84 */ public float TransitPopulationPerpDistance;
        [NMS(Index = 1)]
        /* 0x88 */ public float UnitDistanceFromGoalEdge;
        [NMS(Index = 0)]
        /* 0x8C */ public bool InsideGoalGap;
    }
}

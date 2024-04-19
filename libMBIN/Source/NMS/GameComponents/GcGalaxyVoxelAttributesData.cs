namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2B85C926A79352B, NameHash = 0x967BB69D82846BE5)]
    public class GcGalaxyVoxelAttributesData : NMSTemplate
    {
        [NMS(Size = 0xC)]
        /* 0x00 */ public int[] AtlasStationIndices;
        [NMS(Size = 0xC)]
        /* 0x30 */ public int[] BlackholeIndices;
        /* 0x60 */ public Vector2f TransitPopulationDistanceRange;
        /* 0x68 */ public int AtlasStationCount;
        /* 0x6C */ public int BlackholeCount;
        /* 0x70 */ public int GuideStarMinimumCount;
        /* 0x74 */ public int GuideStarRenegadeCount;
        /* 0x78 */ public float RegionColourValue;
        /* 0x7C */ public float TransitPopulationPerpDistance;
        /* 0x80 */ public float UnitDistanceFromGoalEdge;
        /* 0x84 */ public bool InsideGoalGap;
    }
}

using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyVoxelAttributesData : NMSTemplate
    {
        /* 0x00 */ public bool InsideGoalGap;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x01 */ public byte[] Padding01;
        /* 0x04 */ public float UnitDistanceFromGoalEdge;
        /* 0x08 */ public float RegionColourValue;
        /* 0x0C */ public Vector2f TransitPopulationDistanceRange;
        /* 0x14 */ public float TransitPopulationPerpDistance;
        /* 0x18 */ public int GuideStarMinimumCount;
        /* 0x1C */ public int BlackholeCount;
        /* 0x20 */ public int AtlasStationCount;
        [NMS(Size = 0xC, Ignore = false)]
        /* 0x24 */ public int[] BlackholeIndices;
        [NMS(Size = 0xC, Ignore = false)]
        /* 0x54 */ public int[] AtlasStationIndices;
    }
}

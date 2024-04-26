using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x18388706836A5878, NameHash = 0xA1EC10F083963380)]
    public class TkVoxelGeneratorRegionData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<TkNoiseFlattenPoint> FlattenTerrainPoints;
        [NMS(Index = 5)]
        /* 0x10 */ public List<float> FlattenTypeChances;
        [NMS(Index = 9, Size = 0x3)]
        /* 0x20 */ public int[] ShelterIndices;
        [NMS(Index = 8)]
        /* 0x2C */ public float AddShelterChance;
        [NMS(Index = 7)]
        /* 0x30 */ public int LandingPadIndex;
        [NMS(Index = 10)]
        /* 0x34 */ public int NumShelters;
        [NMS(Index = 0)]
        /* 0x38 */ public float PlanetRadius;
        [NMS(Index = 1)]
        /* 0x3C */ public float VoronoiPointDivisions;
        [NMS(Index = 3)]
        /* 0x40 */ public int VoronoiPointSeed;
        [NMS(Index = 2)]
        /* 0x44 */ public int VoronoiSectorSeed;
        [NMS(Index = 6)]
        /* 0x48 */ public int WaypointIndex;
    }
}

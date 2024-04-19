using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x18388706836A5878, NameHash = 0xA1EC10F083963380)]
    public class TkVoxelGeneratorRegionData : NMSTemplate
    {
        /* 0x00 */ public List<TkNoiseFlattenPoint> FlattenTerrainPoints;
        /* 0x10 */ public List<float> FlattenTypeChances;
        [NMS(Size = 0x3)]
        /* 0x20 */ public int[] ShelterIndices;
        /* 0x2C */ public float AddShelterChance;
        /* 0x30 */ public int LandingPadIndex;
        /* 0x34 */ public int NumShelters;
        /* 0x38 */ public float PlanetRadius;
        /* 0x3C */ public float VoronoiPointDivisions;
        /* 0x40 */ public int VoronoiPointSeed;
        /* 0x44 */ public int VoronoiSectorSeed;
        /* 0x48 */ public int WaypointIndex;
    }
}

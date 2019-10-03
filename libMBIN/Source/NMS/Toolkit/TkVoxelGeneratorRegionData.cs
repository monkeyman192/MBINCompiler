using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x50, GUID = 0x9CC89AEE62C3B4C6, NameHash = 0xA1EC10F083963380)]
    public class TkVoxelGeneratorRegionData : NMSTemplate
    {
        /* 0x00 */ public float PlanetRadius;
        /* 0x04 */ public float VoronoiPointDivisions;
        /* 0x08 */ public int VoronoiSectorSeed;
        /* 0x0C */ public int VoronoiPointSeed;
        /* 0x10 */ public List<TkNoiseFlattenPoint> FlattenTerrainPoints;
        /* 0x20 */ public List<float> FlattenTypeChances;
        /* 0x30 */ public int WaypointIndex;
        /* 0x34 */ public int LandingPadIndex;
        /* 0x38 */ public float AddShelterChance;

        [NMS(Size = 3)]
        /* 0x3C */ public int[] ShelterIndices;
        /* 0x48 */ public int NumShelters;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4C;
    }
}

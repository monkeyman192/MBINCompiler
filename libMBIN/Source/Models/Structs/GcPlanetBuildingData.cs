using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x70)]
    public class GcPlanetBuildingData : NMSTemplate
    {
        /* 0x00 */ public List<GcBuildingSpawnSlot> BuildingSlots;
        /* 0x10 */ public List<GcBuildingSpawnData> Buildings;
        /* 0x20 */ public List<GcBuildingOverrideData> OverrideBuildings;
        /* 0x30 */ public float Spacing;
        /* 0x34 */ public float PlanetRadius;
        /* 0x38 */ public float VoronoiPointDivisions;
        /* 0x3C */ public int VoronoiSectorSeed;
        /* 0x40 */ public int VoronoiPointSeed;
        [NMS(Size = 0x4)]
        /* 0x44 */ public float[] ClusterProbability;
        /* 0x54 */ public int WaypointIndex;
        /* 0x58 */ public int LandingPadIndex;
        /* 0x5C */ public float AddShelterChance;
        [NMS(Size = 0x3)]
        /* 0x60 */ public int[] ShelterIndices;
        /* 0x6C */ public int NumShelters;
    }
}

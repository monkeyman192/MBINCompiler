using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x42A8E984F5DD17A2, NameHash = 0xF6213EDD899A8CAE)]
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
        [NMS(Size = 0x3)]
        /* 0x44 */ public float[] ClusterProbability;
        /* 0x50 */ public int WaypointIndex;
        /* 0x54 */ public int LandingPadIndex;
        /* 0x58 */ public float AddShelterChance;
        [NMS(Size = 0x3)]
        /* 0x5C */ public int[] ShelterIndices;
        /* 0x68 */ public int NumShelters;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6C */ public byte[] EndPadding;
    }
}

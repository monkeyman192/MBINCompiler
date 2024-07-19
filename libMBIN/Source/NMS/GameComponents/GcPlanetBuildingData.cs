using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76FC3A027DE9C14, NameHash = 0xF086FF97)]
    public class GcPlanetBuildingData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcBuildingSpawnData> Buildings;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcBuildingSpawnSlot> BuildingSlots;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcBuildingOverrideData> OverrideBuildings;
        [NMS(Index = 4)]
        /* 0x30 */ public float PlanetRadius;
        [NMS(Index = 3)]
        /* 0x34 */ public float Spacing;
        [NMS(Index = 5)]
        /* 0x38 */ public float VoronoiPointDivisions;
        [NMS(Index = 7)]
        /* 0x3C */ public int VoronoiPointSeed;
        [NMS(Index = 6)]
        /* 0x40 */ public int VoronoiSectorSeed;
        [NMS(Index = 8)]
        /* 0x44 */ public bool InitialBuildingsPlaced;
        [NMS(Index = 9)]
        /* 0x45 */ public bool IsPrime;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3FC7CF047ECC29, NameHash = 0xF086FF97)]
    public class GcPlanetBuildingData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcBuildingSpawnData> Buildings;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcBuildingSpawnSlot> BuildingSlots;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcBuildingOverrideData> OverrideBuildings;
        [NMS(Index = 11)]
        /* 0x30 */ public ulong PlanetUA;
        [NMS(Index = 4)]
        /* 0x38 */ public float PlanetRadius;
        [NMS(Index = 3)]
        /* 0x3C */ public float Spacing;
        [NMS(Index = 5)]
        /* 0x40 */ public float VoronoiPointDivisions;
        [NMS(Index = 7)]
        /* 0x44 */ public int VoronoiPointSeed;
        [NMS(Index = 6)]
        /* 0x48 */ public int VoronoiSectorSeed;
        [NMS(Index = 8)]
        /* 0x4C */ public bool InitialBuildingsPlaced;
        [NMS(Index = 9)]
        /* 0x4D */ public bool IsPrime;
        [NMS(Index = 10)]
        /* 0x4E */ public bool IsWaterworld;
    }
}

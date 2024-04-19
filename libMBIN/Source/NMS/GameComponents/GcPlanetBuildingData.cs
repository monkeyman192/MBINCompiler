using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4824008ABEDCA35D, NameHash = 0xF6213EDD899A8CAE)]
    public class GcPlanetBuildingData : NMSTemplate
    {
        /* 0x00 */ public List<GcBuildingSpawnData> Buildings;
        /* 0x10 */ public List<GcBuildingSpawnSlot> BuildingSlots;
        /* 0x20 */ public List<GcBuildingOverrideData> OverrideBuildings;
        /* 0x30 */ public float PlanetRadius;
        /* 0x34 */ public float Spacing;
        /* 0x38 */ public float VoronoiPointDivisions;
        /* 0x3C */ public int VoronoiPointSeed;
        /* 0x40 */ public int VoronoiSectorSeed;
        /* 0x44 */ public bool InitialBuildingsPlaced;
        /* 0x45 */ public bool IsPrime;
    }
}

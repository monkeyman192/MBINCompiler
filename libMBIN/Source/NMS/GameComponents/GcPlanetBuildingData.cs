using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16FE2FB1C3EF0823, NameHash = 0xF6213EDD899A8CAE)]
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
        /* 0x44 */ public bool InitialBuildingsPlaced;
        /* 0x45 */ public bool IsPrime;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EEB6E34193A8D63, NameHash = 0x7F0D775900CDB2FD)]
    public class GcRegionHotspotsTable : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcRegionHotspotBiomeGases[] RegionHotspotBiomeGases;
        [NMS(Index = 7)]
        /* 0x200 */ public List<GcRegionHotspotSubstance> RegionHotspotSubstances;
        [NMS(Index = 5, Size = 0x6, EnumType = typeof(GcRegionHotspotTypes.HotspotTypeEnum))]
        /* 0x210 */ public GcRegionHotspotData[] RegionHotspots;
        [NMS(Index = 4)]
        /* 0x330 */ public float RegionHotspotsMaxDifferentCategoryOverlap;
        [NMS(Index = 3)]
        /* 0x334 */ public float RegionHotspotsMinSameCategorySpacing;
        [NMS(Index = 2)]
        /* 0x338 */ public float RegionHotspotsPerPoleMax;
        [NMS(Index = 1)]
        /* 0x33C */ public float RegionHotspotsPerPoleMin;
        [NMS(Index = 0)]
        /* 0x340 */ public float RegionHotspotsPoleSpacing;
    }
}

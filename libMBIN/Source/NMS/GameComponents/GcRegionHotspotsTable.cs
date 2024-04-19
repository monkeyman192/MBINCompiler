using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EEB6E34193A8D63, NameHash = 0x7F0D775900CDB2FD)]
    public class GcRegionHotspotsTable : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcRegionHotspotBiomeGases[] RegionHotspotBiomeGases;
        /* 0x200 */ public List<GcRegionHotspotSubstance> RegionHotspotSubstances;
        [NMS(Size = 0x6, EnumType = typeof(GcRegionHotspotTypes.HotspotTypeEnum))]
        /* 0x210 */ public GcRegionHotspotData[] RegionHotspots;
        /* 0x330 */ public float RegionHotspotsMaxDifferentCategoryOverlap;
        /* 0x334 */ public float RegionHotspotsMinSameCategorySpacing;
        /* 0x338 */ public float RegionHotspotsPerPoleMax;
        /* 0x33C */ public float RegionHotspotsPerPoleMin;
        /* 0x340 */ public float RegionHotspotsPoleSpacing;
    }
}

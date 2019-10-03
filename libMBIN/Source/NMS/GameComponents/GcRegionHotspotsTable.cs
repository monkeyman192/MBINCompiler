using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2E8, GUID = 0x4792483DC39B95E6, NameHash = 0x7F0D775900CDB2FD)]
    public class GcRegionHotspotsTable : NMSTemplate
    {
        /* 0x000 */ public float RegionHotspotsPoleSpacing;
        /* 0x004 */ public float RegionHotspotsPerPoleMin;
        /* 0x008 */ public float RegionHotspotsPerPoleMax;
        /* 0x00C */ public float RegionHotspotsMinSameCategorySpacing;
        /* 0x010 */ public float RegionHotspotsMaxDifferentCategoryOverlap;
        [NMS(Size = 0x6, EnumType = typeof(GcRegionHotspotTypes.HotspotTypeEnum))]
        /* 0x014 */ public GcRegionHotspotData[] RegionHotspots;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x134 */ public byte[] Padding134;
        [NMS(Size = 0xD)]
        /* 0x138 */ public GcRegionHotspotBiomeGases[] RegionHotspotBiomeGases;
        /* 0x2D8 */ public List<GcRegionHotspotSubstance> RegionHotspotSubstances;

    }
}

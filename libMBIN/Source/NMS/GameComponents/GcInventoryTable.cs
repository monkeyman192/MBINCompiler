using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x6F0, GUID = 0xE9E887471F44735A, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x000 */ public List<GcInventoryTableEntry> Table;
        /* 0x010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x1D0 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x4, EnumType = typeof(GcWeaponClasses.WeaponClassEnum))]
        /* 0x2E8 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x388 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x3B0 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x3E0 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0x7, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x420 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x4, EnumType = typeof(GcWeaponClasses.WeaponClassEnum))]
        /* 0x5E0 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x6E0 */ public List<GcInventoryBaseStat> BaseStats;
    }
}

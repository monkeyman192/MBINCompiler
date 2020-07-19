using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x888, GUID = 0xC17FA430FD39E3A0, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x000 */ public List<GcInventoryTableEntry> Table;
        /* 0x010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x200 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x4, EnumType = typeof(GcWeaponClasses.WeaponClassEnum))]
        /* 0x340 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x3E0 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x408 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x438 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0x8, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x478 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x4, EnumType = typeof(GcWeaponClasses.WeaponClassEnum))]
        /* 0x678 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x778 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Size = 0x8, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x788 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
    }
}

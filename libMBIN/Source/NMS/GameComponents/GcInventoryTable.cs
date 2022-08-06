using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5888E82AB3500BF3, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x000 */ public List<GcInventoryTableEntry> Table;
        /* 0x010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x340 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x5, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x4A8 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x570 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x598 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x5D8 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x618 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x5, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x858 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x998 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x9A8 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        /* 0xB58 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}

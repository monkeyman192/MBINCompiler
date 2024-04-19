using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46127FC79E756668, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0000 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x0280 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x0500 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        /* 0x0540 */ public List<GcInventoryBaseStat> BaseStats;
        /* 0x0550 */ public List<GcInventoryTableEntry> Table;
        /* 0x0560 */ public GcInventoryLayoutGenerationData GenerationData;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x1280 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        /* 0x1460 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x15F0 */ public GcInventoryCostDataEntry[] WeaponCostData;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x1780 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x17C0 */ public GcInventoryCostDataEntry VehicleCostData;
        /* 0x17E8 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}

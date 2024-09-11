using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11F7005021984766, NameHash = 0x107C2CC0)]
    public class GcInventoryTable : NMSTemplate
    {
        [NMS(Index = 7, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0000 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Index = 8, Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x0280 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        [NMS(Index = 6)]
        /* 0x0500 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Index = 9)]
        /* 0x0540 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Index = 0)]
        /* 0x0550 */ public List<GcInventoryTableEntry> Table;
        [NMS(Index = 1)]
        /* 0x0560 */ public GcInventoryLayoutGenerationData GenerationData;
        [NMS(Index = 10, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x1328 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        [NMS(Index = 2)]
        /* 0x1508 */ public GcInventoryCostData ShipCostData;
        [NMS(Index = 3, Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x1698 */ public GcInventoryCostDataEntry[] WeaponCostData;
        [NMS(Index = 5, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x1828 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        [NMS(Index = 4)]
        /* 0x1868 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Index = 11)]
        /* 0x1890 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}

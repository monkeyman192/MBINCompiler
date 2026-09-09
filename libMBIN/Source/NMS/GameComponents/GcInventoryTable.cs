using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD38E45DA07C69AF7, NameHash = 0x107C2CC0)]
    public class GcInventoryTable : NMSTemplate
    {
        [NMS(Index = 7, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0000 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Index = 8, Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x0300 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        [NMS(Index = 6)]
        /* 0x0580 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Index = 9)]
        /* 0x05C0 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Index = 0)]
        /* 0x05D0 */ public List<GcInventoryTableEntry> Table;
        [NMS(Index = 1)]
        /* 0x05E0 */ public GcInventoryLayoutGenerationData GenerationData;
        [NMS(Index = 10, Size = 0xC, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x14A4 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        [NMS(Index = 2)]
        /* 0x16E4 */ public GcInventoryCostData ShipCostData;
        [NMS(Index = 3, Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x18C4 */ public GcInventoryCostDataEntry[] WeaponCostData;
        [NMS(Index = 5, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x1A54 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        [NMS(Index = 4)]
        /* 0x1A94 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Index = 11)]
        /* 0x1ABC */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}

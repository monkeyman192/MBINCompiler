using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC1A0, GUID = 0xE7C91AF455FFD5A3, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;

        [NMS(Size = 0x10)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;

        [NMS(Size = 0x4)]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1D4 */ public byte[] Padding1D4;

        /* 0x01D8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;

        /* 0x01E8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;

        [NMS(Size = 0x80)]
        /* 0x0388 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0408 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x0488 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x0508 */ public string ProceduralProductTable;
        [NMS(Size = 0x80)]
        /* 0x0588 */ public string ProceduralTechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0608 */ public string LegacyItemConversionTable;

        /* 0x0688 */ public List<TkRawID> LegacyRepairTable;

        [NMS(Size = 0x80)]
        /* 0x0698 */ public string ConsumableItemTable;

        [NMS(Size = 0x80)]
        /* 0x0718 */ public string RecipeTable;

        [NMS(Size = 0x80)]
        /* 0x0798 */ public string AlienWordsTable;
        /* 0x0818 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x65, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0828 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x65, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0890 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0A24 */ public TkCurveType[] WeightingCurves;
        /* 0x0A40 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Size = 0x80)]
        /* 0x0A50 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0AD0 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x0B50 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0BD0 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0C50 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0CD0 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0D50 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0DD0 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0E50 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0ED0 */ public string MaintenanceGroupsTable;
        [NMS(Size = 0x80)]
        /* 0x0F50 */ public string UnlockableItemTrees;
        /* 0x0FD0 */ public List<GcFreighterCargoOption> FreighterCargoOptions;

        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x0FE0 */ public GcShipWeaponData[] ShipWeapons;

        [NMS(Size = 0xA, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x11A0 */ public GcPlayerWeaponData[] PlayerWeapons;

        [NMS(Size = 0x6, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1240 */ public TkIDArray[] DefaultVehicleLoadout;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x12A0 */ public NMSString0x10[] FactionStandingIDs;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1320 */ public NMSString0x20[] FactionNames;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1420 */ public GcNumberedTextList[] FactionClients;

        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1540 */ public GcNumberedTextList[] MissionNameFormats;

        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x16CC */ public GcNumberedTextList[] MissionNameAdjectives;

        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1858 */ public GcNumberedTextList[] MissionNameNouns;

        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x19E4 */ public float[] WeightedTextWeights;

        /* 0x19F0 */ public GcRealityIconTable Icons;

        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x63F0 */ public Colour[] HazardColours;

        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6450 */ public Colour[] RarityColours;

        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6480 */ public Colour[] SubstanceCategoryColours;

        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6510 */ public TkTextureResource[] SubstanceChargeIcons;

        [NMS(Size = 0x92, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x69B4 */ public TkTextureResource[] StatCategoryIcons;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0xB4FC */ public byte[] PaddingB4FC;

        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xB500 */ public GcStats[] Stats;

        /* 0xB550 */ public GcTechList StationTechShops;

        [NMS(Size = 0xD)]
        /* 0xB560 */ public GcTechList[] PlanetTechShops;

        /* 0xB630 */ public GcTradeSettings TradeSettings;
        /* 0xC080 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xC0A0 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xC0C0 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xC0E0 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xC100 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xC120 */ public List<int> SuitUpgradePrices;
        /* 0xC130 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xC140 */ public List<int> SuitCargoUpgradePrices;
        /* 0xC150 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xC160 */ public List<NMSString0x10> NeverOfferedForSale;

        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xC170 */ public float[] NormalizedPriceLimits;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0xC184 */ public byte[] PaddingC184;

        /* 0xC188 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0xC198 */ public byte[] EndPadding;
    }
}

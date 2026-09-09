using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6F703550A62C201, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 69, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 68, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0100 */ public Colour[] RarityColours;
        [NMS(Index = 66)]
        /* 0x0130 */ public GcRealityIconTable Icons;
        [NMS(Index = 78)]
        /* 0x1E10 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 71, Size = 0xD1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x3770 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 72, Size = 0xD1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x4B08 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 61, Size = 0x24, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5EA0 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 60, Size = 0x24, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x6200 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 62, Size = 0x24, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x6560 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x68C0 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 54, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x6AE0 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 55, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x6CA0 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 58, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6DF0 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 77, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6F30 */ public GcRepShopData[] RepShops;
        [NMS(Index = 76, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x7070 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 59, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x7180 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 70, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x7270 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 63, Size = 0xB)]
        /* 0x7348 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 57, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x73F8 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 56, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x7498 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 94, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x7508 */ public GcFilename[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 74, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x7558 */ public GcStats[] Stats;
        [NMS(Index = 8, Size = 0x3, EnumType = typeof(GcProductTableType.ProductTableTypeEnum))]
        /* 0x75A8 */ public GcFilename[] ProductTables;
        [NMS(Index = 85)]
        /* 0x75D8 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 83)]
        /* 0x75F0 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 84)]
        /* 0x7608 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 82)]
        /* 0x7620 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 80)]
        /* 0x7638 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 81)]
        /* 0x7650 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 28)]
        /* 0x7668 */ public List<GcFilename> AlienPuzzleTables;
        [NMS(Index = 27)]
        /* 0x7678 */ public GcFilename AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x7688 */ public GcFilename BaitDataTable;
        [NMS(Index = 64)]
        /* 0x7698 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 51)]
        /* 0x76A8 */ public GcFilename CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x76B8 */ public GcFilename ConsumableItemTable;
        [NMS(Index = 44)]
        /* 0x76C8 */ public GcFilename CostTable;
        [NMS(Index = 32)]
        /* 0x76D8 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 38)]
        /* 0x76E8 */ public GcFilename DamageTable;
        [NMS(Index = 16)]
        /* 0x76F8 */ public GcFilename DialogClearanceTable;
        [NMS(Index = 35)]
        /* 0x7708 */ public GcFilename DiscoveryRewardTable;
        [NMS(Index = 92)]
        /* 0x7718 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x7728 */ public GcFilename FishDataTable;
        [NMS(Index = 93)]
        /* 0x7738 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 53)]
        /* 0x7748 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 21)]
        /* 0x7758 */ public GcFilename GameTableDiceDataTable;
        [NMS(Index = 33)]
        /* 0x7768 */ public GcFilename HistoricalSeasonDataTable;
        [NMS(Index = 37)]
        /* 0x7778 */ public GcFilename InventoryTable;
        [NMS(Index = 17)]
        /* 0x7788 */ public GcFilename ItemDescriptionOverrideTable;
        [NMS(Index = 11)]
        /* 0x7798 */ public GcFilename LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x77A8 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 47)]
        /* 0x77B8 */ public GcFilename MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x77C8 */ public GcFilename MaintenanceOverrideTable;
        [NMS(Index = 90)]
        /* 0x77D8 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 89)]
        /* 0x77E8 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 23)]
        /* 0x77F8 */ public GcFilename PetBattlerMoveSetsTable;
        [NMS(Index = 22)]
        /* 0x7808 */ public GcFilename PetBattlerMovesTable;
        [NMS(Index = 24)]
        /* 0x7818 */ public GcFilename PetShopItemTable;
        [NMS(Index = 79)]
        /* 0x7828 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 50)]
        /* 0x7838 */ public GcFilename PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x7848 */ public GcFilename ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x7858 */ public GcFilename ProceduralTechnologyTable;
        [NMS(Index = 39)]
        /* 0x7868 */ public GcFilename PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 40)]
        /* 0x7878 */ public GcFilename PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x7888 */ public GcFilename RecipeTable;
        [NMS(Index = 34)]
        /* 0x7898 */ public GcFilename RewardTable;
        [NMS(Index = 49)]
        /* 0x78A8 */ public GcFilename SettlementPerksTable;
        [NMS(Index = 26)]
        /* 0x78B8 */ public GcFilename SpacePoiTable;
        [NMS(Index = 75)]
        /* 0x78C8 */ public GcTechList StationTechShops;
        [NMS(Index = 36)]
        /* 0x78D8 */ public GcFilename StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x78E8 */ public GcFilename StoriesTable;
        [NMS(Index = 4)]
        /* 0x78F8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x7908 */ public GcFilename SubstanceTable;
        [NMS(Index = 88)]
        /* 0x7918 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 87)]
        /* 0x7928 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 86)]
        /* 0x7938 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 25)]
        /* 0x7948 */ public GcFilename SwarmDataTable;
        [NMS(Index = 52)]
        /* 0x7958 */ public GcFilename TechBoxTable;
        [NMS(Index = 6)]
        /* 0x7968 */ public GcFilename TechnologyTable;
        [NMS(Index = 46)]
        /* 0x7978 */ public GcFilename TradingClassDataTable;
        [NMS(Index = 45)]
        /* 0x7988 */ public GcFilename TradingCostTable;
        [NMS(Index = 48)]
        /* 0x7998 */ public GcFilename UnlockableItemTrees;
        [NMS(Index = 43)]
        /* 0x79A8 */ public GcFilename UnlockablePlatformRewardsTable;
        [NMS(Index = 41)]
        /* 0x79B8 */ public GcFilename UnlockableSeasonRewardsTable;
        [NMS(Index = 42)]
        /* 0x79C8 */ public GcFilename UnlockableTwitchRewardsTable;
        [NMS(Index = 73, Size = 0xD1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x79D8 */ public GcMinMaxFloat[] FoodStatValues;
        [NMS(Index = 30, Size = 0xA2, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x8060 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x13, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x82E8 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 91, Size = 0x5)]
        /* 0x84FC */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x8510 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 65, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x8520 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x852C */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x852E */ public ushort RealityIteration;
        [NMS(Index = 29, Size = 0xA2, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x8530 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 31, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x85D2 */ public TkCurveType[] WeightingCurves;
    }
}

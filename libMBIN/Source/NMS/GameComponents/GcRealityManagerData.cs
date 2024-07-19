using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x887F17FEDF63CFBC, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 61, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 59, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 60, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x00F0 */ public Colour[] RarityColours;
        [NMS(Index = 69)]
        /* 0x0120 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 63, Size = 0xC3, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x13D0 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 64, Size = 0xC3, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x2618 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 58)]
        /* 0x3860 */ public GcRealityIconTable Icons;
        [NMS(Index = 53, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4A90 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 52, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4CA0 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 54, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4EB0 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x50C0 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 46, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x52C0 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 50, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5480 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 68, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x55C0 */ public GcRepShopData[] RepShops;
        [NMS(Index = 47, Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x5700 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 67, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x5830 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5930 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 62, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x5A20 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 55, Size = 0xB)]
        /* 0x5AF8 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 49, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5BA8 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x5C48 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 85, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x5CB8 */ public VariableSizeString[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 65, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x5D08 */ public GcStats[] Stats;
        [NMS(Index = 76)]
        /* 0x5D58 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 74)]
        /* 0x5D70 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 75)]
        /* 0x5D88 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 73)]
        /* 0x5DA0 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 71)]
        /* 0x5DB8 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 72)]
        /* 0x5DD0 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 20)]
        /* 0x5DE8 */ public List<VariableSizeString> AlienPuzzleTables;
        [NMS(Index = 19)]
        /* 0x5DF8 */ public VariableSizeString AlienWordsTable;
        [NMS(Index = 56)]
        /* 0x5E08 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 43)]
        /* 0x5E18 */ public VariableSizeString CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x5E28 */ public VariableSizeString ConsumableItemTable;
        [NMS(Index = 36)]
        /* 0x5E38 */ public VariableSizeString CostTable;
        [NMS(Index = 24)]
        /* 0x5E48 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 30)]
        /* 0x5E58 */ public VariableSizeString DamageTable;
        [NMS(Index = 16)]
        /* 0x5E68 */ public VariableSizeString DialogClearanceTable;
        [NMS(Index = 27)]
        /* 0x5E78 */ public VariableSizeString DiscoveryRewardTable;
        [NMS(Index = 83)]
        /* 0x5E88 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 84)]
        /* 0x5E98 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 45)]
        /* 0x5EA8 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 25)]
        /* 0x5EB8 */ public VariableSizeString HistoricalSeasonDataTable;
        [NMS(Index = 29)]
        /* 0x5EC8 */ public VariableSizeString InventoryTable;
        [NMS(Index = 11)]
        /* 0x5ED8 */ public VariableSizeString LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x5EE8 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 39)]
        /* 0x5EF8 */ public VariableSizeString MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x5F08 */ public VariableSizeString MaintenanceOverrideTable;
        [NMS(Index = 81)]
        /* 0x5F18 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 80)]
        /* 0x5F28 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 70)]
        /* 0x5F38 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 42)]
        /* 0x5F48 */ public VariableSizeString PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x5F58 */ public VariableSizeString ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x5F68 */ public VariableSizeString ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x5F78 */ public VariableSizeString ProductDescriptionOverrideTable;
        [NMS(Index = 8)]
        /* 0x5F88 */ public VariableSizeString ProductTable;
        [NMS(Index = 31)]
        /* 0x5F98 */ public VariableSizeString PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 32)]
        /* 0x5FA8 */ public VariableSizeString PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x5FB8 */ public VariableSizeString RecipeTable;
        [NMS(Index = 26)]
        /* 0x5FC8 */ public VariableSizeString RewardTable;
        [NMS(Index = 41)]
        /* 0x5FD8 */ public VariableSizeString SettlementPerksTable;
        [NMS(Index = 66)]
        /* 0x5FE8 */ public GcTechList StationTechShops;
        [NMS(Index = 28)]
        /* 0x5FF8 */ public VariableSizeString StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x6008 */ public VariableSizeString StoriesTable;
        [NMS(Index = 4)]
        /* 0x6018 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x6028 */ public VariableSizeString SubstanceTable;
        [NMS(Index = 79)]
        /* 0x6038 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 78)]
        /* 0x6048 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 77)]
        /* 0x6058 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 44)]
        /* 0x6068 */ public VariableSizeString TechBoxTable;
        [NMS(Index = 6)]
        /* 0x6078 */ public VariableSizeString TechnologyTable;
        [NMS(Index = 38)]
        /* 0x6088 */ public VariableSizeString TradingClassDataTable;
        [NMS(Index = 37)]
        /* 0x6098 */ public VariableSizeString TradingCostTable;
        [NMS(Index = 40)]
        /* 0x60A8 */ public VariableSizeString UnlockableItemTrees;
        [NMS(Index = 35)]
        /* 0x60B8 */ public VariableSizeString UnlockablePlatformRewardsTable;
        [NMS(Index = 33)]
        /* 0x60C8 */ public VariableSizeString UnlockableSeasonRewardsTable;
        [NMS(Index = 34)]
        /* 0x60D8 */ public VariableSizeString UnlockableTwitchRewardsTable;
        [NMS(Index = 22, Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x60E8 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x6318 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 82, Size = 0x5)]
        /* 0x64F4 */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x6508 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 57, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6518 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x6524 */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x6526 */ public ushort RealityIteration;
        [NMS(Index = 21, Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x6528 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 23, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x65B4 */ public TkCurveType[] WeightingCurves;
    }
}

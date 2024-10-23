using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB249DA5FE95C2124, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 63, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 61, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 62, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0100 */ public Colour[] RarityColours;
        [NMS(Index = 60)]
        /* 0x0130 */ public GcRealityIconTable Icons;
        [NMS(Index = 71)]
        /* 0x13F0 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 65, Size = 0xC7, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x26A0 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 66, Size = 0xC7, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x3948 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 55, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4BF0 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 54, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4E00 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 56, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5010 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x5220 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x5420 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 52, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x55E0 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 49, Size = 0x14, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x5720 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 70, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5860 */ public GcRepShopData[] RepShops;
        [NMS(Index = 69, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x59A0 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 53, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5AA0 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 64, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x5B90 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 57, Size = 0xB)]
        /* 0x5C68 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5D18 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x5DB8 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 87, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x5E28 */ public VariableSizeString[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 67, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x5E78 */ public GcStats[] Stats;
        [NMS(Index = 78)]
        /* 0x5EC8 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 76)]
        /* 0x5EE0 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 77)]
        /* 0x5EF8 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 75)]
        /* 0x5F10 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 73)]
        /* 0x5F28 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 74)]
        /* 0x5F40 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 22)]
        /* 0x5F58 */ public List<VariableSizeString> AlienPuzzleTables;
        [NMS(Index = 21)]
        /* 0x5F68 */ public VariableSizeString AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x5F78 */ public VariableSizeString BaitDataTable;
        [NMS(Index = 58)]
        /* 0x5F88 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 45)]
        /* 0x5F98 */ public VariableSizeString CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x5FA8 */ public VariableSizeString ConsumableItemTable;
        [NMS(Index = 38)]
        /* 0x5FB8 */ public VariableSizeString CostTable;
        [NMS(Index = 26)]
        /* 0x5FC8 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 32)]
        /* 0x5FD8 */ public VariableSizeString DamageTable;
        [NMS(Index = 16)]
        /* 0x5FE8 */ public VariableSizeString DialogClearanceTable;
        [NMS(Index = 29)]
        /* 0x5FF8 */ public VariableSizeString DiscoveryRewardTable;
        [NMS(Index = 85)]
        /* 0x6008 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x6018 */ public VariableSizeString FishDataTable;
        [NMS(Index = 86)]
        /* 0x6028 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 47)]
        /* 0x6038 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 27)]
        /* 0x6048 */ public VariableSizeString HistoricalSeasonDataTable;
        [NMS(Index = 31)]
        /* 0x6058 */ public VariableSizeString InventoryTable;
        [NMS(Index = 11)]
        /* 0x6068 */ public VariableSizeString LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x6078 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 41)]
        /* 0x6088 */ public VariableSizeString MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x6098 */ public VariableSizeString MaintenanceOverrideTable;
        [NMS(Index = 83)]
        /* 0x60A8 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 82)]
        /* 0x60B8 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 72)]
        /* 0x60C8 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 44)]
        /* 0x60D8 */ public VariableSizeString PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x60E8 */ public VariableSizeString ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x60F8 */ public VariableSizeString ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x6108 */ public VariableSizeString ProductDescriptionOverrideTable;
        [NMS(Index = 8)]
        /* 0x6118 */ public VariableSizeString ProductTable;
        [NMS(Index = 33)]
        /* 0x6128 */ public VariableSizeString PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 34)]
        /* 0x6138 */ public VariableSizeString PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x6148 */ public VariableSizeString RecipeTable;
        [NMS(Index = 28)]
        /* 0x6158 */ public VariableSizeString RewardTable;
        [NMS(Index = 43)]
        /* 0x6168 */ public VariableSizeString SettlementPerksTable;
        [NMS(Index = 68)]
        /* 0x6178 */ public GcTechList StationTechShops;
        [NMS(Index = 30)]
        /* 0x6188 */ public VariableSizeString StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x6198 */ public VariableSizeString StoriesTable;
        [NMS(Index = 4)]
        /* 0x61A8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x61B8 */ public VariableSizeString SubstanceTable;
        [NMS(Index = 81)]
        /* 0x61C8 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 80)]
        /* 0x61D8 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 79)]
        /* 0x61E8 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 46)]
        /* 0x61F8 */ public VariableSizeString TechBoxTable;
        [NMS(Index = 6)]
        /* 0x6208 */ public VariableSizeString TechnologyTable;
        [NMS(Index = 40)]
        /* 0x6218 */ public VariableSizeString TradingClassDataTable;
        [NMS(Index = 39)]
        /* 0x6228 */ public VariableSizeString TradingCostTable;
        [NMS(Index = 42)]
        /* 0x6238 */ public VariableSizeString UnlockableItemTrees;
        [NMS(Index = 37)]
        /* 0x6248 */ public VariableSizeString UnlockablePlatformRewardsTable;
        [NMS(Index = 35)]
        /* 0x6258 */ public VariableSizeString UnlockableSeasonRewardsTable;
        [NMS(Index = 36)]
        /* 0x6268 */ public VariableSizeString UnlockableTwitchRewardsTable;
        [NMS(Index = 24, Size = 0x8E, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x6278 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x64B0 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 84, Size = 0x5)]
        /* 0x668C */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x66A0 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 59, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x66B0 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x66BC */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x66BE */ public ushort RealityIteration;
        [NMS(Index = 23, Size = 0x8E, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x66C0 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 25, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x674E */ public TkCurveType[] WeightingCurves;
    }
}

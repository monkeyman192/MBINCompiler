using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E58BC4C25637534, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 63, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 61, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 62, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x00F0 */ public Colour[] RarityColours;
        [NMS(Index = 71)]
        /* 0x0120 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 60)]
        /* 0x13D0 */ public GcRealityIconTable Icons;
        [NMS(Index = 65, Size = 0xC5, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x2648 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 66, Size = 0xC5, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x38C0 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 55, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4B38 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 54, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4D48 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 56, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4F58 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x5168 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x5368 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 52, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5528 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 49, Size = 0x14, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x5668 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 70, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x57A8 */ public GcRepShopData[] RepShops;
        [NMS(Index = 69, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x58E8 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 53, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x59E8 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 64, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x5AD8 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 57, Size = 0xB)]
        /* 0x5BB0 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5C60 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x5D00 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 87, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x5D70 */ public VariableSizeString[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 67, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x5DC0 */ public GcStats[] Stats;
        [NMS(Index = 78)]
        /* 0x5E10 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 76)]
        /* 0x5E28 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 77)]
        /* 0x5E40 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 75)]
        /* 0x5E58 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 73)]
        /* 0x5E70 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 74)]
        /* 0x5E88 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 22)]
        /* 0x5EA0 */ public List<VariableSizeString> AlienPuzzleTables;
        [NMS(Index = 21)]
        /* 0x5EB0 */ public VariableSizeString AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x5EC0 */ public VariableSizeString BaitDataTable;
        [NMS(Index = 58)]
        /* 0x5ED0 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 45)]
        /* 0x5EE0 */ public VariableSizeString CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x5EF0 */ public VariableSizeString ConsumableItemTable;
        [NMS(Index = 38)]
        /* 0x5F00 */ public VariableSizeString CostTable;
        [NMS(Index = 26)]
        /* 0x5F10 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 32)]
        /* 0x5F20 */ public VariableSizeString DamageTable;
        [NMS(Index = 16)]
        /* 0x5F30 */ public VariableSizeString DialogClearanceTable;
        [NMS(Index = 29)]
        /* 0x5F40 */ public VariableSizeString DiscoveryRewardTable;
        [NMS(Index = 85)]
        /* 0x5F50 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x5F60 */ public VariableSizeString FishDataTable;
        [NMS(Index = 86)]
        /* 0x5F70 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 47)]
        /* 0x5F80 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 27)]
        /* 0x5F90 */ public VariableSizeString HistoricalSeasonDataTable;
        [NMS(Index = 31)]
        /* 0x5FA0 */ public VariableSizeString InventoryTable;
        [NMS(Index = 11)]
        /* 0x5FB0 */ public VariableSizeString LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x5FC0 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 41)]
        /* 0x5FD0 */ public VariableSizeString MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x5FE0 */ public VariableSizeString MaintenanceOverrideTable;
        [NMS(Index = 83)]
        /* 0x5FF0 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 82)]
        /* 0x6000 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 72)]
        /* 0x6010 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 44)]
        /* 0x6020 */ public VariableSizeString PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x6030 */ public VariableSizeString ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x6040 */ public VariableSizeString ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x6050 */ public VariableSizeString ProductDescriptionOverrideTable;
        [NMS(Index = 8)]
        /* 0x6060 */ public VariableSizeString ProductTable;
        [NMS(Index = 33)]
        /* 0x6070 */ public VariableSizeString PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 34)]
        /* 0x6080 */ public VariableSizeString PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x6090 */ public VariableSizeString RecipeTable;
        [NMS(Index = 28)]
        /* 0x60A0 */ public VariableSizeString RewardTable;
        [NMS(Index = 43)]
        /* 0x60B0 */ public VariableSizeString SettlementPerksTable;
        [NMS(Index = 68)]
        /* 0x60C0 */ public GcTechList StationTechShops;
        [NMS(Index = 30)]
        /* 0x60D0 */ public VariableSizeString StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x60E0 */ public VariableSizeString StoriesTable;
        [NMS(Index = 4)]
        /* 0x60F0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x6100 */ public VariableSizeString SubstanceTable;
        [NMS(Index = 81)]
        /* 0x6110 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 80)]
        /* 0x6120 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 79)]
        /* 0x6130 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 46)]
        /* 0x6140 */ public VariableSizeString TechBoxTable;
        [NMS(Index = 6)]
        /* 0x6150 */ public VariableSizeString TechnologyTable;
        [NMS(Index = 40)]
        /* 0x6160 */ public VariableSizeString TradingClassDataTable;
        [NMS(Index = 39)]
        /* 0x6170 */ public VariableSizeString TradingCostTable;
        [NMS(Index = 42)]
        /* 0x6180 */ public VariableSizeString UnlockableItemTrees;
        [NMS(Index = 37)]
        /* 0x6190 */ public VariableSizeString UnlockablePlatformRewardsTable;
        [NMS(Index = 35)]
        /* 0x61A0 */ public VariableSizeString UnlockableSeasonRewardsTable;
        [NMS(Index = 36)]
        /* 0x61B0 */ public VariableSizeString UnlockableTwitchRewardsTable;
        [NMS(Index = 24, Size = 0x8E, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x61C0 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x63F8 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 84, Size = 0x5)]
        /* 0x65D4 */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x65E8 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 59, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x65F8 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x6604 */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x6606 */ public ushort RealityIteration;
        [NMS(Index = 23, Size = 0x8E, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x6608 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 25, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x6696 */ public TkCurveType[] WeightingCurves;
    }
}

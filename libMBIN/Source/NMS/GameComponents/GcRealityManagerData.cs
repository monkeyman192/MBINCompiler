using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x563435482D64E02C, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 69, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 68, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0100 */ public Colour[] RarityColours;
        [NMS(Index = 78)]
        /* 0x0130 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 66)]
        /* 0x65C8 */ public GcRealityIconTable Icons;
        [NMS(Index = 71, Size = 0xD1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x82C0 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 72, Size = 0xD1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x9658 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 61, Size = 0x25, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0xA9F0 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 60, Size = 0x25, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0xAD68 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 62, Size = 0x25, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0xB0E0 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0xB458 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 54, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0xB678 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 55, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0xB838 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 58, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0xB988 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 77, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0xBAC8 */ public GcRepShopData[] RepShops;
        [NMS(Index = 76, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xBC08 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 59, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0xBD18 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 70, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0xBE08 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 63, Size = 0xB)]
        /* 0xBEE0 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 57, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0xBF90 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 56, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0xC030 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 94, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0xC0A0 */ public GcFilename[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 74, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0xC0F0 */ public GcStats[] Stats;
        [NMS(Index = 8, Size = 0x3, EnumType = typeof(GcProductTableType.ProductTableTypeEnum))]
        /* 0xC140 */ public GcFilename[] ProductTables;
        [NMS(Index = 85)]
        /* 0xC170 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 83)]
        /* 0xC188 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 84)]
        /* 0xC1A0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 82)]
        /* 0xC1B8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 80)]
        /* 0xC1D0 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 81)]
        /* 0xC1E8 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 28)]
        /* 0xC200 */ public List<GcFilename> AlienPuzzleTables;
        [NMS(Index = 27)]
        /* 0xC210 */ public GcFilename AlienWordsTable;
        [NMS(Index = 20)]
        /* 0xC220 */ public GcFilename BaitDataTable;
        [NMS(Index = 64)]
        /* 0xC230 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 51)]
        /* 0xC240 */ public GcFilename CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0xC250 */ public GcFilename ConsumableItemTable;
        [NMS(Index = 44)]
        /* 0xC260 */ public GcFilename CostTable;
        [NMS(Index = 32)]
        /* 0xC270 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 38)]
        /* 0xC280 */ public GcFilename DamageTable;
        [NMS(Index = 16)]
        /* 0xC290 */ public GcFilename DialogClearanceTable;
        [NMS(Index = 35)]
        /* 0xC2A0 */ public GcFilename DiscoveryRewardTable;
        [NMS(Index = 92)]
        /* 0xC2B0 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0xC2C0 */ public GcFilename FishDataTable;
        [NMS(Index = 93)]
        /* 0xC2D0 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 53)]
        /* 0xC2E0 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 21)]
        /* 0xC2F0 */ public GcFilename GameTableDiceDataTable;
        [NMS(Index = 33)]
        /* 0xC300 */ public GcFilename HistoricalSeasonDataTable;
        [NMS(Index = 37)]
        /* 0xC310 */ public GcFilename InventoryTable;
        [NMS(Index = 17)]
        /* 0xC320 */ public GcFilename ItemDescriptionOverrideTable;
        [NMS(Index = 11)]
        /* 0xC330 */ public GcFilename LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0xC340 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 47)]
        /* 0xC350 */ public GcFilename MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0xC360 */ public GcFilename MaintenanceOverrideTable;
        [NMS(Index = 90)]
        /* 0xC370 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 89)]
        /* 0xC380 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 23)]
        /* 0xC390 */ public GcFilename PetBattlerMoveSetsTable;
        [NMS(Index = 22)]
        /* 0xC3A0 */ public GcFilename PetBattlerMovesTable;
        [NMS(Index = 24)]
        /* 0xC3B0 */ public GcFilename PetShopItemTable;
        [NMS(Index = 79)]
        /* 0xC3C0 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 50)]
        /* 0xC3D0 */ public GcFilename PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0xC3E0 */ public GcFilename ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0xC3F0 */ public GcFilename ProceduralTechnologyTable;
        [NMS(Index = 39)]
        /* 0xC400 */ public GcFilename PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 40)]
        /* 0xC410 */ public GcFilename PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0xC420 */ public GcFilename RecipeTable;
        [NMS(Index = 34)]
        /* 0xC430 */ public GcFilename RewardTable;
        [NMS(Index = 49)]
        /* 0xC440 */ public GcFilename SettlementPerksTable;
        [NMS(Index = 26)]
        /* 0xC450 */ public GcFilename SpacePoiTable;
        [NMS(Index = 75)]
        /* 0xC460 */ public GcTechList StationTechShops;
        [NMS(Index = 36)]
        /* 0xC470 */ public GcFilename StatRewardsTable;
        [NMS(Index = 15)]
        /* 0xC480 */ public GcFilename StoriesTable;
        [NMS(Index = 4)]
        /* 0xC490 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0xC4A0 */ public GcFilename SubstanceTable;
        [NMS(Index = 88)]
        /* 0xC4B0 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 87)]
        /* 0xC4C0 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 86)]
        /* 0xC4D0 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 25)]
        /* 0xC4E0 */ public GcFilename SwarmDataTable;
        [NMS(Index = 52)]
        /* 0xC4F0 */ public GcFilename TechBoxTable;
        [NMS(Index = 6)]
        /* 0xC500 */ public GcFilename TechnologyTable;
        [NMS(Index = 46)]
        /* 0xC510 */ public GcFilename TradingClassDataTable;
        [NMS(Index = 45)]
        /* 0xC520 */ public GcFilename TradingCostTable;
        [NMS(Index = 48)]
        /* 0xC530 */ public GcFilename UnlockableItemTrees;
        [NMS(Index = 43)]
        /* 0xC540 */ public GcFilename UnlockablePlatformRewardsTable;
        [NMS(Index = 41)]
        /* 0xC550 */ public GcFilename UnlockableSeasonRewardsTable;
        [NMS(Index = 42)]
        /* 0xC560 */ public GcFilename UnlockableTwitchRewardsTable;
        [NMS(Index = 73, Size = 0xD1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0xC570 */ public GcMinMaxFloat[] FoodStatValues;
        [NMS(Index = 30, Size = 0xA4, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0xCBF8 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x13, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0xCE88 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 91, Size = 0x5)]
        /* 0xD09C */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0xD0B0 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 65, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0xD0C0 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0xD0CC */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0xD0CE */ public ushort RealityIteration;
        [NMS(Index = 29, Size = 0xA4, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0xD0D0 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 31, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0xD174 */ public TkCurveType[] WeightingCurves;
    }
}

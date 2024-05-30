using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14B4E0820B08A612, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 61, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x00000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 59, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x00090 */ public Colour[] HazardColours;
        [NMS(Index = 60, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000F0 */ public Colour[] RarityColours;
        [NMS(Index = 58)]
        /* 0x00120 */ public GcRealityIconTable Icons;
        [NMS(Index = 69)]
        /* 0x06358 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 5)]
        /* 0x07608 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 46, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x07808 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 50, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x079C8 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 68, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x07B08 */ public GcRepShopData[] RepShops;
        [NMS(Index = 47, Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x07C48 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 67, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x07D78 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 55, Size = 0xB)]
        /* 0x07E78 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 49, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x07F28 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x07FC8 */ public TkIdArray[] DefaultVehicleLoadout;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 65, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x08038 */ public GcStats[] Stats;
        [NMS(Index = 76)]
        /* 0x08088 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 74)]
        /* 0x080A0 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 75)]
        /* 0x080B8 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 73)]
        /* 0x080D0 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 71)]
        /* 0x080E8 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 72)]
        /* 0x08100 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 20)]
        /* 0x08118 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Index = 56)]
        /* 0x08128 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 24)]
        /* 0x08138 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 83)]
        /* 0x08148 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 84)]
        /* 0x08158 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 45)]
        /* 0x08168 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 12)]
        /* 0x08178 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 81)]
        /* 0x08188 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 80)]
        /* 0x08198 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 70)]
        /* 0x081A8 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 66)]
        /* 0x081B8 */ public GcTechList StationTechShops;
        [NMS(Index = 4)]
        /* 0x081C8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 79)]
        /* 0x081D8 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 78)]
        /* 0x081E8 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 77)]
        /* 0x081F8 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 63, Size = 0xBF, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x08208 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 64, Size = 0xBF, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0E484 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 62, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x14700 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 53, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x14BA4 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 52, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x14EBC */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 54, Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x151D4 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 22, Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x154EC */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x1571C */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x158F8 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 82, Size = 0x5)]
        /* 0x15A60 */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x15A74 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 57, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x15A84 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x15A90 */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x15A92 */ public ushort RealityIteration;
        [NMS(Index = 85, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x15A94 */ public NMSString0x80[] Catalogues;
        [NMS(Index = 21, Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x15D14 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 19)]
        /* 0x15DA0 */ public NMSString0x80 AlienWordsTable;
        [NMS(Index = 43)]
        /* 0x15E20 */ public NMSString0x80 CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x15EA0 */ public NMSString0x80 ConsumableItemTable;
        [NMS(Index = 36)]
        /* 0x15F20 */ public NMSString0x80 CostTable;
        [NMS(Index = 30)]
        /* 0x15FA0 */ public NMSString0x80 DamageTable;
        [NMS(Index = 16)]
        /* 0x16020 */ public NMSString0x80 DialogClearanceTable;
        [NMS(Index = 27)]
        /* 0x160A0 */ public NMSString0x80 DiscoveryRewardTable;
        [NMS(Index = 25)]
        /* 0x16120 */ public NMSString0x80 HistoricalSeasonDataTable;
        [NMS(Index = 29)]
        /* 0x161A0 */ public NMSString0x80 InventoryTable;
        [NMS(Index = 11)]
        /* 0x16220 */ public NMSString0x80 LegacyItemConversionTable;
        [NMS(Index = 39)]
        /* 0x162A0 */ public NMSString0x80 MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x16320 */ public NMSString0x80 MaintenanceOverrideTable;
        [NMS(Index = 42)]
        /* 0x163A0 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x16420 */ public NMSString0x80 ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x164A0 */ public NMSString0x80 ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x16520 */ public NMSString0x80 ProductDescriptionOverrideTable;
        [NMS(Index = 8)]
        /* 0x165A0 */ public NMSString0x80 ProductTable;
        [NMS(Index = 31)]
        /* 0x16620 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 32)]
        /* 0x166A0 */ public NMSString0x80 PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x16720 */ public NMSString0x80 RecipeTable;
        [NMS(Index = 26)]
        /* 0x167A0 */ public NMSString0x80 RewardTable;
        [NMS(Index = 41)]
        /* 0x16820 */ public NMSString0x80 SettlementPerksTable;
        [NMS(Index = 28)]
        /* 0x168A0 */ public NMSString0x80 StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x16920 */ public NMSString0x80 StoriesTable;
        [NMS(Index = 7)]
        /* 0x169A0 */ public NMSString0x80 SubstanceTable;
        [NMS(Index = 44)]
        /* 0x16A20 */ public NMSString0x80 TechBoxTable;
        [NMS(Index = 6)]
        /* 0x16AA0 */ public NMSString0x80 TechnologyTable;
        [NMS(Index = 38)]
        /* 0x16B20 */ public NMSString0x80 TradingClassDataTable;
        [NMS(Index = 37)]
        /* 0x16BA0 */ public NMSString0x80 TradingCostTable;
        [NMS(Index = 40)]
        /* 0x16C20 */ public NMSString0x80 UnlockableItemTrees;
        [NMS(Index = 35)]
        /* 0x16CA0 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        [NMS(Index = 33)]
        /* 0x16D20 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        [NMS(Index = 34)]
        /* 0x16DA0 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        [NMS(Index = 23, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x16E20 */ public TkCurveType[] WeightingCurves;
    }
}

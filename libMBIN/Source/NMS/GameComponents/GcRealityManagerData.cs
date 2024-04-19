using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC9B3C032431346, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x00000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x00090 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000F0 */ public Colour[] RarityColours;
        /* 0x00120 */ public GcRealityIconTable Icons;
        /* 0x06358 */ public GcTradeSettings TradeSettings;
        /* 0x07608 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x07808 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x079C8 */ public NMSString0x20A[] FactionNames;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x07B08 */ public GcRepShopData[] RepShops;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x07C48 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x07D78 */ public GcTechList[] PlanetTechShops;
        [NMS(Size = 0xB)]
        /* 0x07E78 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x07F28 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x07FC8 */ public TkIdArray[] DefaultVehicleLoadout;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x08038 */ public GcStats[] Stats;
        /* 0x08088 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0x080A0 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x080B8 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x080D0 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x080E8 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x08100 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x08118 */ public List<NMSString0x80> AlienPuzzleTables;
        /* 0x08128 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        /* 0x08138 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x08148 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0x08158 */ public List<GcIDPair> FreighterBaseItemPairs;
        /* 0x08168 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        /* 0x08178 */ public List<TkRawID> LegacyRepairTable;
        /* 0x08188 */ public List<NMSString0x10> NeverOfferedForSale;
        /* 0x08198 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x081A8 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0x081B8 */ public GcTechList StationTechShops;
        /* 0x081C8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x081D8 */ public List<int> SuitCargoUpgradePrices;
        /* 0x081E8 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x081F8 */ public List<int> SuitUpgradePrices;
        [NMS(Size = 0xBF, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x08208 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0xBF, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0E484 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x14700 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x14BA4 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x14EBC */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0x16, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x151D4 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x154EC */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x1571C */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x158F8 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0x5)]
        /* 0x15A60 */ public float[] NormalisedPriceLimits;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x15A74 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x15A84 */ public float[] WeightedTextWeights;
        /* 0x15A90 */ public ushort HomeRealityIteration;
        /* 0x15A92 */ public ushort RealityIteration;
        [NMS(Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x15A94 */ public NMSString0x80[] Catalogues;
        [NMS(Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x15D14 */ public bool[] LoopInteractionPuzzles;
        /* 0x15DA0 */ public NMSString0x80 AlienWordsTable;
        /* 0x15E20 */ public NMSString0x80 CombatEffectsTable;
        /* 0x15EA0 */ public NMSString0x80 ConsumableItemTable;
        /* 0x15F20 */ public NMSString0x80 CostTable;
        /* 0x15FA0 */ public NMSString0x80 DamageTable;
        /* 0x16020 */ public NMSString0x80 DialogClearanceTable;
        /* 0x160A0 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x16120 */ public NMSString0x80 HistoricalSeasonDataTable;
        /* 0x161A0 */ public NMSString0x80 InventoryTable;
        /* 0x16220 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x162A0 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x16320 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x163A0 */ public NMSString0x80 ProceduralProductTable;
        /* 0x16420 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x164A0 */ public NMSString0x80 ProductDescriptionOverrideTable;
        /* 0x16520 */ public NMSString0x80 ProductTable;
        /* 0x165A0 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x16620 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x166A0 */ public NMSString0x80 RecipeTable;
        /* 0x16720 */ public NMSString0x80 RewardTable;
        /* 0x167A0 */ public NMSString0x80 SettlementPerksTable;
        /* 0x16820 */ public NMSString0x80 StatRewardsTable;
        /* 0x168A0 */ public NMSString0x80 StoriesTable;
        /* 0x16920 */ public NMSString0x80 SubstanceTable;
        /* 0x169A0 */ public NMSString0x80 TechBoxTable;
        /* 0x16A20 */ public NMSString0x80 TechnologyTable;
        /* 0x16AA0 */ public NMSString0x80 TradingClassDataTable;
        /* 0x16B20 */ public NMSString0x80 TradingCostTable;
        /* 0x16BA0 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x16C20 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        /* 0x16CA0 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x16D20 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x16DA0 */ public TkCurveType[] WeightingCurves;
    }
}

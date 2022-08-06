using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5ABEC52FBDBD639, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x01E0 */ public float[] CreatureDiscoverySizeMultiplier;
        /* 0x01F0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Size = 0x10)]
        /* 0x0200 */ public GcSubstanceSecondary[] SecondarySubstanceByBiome;
        /* 0x0400 */ public NMSString0x80 TechnologyTable;
        /* 0x0480 */ public NMSString0x80 SubstanceTable;
        /* 0x0500 */ public NMSString0x80 ProductTable;
        /* 0x0580 */ public NMSString0x80 ProceduralProductTable;
        /* 0x0600 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x0680 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x0700 */ public List<TkRawID> LegacyRepairTable;
        /* 0x0710 */ public NMSString0x80 ConsumableItemTable;
        /* 0x0790 */ public NMSString0x80 RecipeTable;
        /* 0x0810 */ public NMSString0x80 StoriesTable;
        /* 0x0890 */ public NMSString0x80 DialogClearanceTable;
        /* 0x0910 */ public NMSString0x80 AlienWordsTable;
        /* 0x0990 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x09A0 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0A24 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0C30 */ public TkCurveType[] WeightingCurves;
        /* 0x0C50 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x0C60 */ public NMSString0x80 RewardTable;
        /* 0x0CE0 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x0D60 */ public NMSString0x80 InventoryTable;
        /* 0x0DE0 */ public NMSString0x80 DamageTable;
        /* 0x0E60 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x0EE0 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x0F60 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x0FE0 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x1060 */ public NMSString0x80 CostTable;
        /* 0x10E0 */ public NMSString0x80 TradingCostTable;
        /* 0x1160 */ public NMSString0x80 TradingClassDataTable;
        /* 0x11E0 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x1260 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x12E0 */ public NMSString0x80 SettlementPerksTable;
        /* 0x1360 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x13E0 */ public NMSString0x80 CombatEffectsTable;
        /* 0x1460 */ public NMSString0x80 TechBoxTable;
        /* 0x14E0 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x14F0 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x16B0 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x17E0 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x1850 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x18E0 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x1A00 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1B44 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1CD0 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1E5C */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1FE8 */ public float[] WeightedTextWeights;
        /* 0x1FF8 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x74D0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x7530 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x7560 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x75F0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xBC, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x7A94 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xDB88 */ public GcStats[] Stats;
        /* 0xDBD8 */ public List<NMSString0x10> AvailableTech;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xDBE8 */ public GcTechList[] PlanetTechShops;
        /* 0xDCE8 */ public GcTradeSettings TradeSettings;
        /* 0xEEC8 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0xEED8 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xEEF8 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xEF18 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xEF38 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xEF58 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xEF78 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0xEF98 */ public List<int> SuitUpgradePrices;
        /* 0xEFA8 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xEFB8 */ public List<int> SuitCargoUpgradePrices;
        /* 0xEFC8 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xEFD8 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]
        /* 0xEFE8 */ public float[] NormalisedPriceLimits;
        /* 0xF000 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0xF010 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Size = 0x3)]
        /* 0xF020 */ public NMSString0x80[] Catalogues;
    }
}

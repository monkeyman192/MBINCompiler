using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD6B0, GUID = 0x6C64322C18E67BAA, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x10, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01D4 */ public byte[] Padding1D4;
        /* 0x01D8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x01E8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        /* 0x03E8 */ public NMSString0x80 TechnologyTable;
        /* 0x0468 */ public NMSString0x80 SubstanceTable;
        /* 0x04E8 */ public NMSString0x80 ProductTable;
        /* 0x0568 */ public NMSString0x80 ProceduralProductTable;
        /* 0x05E8 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x0668 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x06E8 */ public List<TkRawID> LegacyRepairTable;
        /* 0x06F8 */ public NMSString0x80 ConsumableItemTable;
        /* 0x0778 */ public NMSString0x80 RecipeTable;
        /* 0x07F8 */ public NMSString0x80 AlienWordsTable;
        /* 0x0878 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x75, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0888 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x75, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0900 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0AD4 */ public TkCurveType[] WeightingCurves;
        /* 0x0AF0 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x0B00 */ public NMSString0x80 RewardTable;
        /* 0x0B80 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x0C00 */ public NMSString0x80 InventoryTable;
        /* 0x0C80 */ public NMSString0x80 DamageTable;
        /* 0x0D00 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x0D80 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x0E00 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x0E80 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x0F00 */ public NMSString0x80 CostTable;
        /* 0x0F80 */ public NMSString0x80 TradingCostTable;
        /* 0x01000 */ public NMSString0x80 TradingClassDataTable;
        /* 0x1080 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x1100 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x1180 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x1190 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xF, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1350 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1440 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x14B0 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1530 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1630 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1750 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x18D0 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1A60 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1BF4 */ public float[] WeightedTextWeights;
        /* 0x1C00 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6CC0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6D20 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6D50 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6DE0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xA3, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x7284 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xC690 */ public GcStats[] Stats;
        /* 0xC6E0 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xC6F0 */ public GcTechList[] PlanetTechShops;
        /* 0xC7F0 */ public GcTradeSettings TradeSettings;
        /* 0xD598 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xD5B8 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xD5D8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xD5F8 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xD618 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xD638 */ public List<int> SuitUpgradePrices;
        /* 0xD648 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xD658 */ public List<int> SuitCargoUpgradePrices;
        /* 0xD668 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xD678 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xD688 */ public float[] NormalizedPriceLimits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD69C */ public byte[] PaddingD69C;
        /* 0xD6A0 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}

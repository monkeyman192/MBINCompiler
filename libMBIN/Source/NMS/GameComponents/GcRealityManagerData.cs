using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD6A0, GUID = 0x6C64322C18E67BAA, NameHash = 0x5930542B7B565329)]
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
        [NMS(Size = 0x80)]
        /* 0x03E8 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0468 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x04E8 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x0568 */ public string ProceduralProductTable;
        [NMS(Size = 0x80)]
        /* 0x05E8 */ public string ProceduralTechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0668 */ public string LegacyItemConversionTable;
        /* 0x06E8 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Size = 0x80)]
        /* 0x06F8 */ public string ConsumableItemTable;
        [NMS(Size = 0x80)]
        /* 0x0778 */ public string RecipeTable;
        [NMS(Size = 0x80)]
        /* 0x07F8 */ public string AlienWordsTable;
        /* 0x0878 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x73, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0888 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x73, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x08FC */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0AC8 */ public TkCurveType[] WeightingCurves;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0ADC */ public byte[] PaddingADC;
        /* 0x0AE8 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Size = 0x80)]
        /* 0x0AF8 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0B78 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x0BF8 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0C78 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0CF8 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0D78 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0DF8 */ public string UnlockableSeasonRewardsTable;
        [NMS(Size = 0x80)]
        /* 0x0E78 */ public string UnlockableTwitchRewardsTable;
        [NMS(Size = 0x80)]
        /* 0x0EF8 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0F78 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0FF8 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x1078 */ public string MaintenanceGroupsTable;
        [NMS(Size = 0x80)]
        /* 0x10F8 */ public string UnlockableItemTrees;
        /* 0x1178 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x1188 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xF, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1348 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1438 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x14A8 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1528 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1628 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1748 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x18C8 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1A58 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1BEC */ public float[] WeightedTextWeights;
        /* 0x1BF8 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6CB0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x6D10 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6D40 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6DD0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xA3, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x7274 */ public TkTextureResource[] StatCategoryIcons;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xC680 */ public GcStats[] Stats;
        /* 0xC6D0 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0xC6E0 */ public GcTechList[] PlanetTechShops;
        /* 0xC7E0 */ public GcTradeSettings TradeSettings;
        /* 0xD588 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xD5A8 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xD5C8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xD5E8 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xD608 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xD628 */ public List<int> SuitUpgradePrices;
        /* 0xD638 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xD648 */ public List<int> SuitCargoUpgradePrices;
        /* 0xD658 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xD668 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xD678 */ public float[] NormalizedPriceLimits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD68C */ public byte[] PaddingD68C;
        /* 0xD690 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}

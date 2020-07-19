using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xCB70, GUID = 0x8BE45799D8B55662, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;
        [NMS(Size = 0x10)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4)]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01D4 */ public byte[] Padding1D4;
        /* 0x01D8 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x01E8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Size = 0x80)]
        /* 0x0388 */ public string TechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0408 */ public string SubstanceTable;
        [NMS(Size = 0x80)]
        /* 0x0488 */ public string ProductTable;
        [NMS(Size = 0x80)]
        /* 0x0508 */ public string ProceduralProductTable;
        [NMS(Size = 0x80)]
        /* 0x0588 */ public string ProceduralTechnologyTable;
        [NMS(Size = 0x80)]
        /* 0x0608 */ public string LegacyItemConversionTable;
        /* 0x0688 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Size = 0x80)]
        /* 0x0698 */ public string ConsumableItemTable;
        [NMS(Size = 0x80)]
        /* 0x0718 */ public string RecipeTable;
        [NMS(Size = 0x80)]
        /* 0x0798 */ public string AlienWordsTable;
        /* 0x0818 */ public List<NMSString0x80> AlienPuzzlesTables;
        [NMS(Size = 0x6C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0828 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x6C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0894 */ public int[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0A44 */ public TkCurveType[] WeightingCurves;
        /* 0x0A60 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Size = 0x80)]
        /* 0x0A70 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0AF0 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x0B70 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0BF0 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0C70 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0CF0 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0D70 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0DF0 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0E70 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0EF0 */ public string MaintenanceGroupsTable;
        [NMS(Size = 0x80)]
        /* 0x0F70 */ public string UnlockableItemTrees;
        /* 0x0FF0 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x01000 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0xD, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x11C0 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1290 */ public TkIDArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1300 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1380 */ public NMSString0x20[] FactionNames;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1480 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x15A0 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x172C */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x18B8 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x1A44 */ public float[] WeightedTextWeights;
        /* 0x1A50 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6560 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x65C0 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x65F0 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6680 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xA1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x6B24 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xB87C */ public byte[] PaddingB87C;
        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xBE28 */ public GcStats[] Stats;
        /* 0xBE78 */ public GcTechList StationTechShops;
        [NMS(Size = 0xD)]
        /* 0xBE88 */ public GcTechList[] PlanetTechShops;
        /* 0xBF58 */ public GcTradeSettings TradeSettings;
        /* 0xCA58 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xCA78 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xCA98 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xCAB8 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xCAD8 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xCAF8 */ public List<int> SuitUpgradePrices;
        /* 0xCB08 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xCB18 */ public List<int> SuitCargoUpgradePrices;
        /* 0xCB28 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xCB38 */ public List<NMSString0x10> NeverOfferedForSale;
        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xCB48 */ public float[] NormalizedPriceLimits;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xCB5C */ public byte[] PaddingCB5C;
        /* 0xCB60 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
    }
}

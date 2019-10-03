using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xBAB0, GUID = 0x8EB2E3488302F51C, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x0000 */ public ushort HomeRealityIteration;
        /* 0x0002 */ public ushort RealityIteration;

        [NMS(Size = 0x10)]
        /* 0x0004 */ public GcDiscoveryWorth[] DiscoveryWorth;

        [NMS(Size = 0x4)]
        /* 0x01C4 */ public float[] CreatureDiscoverySizeMultiplier;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1D4 */ public byte[] Padding1D4;

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

        [NMS(Size = 0x63, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0828 */ public bool[] LoopInteractionPuzzles;

        [NMS(Size = 0x63, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x088C */ public int[] InteractionPuzzlesIndexTypes;

        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x0A18 */ public TkCurveType[] WeightingCurves;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0A34 */ public byte[] Padding834;

        /* 0x0A38 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;

        [NMS(Size = 0x80)]
        /* 0x0A48 */ public string RewardTable;
        [NMS(Size = 0x80)]
        /* 0x0AC8 */ public string DiscoveryRewardTable;
        [NMS(Size = 0x80)]
        /* 0x0B48 */ public string InventoryTable;
        [NMS(Size = 0x80)]
        /* 0x0BC8 */ public string DamageTable;
        [NMS(Size = 0x80)]
        /* 0x0C48 */ public string PurchaseableBuildingBlueprintsTable;
        [NMS(Size = 0x80)]
        /* 0x0CC8 */ public string PurchaseableSpecialsTable;
        [NMS(Size = 0x80)]
        /* 0x0D48 */ public string CostTable;
        [NMS(Size = 0x80)]
        /* 0x0DC8 */ public string TradingCostTable;
        [NMS(Size = 0x80)]
        /* 0x0E48 */ public string TradingClassDataTable;
        [NMS(Size = 0x80)]
        /* 0x0EC8 */ public string MaintenanceGroupsTable;
        [NMS(Size = 0x80)]
        /* 0x0F48 */ public string UnlockableItemTrees;

        /* 0x0FC8 */ public List<GcFreighterCargoOption> FreighterCargoOptions;

        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x0FD8 */ public GcShipWeaponData[] ShipWeapons;

        [NMS(Size = 0xA, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x1198 */ public GcPlayerWeaponData[] PlayerWeapons;

        [NMS(Size = 0x6, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x1238 */ public TkIDArray[] DefaultVehicleLoadout;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1298 */ public NMSString0x10[] FactionStandingIDs;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1318 */ public NMSString0x20[] FactionNames;

        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1418 */ public GcNumberedTextList[] FactionClients;

        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1538 */ public GcNumberedTextList[] MissionNameFormats;

        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x16C4 */ public GcNumberedTextList[] MissionNameAdjectives;

        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x1850 */ public GcNumberedTextList[] MissionNameNouns;

        [NMS(Size = 0x3)]
        /* 0x19DC */ public float[] WeightedTextWeights;

        /* 0x19E8 */ public GcRealityIconTable Icons;

        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6150 */ public Colour[] HazardColours;

        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x61B0 */ public Colour[] RarityColours;

        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x61E0 */ public Colour[] SubstanceCategoryColours;

        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6270 */ public TkTextureResource[] SubstanceChargeIcons;

        [NMS(Size = 0x8B, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x6714 */ public TkTextureResource[] StatCategoryIcons;

        public enum PossessionEnum { Suit, Weapon, Ship, Freighter, Vehicle }
        [NMS(Size = 0x5, EnumType = typeof(PossessionEnum))]
        /* 0xAEC0 */ public GcStats[] Stats;

        /* 0xAF10 */ public GcTechList StationTechShops;

        [NMS(Size = 0xD)]
        /* 0xAF20 */ public GcTechList[] PlanetTechShops;

        /* 0xAFF0 */ public GcTradeSettings TradeSettings;
        /* 0xB990 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0xB9B0 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0xB9D0 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0xB9F0 */ public GcInventoryLayout ShipStartingLayout;
        /* 0xBA10 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0xBA30 */ public List<int> SuitUpgradePrices;
        /* 0xBA40 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0xBA50 */ public List<int> SuitCargoUpgradePrices;
        /* 0xBA60 */ public List<NMSString0x10> NeverSellableItems;
        /* 0xBA70 */ public List<NMSString0x10> NeverOfferedForSale;

        public enum GoodsTypeEnum { Commodity, Technology, Fuel, Tradeable, Special }
        [NMS(Size = 0x5, EnumType = typeof(GoodsTypeEnum))]         // TODO: not sure about these values....
        /* 0xBA80 */ public float[] NormalizedPriceLimits;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0xBA94 */ public byte[] PaddingBA94;

        /* 0xBA98 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0xBAA8 */ public byte[] EndPadding;
    }
}

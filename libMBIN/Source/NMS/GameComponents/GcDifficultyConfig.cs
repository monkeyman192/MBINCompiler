using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA52D1B4877D79199, NameHash = 0x27739546)]
    public class GcDifficultyConfig : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x1E, EnumType = typeof(GcDifficultySettingEnum.DifficultySettingEnum))]
        /* 0x0000 */ public GcDifficultySettingCommonData[] CommonSettingsData;
        [NMS(Index = 11)]
        /* 0x10E0 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownDisabledData;
        [NMS(Index = 12)]
        /* 0x1400 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownEnabledData;
        [NMS(Index = 1, Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x1720 */ public NMSString0x20A[] PresetOptionLocIds;
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x1800 */ public GcDifficultyOptionUIGroup[] UILayout;
        [NMS(Index = 20, Size = 0x4, EnumType = typeof(GcActiveSurvivalBarsDifficultyOption.ActiveSurvivalBarsDifficultyEnum))]
        /* 0x18C0 */ public NMSString0x20A[] ActiveSurvivalBarsOptionLocIds;
        [NMS(Index = 30, Size = 0x4, EnumType = typeof(GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum))]
        /* 0x1940 */ public NMSString0x20A[] ChargingRequirementsOptionLocIds;
        [NMS(Index = 37, Size = 0x4, EnumType = typeof(GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum))]
        /* 0x19C0 */ public NMSString0x20A[] CurrencyCostOptionLocIds;
        [NMS(Index = 15, Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x1A40 */ public NMSString0x20A[] DamageReceivedOptionLocIds;
        [NMS(Index = 14, Size = 0x4, EnumType = typeof(GcDeathConsequencesDifficultyOption.DeathConsequencesDifficultyEnum))]
        /* 0x1AC0 */ public NMSString0x20A[] DeathConsequencesOptionLocIds;
        [NMS(Index = 55, Size = 0x4, EnumType = typeof(GcFishingDifficultyOption.FishingDifficultyEnum))]
        /* 0x1B40 */ public NMSString0x20A[] FishingOptionLocIds;
        [NMS(Index = 32, Size = 0x4, EnumType = typeof(GcFuelUseDifficultyOption.FuelUseDifficultyEnum))]
        /* 0x1BC0 */ public NMSString0x20A[] FuelUseOptionLocIds;
        [NMS(Index = 48, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x1C40 */ public NMSString0x20A[] GroundCombatOptionLocIds;
        [NMS(Index = 34, Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x1CC0 */ public NMSString0x20A[] LaunchFuelCostOptionLocIds;
        [NMS(Index = 43, Size = 0x4, EnumType = typeof(GcReputationGainDifficultyOption.ReputationGainDifficultyEnum))]
        /* 0x1D40 */ public NMSString0x20A[] ReputationGainOptionLocIds;
        [NMS(Index = 41, Size = 0x4, EnumType = typeof(GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum))]
        /* 0x1DC0 */ public NMSString0x20A[] ScannerRechargeOptionLocIds;
        [NMS(Index = 45, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x1E40 */ public NMSString0x20A[] SpaceCombatOptionLocIds;
        [NMS(Index = 53, Size = 0x3, EnumType = typeof(GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum))]
        /* 0x1EC0 */ public NMSString0x20A[] BreakTechOnDamageOptionLocIds;
        [NMS(Index = 13, Size = 0x3, EnumType = typeof(GcCreatureHostilityDifficultyOption.CreatureHostilityDifficultyEnum))]
        /* 0x1F20 */ public NMSString0x20A[] CreatureHostilityOptionLocIds;
        [NMS(Index = 18, Size = 0x3, EnumType = typeof(GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum))]
        /* 0x1F80 */ public NMSString0x20A[] DamageGivenOptionLocIds;
        [NMS(Index = 23, Size = 0x3, EnumType = typeof(GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum))]
        /* 0x1FE0 */ public NMSString0x20A[] EnergyDrainOptionLocIds;
        [NMS(Index = 33, Size = 0x4, EnumType = typeof(GcFuelUseDifficultyOption.FuelUseDifficultyEnum))]
        /* 0x2040 */ public GcDifficultyFuelUseOptionData[] FuelUseOptionData;
        [NMS(Index = 21, Size = 0x3, EnumType = typeof(GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum))]
        /* 0x20A0 */ public NMSString0x20A[] HazardDrainOptionLocIds;
        [NMS(Index = 28, Size = 0x3, EnumType = typeof(GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum))]
        /* 0x2100 */ public NMSString0x20A[] InventoryStackLimitsOptionLocIds;
        [NMS(Index = 39, Size = 0x3, EnumType = typeof(GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum))]
        /* 0x2160 */ public NMSString0x20A[] ItemShopAvailabilityOptionLocIds;
        [NMS(Index = 51, Size = 0x3, EnumType = typeof(GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum))]
        /* 0x21C0 */ public NMSString0x20A[] SprintingOptionLocIds;
        [NMS(Index = 25, Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x2220 */ public NMSString0x20A[] SubstanceCollectionOptionLocIds;
        [NMS(Index = 57, Size = 0x2, EnumType = typeof(GcNPCPopulationDifficultyOption.NPCPopulationDifficultyEnum))]
        /* 0x2280 */ public NMSString0x20A[] NPCPopulationOptionLocIds;
        [NMS(Index = 40, Size = 0x3, EnumType = typeof(GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum))]
        /* 0x22C0 */ public GcItemShopAvailabilityDifficultyOptionData[] ItemShopAvailabilityOptionData;
        [NMS(Index = 0)]
        /* 0x22F0 */ public NMSString0x20A PresetLocId;
        [NMS(Index = 2, Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x2310 */ public GcDifficultySettingsData[] Presets;
        [NMS(Index = 29, Size = 0x3, EnumType = typeof(GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum))]
        /* 0x25B0 */ public GcDifficultyInventoryStackSizeOptionData[] InventoryStackLimitsOptionData;
        [NMS(Index = 38, Size = 0x4, EnumType = typeof(GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum))]
        /* 0x2700 */ public GcDifficultyCurrencyCostOptionData[] CurrencyCostOptionData;
        [NMS(Index = 3)]
        /* 0x2760 */ public GcDifficultySettingsData PermadeathMinSettings;
        [NMS(Index = 31, Size = 0x4, EnumType = typeof(GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum))]
        /* 0x27C0 */ public float[] ChargingRequirementsMultipliers;
        [NMS(Index = 17, Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x27D0 */ public int[] DamageReceivedAIMechTechDamageHits;
        [NMS(Index = 16, Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x27E0 */ public float[] DamageReceivedMultipliers;
        [NMS(Index = 56, Size = 0x4, EnumType = typeof(GcFishingDifficultyOption.FishingDifficultyEnum))]
        /* 0x27F0 */ public float[] FishingCatchWindowMultipliers;
        [NMS(Index = 49, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2800 */ public float[] GroundCombatMultipliers;
        [NMS(Index = 35, Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x2810 */ public float[] LaunchFuelCostMultipliers;
        [NMS(Index = 44, Size = 0x4, EnumType = typeof(GcReputationGainDifficultyOption.ReputationGainDifficultyEnum))]
        /* 0x2820 */ public float[] ReputationGainMultipliers;
        [NMS(Index = 42, Size = 0x4, EnumType = typeof(GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum))]
        /* 0x2830 */ public float[] ScannerRechargeMultipliers;
        [NMS(Index = 50, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2840 */ public float[] SentinelTimeOutMultipliers;
        [NMS(Index = 36, Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x2850 */ public float[] ShipSummoningFuelCostMultipliers;
        [NMS(Index = 47, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2860 */ public float[] SpaceCombatDifficultyMultipliers;
        [NMS(Index = 46, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2870 */ public float[] SpaceCombatMultipliers;
        [NMS(Index = 54, Size = 0x3, EnumType = typeof(GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum))]
        /* 0x2880 */ public float[] BreakTechOnDamageMultipliers;
        [NMS(Index = 19, Size = 0x3, EnumType = typeof(GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum))]
        /* 0x288C */ public float[] DamageGivenMultipliers;
        [NMS(Index = 24, Size = 0x3, EnumType = typeof(GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum))]
        /* 0x2898 */ public float[] EnergyDrainMultipliers;
        [NMS(Index = 22, Size = 0x3, EnumType = typeof(GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum))]
        /* 0x28A4 */ public float[] HazardDrainMultipliers;
        [NMS(Index = 52, Size = 0x3, EnumType = typeof(GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum))]
        /* 0x28B0 */ public float[] SprintingCostMultipliers;
        [NMS(Index = 27, Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x28BC */ public int[] SubstanceCollectionLaserAmount;
        [NMS(Index = 26, Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x28C8 */ public float[] SubstanceCollectionMultipliers;
        [NMS(Index = 9)]
        /* 0x28D4 */ public int AllSlotsUnlockedStartingShipSlots;
        [NMS(Index = 10)]
        /* 0x28D8 */ public int AllSlotsUnlockedStartingShipTechSlots;
        [NMS(Index = 6)]
        /* 0x28DC */ public int AllSlotsUnlockedStartingSuitSlots;
        [NMS(Index = 7)]
        /* 0x28E0 */ public int AllSlotsUnlockedStartingSuitTechSlots;
        [NMS(Index = 8)]
        /* 0x28E4 */ public int AllSlotsUnlockedStartingWeaponSlots;
    }
}

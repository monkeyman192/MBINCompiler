using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE68D87E1532DEDB8, NameHash = 0xA688E4255C8FED76)]
    public class GcDifficultyConfig : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x1C, EnumType = typeof(GcDifficultySettingEnum.DifficultySettingEnum))]
        /* 0x0000 */ public GcDifficultySettingCommonData[] CommonSettingsData;
        [NMS(Index = 11)]
        /* 0x0FC0 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownDisabledData;
        [NMS(Index = 12)]
        /* 0x12D0 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownEnabledData;
        [NMS(Index = 1, Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x15E0 */ public NMSString0x20A[] PresetOptionLocIds;
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x16C0 */ public GcDifficultyOptionUIGroup[] UILayout;
        [NMS(Index = 20, Size = 0x4, EnumType = typeof(GcActiveSurvivalBarsDifficultyOption.ActiveSurvivalBarsDifficultyEnum))]
        /* 0x1780 */ public NMSString0x20A[] ActiveSurvivalBarsOptionLocIds;
        [NMS(Index = 30, Size = 0x4, EnumType = typeof(GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum))]
        /* 0x1800 */ public NMSString0x20A[] ChargingRequirementsOptionLocIds;
        [NMS(Index = 37, Size = 0x4, EnumType = typeof(GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum))]
        /* 0x1880 */ public NMSString0x20A[] CurrencyCostOptionLocIds;
        [NMS(Index = 15, Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x1900 */ public NMSString0x20A[] DamageReceivedOptionLocIds;
        [NMS(Index = 14, Size = 0x4, EnumType = typeof(GcDeathConsequencesDifficultyOption.DeathConsequencesDifficultyEnum))]
        /* 0x1980 */ public NMSString0x20A[] DeathConsequencesOptionLocIds;
        [NMS(Index = 32, Size = 0x4, EnumType = typeof(GcFuelUseDifficultyOption.FuelUseDifficultyEnum))]
        /* 0x1A00 */ public NMSString0x20A[] FuelUseOptionLocIds;
        [NMS(Index = 48, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x1A80 */ public NMSString0x20A[] GroundCombatOptionLocIds;
        [NMS(Index = 34, Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x1B00 */ public NMSString0x20A[] LaunchFuelCostOptionLocIds;
        [NMS(Index = 43, Size = 0x4, EnumType = typeof(GcReputationGainDifficultyOption.ReputationGainDifficultyEnum))]
        /* 0x1B80 */ public NMSString0x20A[] ReputationGainOptionLocIds;
        [NMS(Index = 41, Size = 0x4, EnumType = typeof(GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum))]
        /* 0x1C00 */ public NMSString0x20A[] ScannerRechargeOptionLocIds;
        [NMS(Index = 45, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x1C80 */ public NMSString0x20A[] SpaceCombatOptionLocIds;
        [NMS(Index = 53, Size = 0x3, EnumType = typeof(GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum))]
        /* 0x1D00 */ public NMSString0x20A[] BreakTechOnDamageOptionLocIds;
        [NMS(Index = 13, Size = 0x3, EnumType = typeof(GcCreatureHostilityDifficultyOption.CreatureHostilityDifficultyEnum))]
        /* 0x1D60 */ public NMSString0x20A[] CreatureHostilityOptionLocIds;
        [NMS(Index = 18, Size = 0x3, EnumType = typeof(GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum))]
        /* 0x1DC0 */ public NMSString0x20A[] DamageGivenOptionLocIds;
        [NMS(Index = 23, Size = 0x3, EnumType = typeof(GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum))]
        /* 0x1E20 */ public NMSString0x20A[] EnergyDrainOptionLocIds;
        [NMS(Index = 33, Size = 0x4, EnumType = typeof(GcFuelUseDifficultyOption.FuelUseDifficultyEnum))]
        /* 0x1E80 */ public GcDifficultyFuelUseOptionData[] FuelUseOptionData;
        [NMS(Index = 21, Size = 0x3, EnumType = typeof(GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum))]
        /* 0x1EE0 */ public NMSString0x20A[] HazardDrainOptionLocIds;
        [NMS(Index = 28, Size = 0x3, EnumType = typeof(GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum))]
        /* 0x1F40 */ public NMSString0x20A[] InventoryStackLimitsOptionLocIds;
        [NMS(Index = 39, Size = 0x3, EnumType = typeof(GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum))]
        /* 0x1FA0 */ public NMSString0x20A[] ItemShopAvailabilityOptionLocIds;
        [NMS(Index = 51, Size = 0x3, EnumType = typeof(GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum))]
        /* 0x2000 */ public NMSString0x20A[] SprintingOptionLocIds;
        [NMS(Index = 25, Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x2060 */ public NMSString0x20A[] SubstanceCollectionOptionLocIds;
        [NMS(Index = 40, Size = 0x3, EnumType = typeof(GcItemShopAvailabilityDifficultyOption.ItemShopAvailabilityDifficultyEnum))]
        /* 0x20C0 */ public GcItemShopAvailabilityDifficultyOptionData[] ItemShopAvailabilityOptionData;
        [NMS(Index = 0)]
        /* 0x20F0 */ public NMSString0x20A PresetLocId;
        [NMS(Index = 2, Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x2110 */ public GcDifficultySettingsData[] Presets;
        [NMS(Index = 29, Size = 0x3, EnumType = typeof(GcInventoryStackLimitsDifficultyOption.InventoryStackLimitsDifficultyEnum))]
        /* 0x2378 */ public GcDifficultyInventoryStackSizeOptionData[] InventoryStackLimitsOptionData;
        [NMS(Index = 38, Size = 0x4, EnumType = typeof(GcCurrencyCostDifficultyOption.CurrencyCostDifficultyEnum))]
        /* 0x24C8 */ public GcDifficultyCurrencyCostOptionData[] CurrencyCostOptionData;
        [NMS(Index = 3)]
        /* 0x2528 */ public GcDifficultySettingsData PermadeathMinSettings;
        [NMS(Index = 31, Size = 0x4, EnumType = typeof(GcChargingRequirementsDifficultyOption.ChargingRequirementsDifficultyEnum))]
        /* 0x2580 */ public float[] ChargingRequirementsMultipliers;
        [NMS(Index = 17, Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x2590 */ public int[] DamageReceivedAIMechTechDamageHits;
        [NMS(Index = 16, Size = 0x4, EnumType = typeof(GcDamageReceivedDifficultyOption.DamageReceivedDifficultyEnum))]
        /* 0x25A0 */ public float[] DamageReceivedMultipliers;
        [NMS(Index = 49, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x25B0 */ public float[] GroundCombatMultipliers;
        [NMS(Index = 35, Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x25C0 */ public float[] LaunchFuelCostMultipliers;
        [NMS(Index = 44, Size = 0x4, EnumType = typeof(GcReputationGainDifficultyOption.ReputationGainDifficultyEnum))]
        /* 0x25D0 */ public float[] ReputationGainMultipliers;
        [NMS(Index = 42, Size = 0x4, EnumType = typeof(GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum))]
        /* 0x25E0 */ public float[] ScannerRechargeMultipliers;
        [NMS(Index = 50, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x25F0 */ public float[] SentinelTimeOutMultipliers;
        [NMS(Index = 36, Size = 0x4, EnumType = typeof(GcLaunchFuelCostDifficultyOption.LaunchFuelCostDifficultyEnum))]
        /* 0x2600 */ public float[] ShipSummoningFuelCostMultipliers;
        [NMS(Index = 47, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2610 */ public float[] SpaceCombatDifficultyMultipliers;
        [NMS(Index = 46, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x2620 */ public float[] SpaceCombatMultipliers;
        [NMS(Index = 54, Size = 0x3, EnumType = typeof(GcBreakTechOnDamageDifficultyOption.BreakTechOnDamageProbabilityEnum))]
        /* 0x2630 */ public float[] BreakTechOnDamageMultipliers;
        [NMS(Index = 19, Size = 0x3, EnumType = typeof(GcDamageGivenDifficultyOption.DamageGivenDifficultyEnum))]
        /* 0x263C */ public float[] DamageGivenMultipliers;
        [NMS(Index = 24, Size = 0x3, EnumType = typeof(GcEnergyDrainDifficultyOption.EnergyDrainDifficultyEnum))]
        /* 0x2648 */ public float[] EnergyDrainMultipliers;
        [NMS(Index = 22, Size = 0x3, EnumType = typeof(GcHazardDrainDifficultyOption.HazardDrainDifficultyEnum))]
        /* 0x2654 */ public float[] HazardDrainMultipliers;
        [NMS(Index = 52, Size = 0x3, EnumType = typeof(GcSprintingCostDifficultyOption.SprintingCostDifficultyEnum))]
        /* 0x2660 */ public float[] SprintingCostMultipliers;
        [NMS(Index = 27, Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x266C */ public int[] SubstanceCollectionLaserAmount;
        [NMS(Index = 26, Size = 0x3, EnumType = typeof(GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum))]
        /* 0x2678 */ public float[] SubstanceCollectionMultipliers;
        [NMS(Index = 9)]
        /* 0x2684 */ public int AllSlotsUnlockedStartingShipSlots;
        [NMS(Index = 10)]
        /* 0x2688 */ public int AllSlotsUnlockedStartingShipTechSlots;
        [NMS(Index = 6)]
        /* 0x268C */ public int AllSlotsUnlockedStartingSuitSlots;
        [NMS(Index = 7)]
        /* 0x2690 */ public int AllSlotsUnlockedStartingSuitTechSlots;
        [NMS(Index = 8)]
        /* 0x2694 */ public int AllSlotsUnlockedStartingWeaponSlots;
    }
}

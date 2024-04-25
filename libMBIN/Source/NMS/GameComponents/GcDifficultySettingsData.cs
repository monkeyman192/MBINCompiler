using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26F84C6D1073784E, NameHash = 0x640D4FDC2A95A771)]
    public class GcDifficultySettingsData : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public GcActiveSurvivalBarsDifficultyOption ActiveSurvivalBars;
        [NMS(Index = 27)]
        /* 0x04 */ public GcBreakTechOnDamageDifficultyOption BreakTechOnDamage;
        [NMS(Index = 16)]
        /* 0x08 */ public GcChargingRequirementsDifficultyOption ChargingRequirements;
        [NMS(Index = 23)]
        /* 0x0C */ public GcCreatureHostilityDifficultyOption CreatureHostility;
        [NMS(Index = 19)]
        /* 0x10 */ public GcCurrencyCostDifficultyOption CurrencyCost;
        [NMS(Index = 10)]
        /* 0x14 */ public GcDamageGivenDifficultyOption DamageGiven;
        [NMS(Index = 9)]
        /* 0x18 */ public GcDamageReceivedDifficultyOption DamageReceived;
        [NMS(Index = 8)]
        /* 0x1C */ public GcDeathConsequencesDifficultyOption DeathConsequences;
        [NMS(Index = 13)]
        /* 0x20 */ public GcEnergyDrainDifficultyOption EnergyDrain;
        [NMS(Index = 17)]
        /* 0x24 */ public GcFuelUseDifficultyOption FuelUse;
        [NMS(Index = 25)]
        /* 0x28 */ public GcCombatTimerDifficultyOption GroundCombatTimers;
        [NMS(Index = 12)]
        /* 0x2C */ public GcHazardDrainDifficultyOption HazardDrain;
        [NMS(Index = 15)]
        /* 0x30 */ public GcInventoryStackLimitsDifficultyOption InventoryStackLimits;
        [NMS(Index = 20)]
        /* 0x34 */ public GcItemShopAvailabilityDifficultyOption ItemShopAvailability;
        [NMS(Index = 18)]
        /* 0x38 */ public GcLaunchFuelCostDifficultyOption LaunchFuelCost;
        [NMS(Index = 22)]
        /* 0x3C */ public GcReputationGainDifficultyOption ReputationGain;
        [NMS(Index = 21)]
        /* 0x40 */ public GcScannerRechargeDifficultyOption ScannerRecharge;
        [NMS(Index = 24)]
        /* 0x44 */ public GcCombatTimerDifficultyOption SpaceCombatTimers;
        [NMS(Index = 26)]
        /* 0x48 */ public GcSprintingCostDifficultyOption SprintingCost;
        [NMS(Index = 14)]
        /* 0x4C */ public GcSubstanceCollectionDifficultyOption SubstanceCollection;
        [NMS(Index = 2)]
        /* 0x50 */ public bool AllSlotsUnlocked;
        [NMS(Index = 7)]
        /* 0x51 */ public bool BaseAutoPower;
        [NMS(Index = 4)]
        /* 0x52 */ public bool CraftingIsFree;
        [NMS(Index = 1)]
        /* 0x53 */ public bool InventoriesAlwaysInRange;
        [NMS(Index = 0)]
        /* 0x54 */ public bool SettingsLocked;
        [NMS(Index = 6)]
        /* 0x55 */ public bool StartWithAllItemsKnown;
        [NMS(Index = 5)]
        /* 0x56 */ public bool TutorialEnabled;
        [NMS(Index = 3)]
        /* 0x57 */ public bool WarpDriveRequirements;
    }
}

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26F84C6D1073784E, NameHash = 0x640D4FDC2A95A771)]
    public class GcDifficultySettingsData : NMSTemplate
    {
        /* 0x00 */ public GcActiveSurvivalBarsDifficultyOption ActiveSurvivalBars;
        /* 0x04 */ public GcBreakTechOnDamageDifficultyOption BreakTechOnDamage;
        /* 0x08 */ public GcChargingRequirementsDifficultyOption ChargingRequirements;
        /* 0x0C */ public GcCreatureHostilityDifficultyOption CreatureHostility;
        /* 0x10 */ public GcCurrencyCostDifficultyOption CurrencyCost;
        /* 0x14 */ public GcDamageGivenDifficultyOption DamageGiven;
        /* 0x18 */ public GcDamageReceivedDifficultyOption DamageReceived;
        /* 0x1C */ public GcDeathConsequencesDifficultyOption DeathConsequences;
        /* 0x20 */ public GcEnergyDrainDifficultyOption EnergyDrain;
        /* 0x24 */ public GcFuelUseDifficultyOption FuelUse;
        /* 0x28 */ public GcCombatTimerDifficultyOption GroundCombatTimers;
        /* 0x2C */ public GcHazardDrainDifficultyOption HazardDrain;
        /* 0x30 */ public GcInventoryStackLimitsDifficultyOption InventoryStackLimits;
        /* 0x34 */ public GcItemShopAvailabilityDifficultyOption ItemShopAvailability;
        /* 0x38 */ public GcLaunchFuelCostDifficultyOption LaunchFuelCost;
        /* 0x3C */ public GcReputationGainDifficultyOption ReputationGain;
        /* 0x40 */ public GcScannerRechargeDifficultyOption ScannerRecharge;
        /* 0x44 */ public GcCombatTimerDifficultyOption SpaceCombatTimers;
        /* 0x48 */ public GcSprintingCostDifficultyOption SprintingCost;
        /* 0x4C */ public GcSubstanceCollectionDifficultyOption SubstanceCollection;
        /* 0x50 */ public bool AllSlotsUnlocked;
        /* 0x51 */ public bool BaseAutoPower;
        /* 0x52 */ public bool CraftingIsFree;
        /* 0x53 */ public bool InventoriesAlwaysInRange;
        /* 0x54 */ public bool SettingsLocked;
        /* 0x55 */ public bool StartWithAllItemsKnown;
        /* 0x56 */ public bool TutorialEnabled;
        /* 0x57 */ public bool WarpDriveRequirements;
    }
}

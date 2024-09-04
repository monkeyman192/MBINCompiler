namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEAF6DF9323256F17, NameHash = 0x815A3E0A)]
    public class GcDifficultySettingEnum : NMSTemplate
    {
        // size: 0x1D
        public enum DifficultySettingEnum : uint {
            SettingsLocked,
            InventoriesAlwaysInRange,
            AllSlotsUnlocked,
            WarpDriveRequirements,
            CraftingIsFree,
            TutorialEnabled,
            StartWithAllItemsKnown,
            BaseAutoPower,
            DeathConsequences,
            DamageReceived,
            DamageGiven,
            ActiveSurvivalBars,
            HazardDrain,
            EnergyDrain,
            SubstanceCollection,
            InventoryStackLimits,
            ChargingRequirements,
            FuelUse,
            LaunchFuelCost,
            CurrencyCost,
            ScannerRecharge,
            ReputationGain,
            CreatureHostility,
            SpaceCombat,
            GroundCombat,
            ItemShopAvailablity,
            SprintingCost,
            BreakTechOnDamage,
            Fishing,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DifficultySettingEnum DifficultySetting;
    }
}

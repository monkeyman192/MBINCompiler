namespace libMBIN.Models.Structs
{
    public class GcFleetGlobals : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x0 */ public string CivilianMPMissionGiverPuzzle;
        /* 0x20 */ public float MaxPurchaseDistance;
        /* 0x24 */ public float DistanceForPurchaseReset;
        /* 0x28 */ public float CombatFrigateSpawnMinRange;
        /* 0x2C */ public float CombatFrigateSpawnAngle;
        /* 0x30 */ public float CombatNotificationTime;
        /* 0x34 */ public float CombatDefenderSpawnDelay;
        /* 0x38 */ public float PostCombatSpawnDelay;
        /* 0x3C */ public float CombatSpawnDelay;
        [NMS(Size = 0x4, EnumValue = new string[] { "C", "B", "A", "S" })]
        /* 0x40 */ public float[] CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x50 */ public int ExplorationPointsRequiredForScan;
        /* 0x54 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x68 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6C */ public byte[] Padding6C;
        [NMS(Size = 0x20)]
        /* 0x70 */ public string FleetCommunicationOSDMessage;
        /* 0x90 */ public int MinFrigateStatValue;
        /* 0x94 */ public int MaxFrigateStatValue;
        /* 0x98 */ public float MinFrigateDistanceFromFreighter;
        /* 0x9C */ public float MaxFrigateDistanceFromFreighter;
        /* 0xA0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0xA4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0xA8 */ public int MaximumSpeedDecrease;
        /* 0xAC */ public int MaximumSpeedIncrease;
        /* 0xB0 */ public float CameraPauseAfterStartingExpedition;
        /* 0xB4 */ public float UITraitLinesAngle;
        [NMS(Size = 0x5, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomacy", "Support" })]
        /* 0xB8 */ public GcFrigateUITraitLines[] UITraitLineLengths;
        [NMS(Size = 0x7)]
        /* 0x11C */ public NMSString0x20[] RacialTermForCaptain;
        /* 0x1FC */ public float TimeBeforeShowingHangar;
        /* 0x200 */ public float TimeBeforeHidingHangar;
        /* 0x204 */ public int NumberOfShipsInInitialFleet;
        /* 0x208 */ public bool NewFrigatesStartDamaged;
        /* 0x209 */ public bool ExpeditionsCompleteInstantly;
        /* 0x20A */ public bool ShowSeeds;
        /* 0x20B */ public bool DisablePlayerFleets;
        /* 0x20C */ public float ForceDebriefEntryType;
        /* 0x210 */ public int ForcedSequentialEventsStartingIndex;
        /* 0x214 */ public float NextDebriefDescriptionOffset;
        /* 0x218 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x21C */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x220 */ public float DamagedListEntryPulseRate;
        /* 0x224 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x228 */ public float LowDamageNumberOfExpeditions;
        /* 0x22C */ public int RampDamageNumberOfExpeditions;
        /* 0x230 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x238 */ public int PercentChanceOfGenericEventDescription;
        /* 0x23C */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x240 */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x264 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x288 */ public GcNumberedTextList FrigateBadMoods;
        /* 0x2AC */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x2D0 */ public float RadiusRequiredForFrigateSpawn;
        /* 0x2D4 */ public float SpawnDelayForNewFrigates;
        /* 0x2D8 */ public float SpawnDelayForFleetFrigates;
        /* 0x2DC */ public float SpawnDelayForReturningFrigates;
        /* 0x2E0 */ public float SpawnDelayRandomMin;
        /* 0x2E4 */ public float SpawnDelayRandomMax;
        /* 0x2E8 */ public float SpawnDelayIncreasePerFrigate;
        /* 0x2EC */ public float DespawnDelay;
        /* 0x2F0 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x2F4 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x2F8 */ public float HologramSwapSpeed;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2FC */ public byte[] Padding2FC;
        [NMS(Size = 0x20)]
        /* 0x300 */ public string TerminalNeedsAssignmentPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x320 */ public string TerminalInterventionPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x340 */ public string TerminalDamagePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x360 */ public string TerminalActivePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x380 */ public string TerminalDebriefPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3A0 */ public string NeedFrigatesPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3C0 */ public string NewExpeditionsAvailablePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x3E0 */ public string NeedExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x400 */ public string NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x420 */ public string SelectExpeditionPuzzleID;
        /* 0x440 */ public int NumberOfExpeditionChoices;
        /* 0x444 */ public int ExpeditionDifficultyVariance;
        /* 0x448 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x44C */ public int MinExpeditionStatValue;
        /* 0x450 */ public int MaxExpeditionStatValue;
        /* 0x454 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x458 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x45C */ public int TimeTakenForExpeditionEvent;
        /* 0x460 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x464 */ public int LightYearsPerExpeditionEvent;
        /* 0x468 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x46C */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Size = 0x3)]
        /* 0x470 */ public GcExpeditionPaymentToken[] FreighterTokenProductIDs;
        /* 0x4B8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Size = 0x5)]
        /* 0x558 */ public GcExpeditionPowerup[] Powerups;
        /* 0x710 */ public int FreighterTokenMinimumSpend;
        /* 0x714 */ public float PercentChanceOfInterventionEvent;
        /* 0x718 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x71C */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x720 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x724 */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x728 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x72C */ public int StatPointsAwardedForLevelUp;
        /* 0x730 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x734 */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x738 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x73C */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x740 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x744 */ public float TimeBeforeDebriefLogsStart;
        /* 0x748 */ public bool ShowMissingRewardDescriptions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x749 */ public byte[] Padding749;
        [NMS(Size = 0x20)]
        /* 0x750 */ public string CommunicatorDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x770 */ public string FrigateDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x790 */ public string FrigatePurchasePuzzleTableEntry;
        [NMS(Size = 0x4)]
        /* 0x7B0 */ public int[] DifficultyModifier;
        [NMS(Size = 0x5)]
        /* 0x7C0 */ public GcExpeditionDebriefPunctuation[] DebriefPunctuationList;
        /* 0x874 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x888 */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x89C */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x8B0 */ public Vector4f FrigateCostMultiplier;
        /* 0x8C0 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0xBE0 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0xDC0 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x12C0 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x17C0 */ public GcScanEffectData FrigateScanEffect;
        /* 0x1810 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x1860 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x18B0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x1900 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Size = 0x5)]
        /* 0x1964 */ public NMSString0x80[] FrigateHologramModels;
        [NMS(Size = 0x4)]
        /* 0x1BE4 */ public int[] ExpeditionRankBoundaries;
        [NMS(Size = 0xA)]
        /* 0x1BF4 */ public int[] FrigateLevelVictoriesRequired;
        [NMS(Size = 0x5)]
        /* 0x1C1C */ public GcExpeditionDifficultyKeyframe[] ExpeditionDifficultyKeyframes;
        [NMS(Size = 0xA)]
        /* 0x1C44 */ public NMSString0x80[] FrigateInteriorsToCache;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;
    }
}

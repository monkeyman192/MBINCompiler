using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x16B0, GUID = 0x0DE9B2EF02F090A8)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        [NMS(Size = 0x20)]
        /* 0x0010 */ public string CivilianMPMissionGiverPuzzle;
        /* 0x0030 */ public float MaxPurchaseDistance;
        /* 0x0034 */ public float DistanceForPurchaseReset;
        /* 0x0038 */ public float CombatFrigateSpawnMinRange;
        /* 0x003C */ public float CombatFrigateSpawnAngle;
        /* 0x0040 */ public float CombatNotificationTime;
        /* 0x0044 */ public float CombatDefenderSpawnDelay;
        /* 0x0048 */ public float PostCombatSpawnDelay;
        /* 0x004C */ public float CombatSpawnDelay;
        /* 0x0050 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x0060 */ public int ExplorationPointsRequiredForScan;
        /* 0x0064 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x0078 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x007C */ public byte[] Padding7C;
        [NMS(Size = 0x20)]
        /* 0x0080 */ public string FleetCommunicationOSDMessage;
        /* 0x00A0 */ public int MinFrigateStatValue;
        /* 0x00A4 */ public int MaxFrigateStatValue;
        /* 0x00A8 */ public float MinFrigateDistanceFromFreighter;
        /* 0x00AC */ public float MaxFrigateDistanceFromFreighter;
        /* 0x00B0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0x00B4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0x00B8 */ public int MaximumSpeedDecrease;
        /* 0x00BC */ public int MaximumSpeedIncrease;
        /* 0x00C0 */ public float CameraPauseAfterStartingExpedition;
        /* 0x00C4 */ public float UITraitLinesAngle;
        /* 0x00C8 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        /* 0x00D8 */ public List<NMSString0x20> RacialTermForCaptain;
        /* 0x00E8 */ public float TimeBeforeShowingHangar;
        /* 0x00EC */ public float TimeBeforeHidingHangar;
        /* 0x00F0 */ public int NumberOfShipsInInitialFleet;
        /* 0x00F4 */ public bool NewFrigatesStartDamaged;
        /* 0x00F5 */ public bool ExpeditionsCompleteInstantly;
        /* 0x00F6 */ public bool ShowSeeds;
        /* 0x00F7 */ public bool DisablePlayerFleets;
        [NMS(Size = 0x20)]
        /* 0x00F8 */ public string DebugInterventionEvent;
        // 0x9 entries
        public enum ForceDebriefEntryTypeEnum { None, PrimarySuccess, PrimaryFailure, PrimaryDamage,
            SecondarySuccess, SecondaryFailure, SecondaryDamage, GenericSuccess, GenericFailure };
        /* 0x0118 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x011C */ public int ForcedSequentialEventsStartingIndex;
        /* 0x0120 */ public int NextDebriefDescriptionOffset;
        /* 0x0124 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x0128 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x012C */ public float DamagedListEntryPulseRate;
        /* 0x0130 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x0134 */ public int LowDamageNumberOfExpeditions;
        /* 0x0138 */ public int RampDamageNumberOfExpeditions;
        /* 0x013C */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x0144 */ public int PercentChanceOfGenericEventDescription;
        /* 0x0148 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x014C */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x0170 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x0194 */ public GcNumberedTextList FrigateBadMoods;
        /* 0x01B8 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x01DC */ public float RadiusRequiredForFrigateSpawn;
        /* 0x01E0 */ public float SpawnDelayForNewFrigates;
        /* 0x01E4 */ public float SpawnDelayForFleetFrigates;
        /* 0x01E8 */ public float SpawnDelayForReturningFrigates;
        /* 0x01EC */ public float SpawnDelayRandomMin;
        /* 0x01F0 */ public float SpawnDelayRandomMax;
        /* 0x01F4 */ public float SpawnDelayIncreasePerFrigate;
        /* 0x01F8 */ public float DespawnDelay;
        /* 0x01FC */ public float DespawnDelayIncreasePerFrigate;
        /* 0x0200 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x0204 */ public float HologramSwapSpeed;
        [NMS(Size = 0x20)]
        /* 0x0208 */ public string TerminalNeedsAssignmentPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0228 */ public string TerminalInterventionPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0248 */ public string TerminalDamagePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0268 */ public string TerminalActivePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0288 */ public string TerminalDebriefPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x02A8 */ public string NeedFrigatesPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x02C8 */ public string NewExpeditionsAvailablePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x02E8 */ public string NeedExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0308 */ public string NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0328 */ public string SelectExpeditionPuzzleID;
        /* 0x0348 */ public int NumberOfExpeditionChoices;
        /* 0x034C */ public int ExpeditionDifficultyVariance;
        /* 0x0350 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x0354 */ public int MinExpeditionStatValue;
        /* 0x0358 */ public int MaxExpeditionStatValue;
        /* 0x035C */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x0360 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x0364 */ public int TimeTakenForExpeditionEvent;
        /* 0x0368 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x036C */ public int LightYearsPerExpeditionEvent;
        /* 0x0370 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x0374 */ public int TimeBetweenPassiveIncomeTicks;
        /* 0x0378 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        /* 0x0388 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        /* 0x0428 */ public List<GcExpeditionPowerup> Powerups;
        /* 0x0438 */ public int FreighterTokenMinimumSpend;
        /* 0x043C */ public int PercentChanceOfInterventionEvent;
        /* 0x0440 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x0444 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x0448 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x044C */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x0450 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x0454 */ public int StatPointsAwardedForLevelUp;
        /* 0x0458 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x045C */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x0460 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x0464 */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x0468 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x046C */ public float TimeBeforeDebriefLogsStart;
        /* 0x0470 */ public bool ShowMissingRewardDescriptions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x0471 */ public byte[] Padding471;
        [NMS(Size = 0x20)]
        /* 0x0478 */ public string CommunicatorDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x0498 */ public string FrigateDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x04B8 */ public string FrigatePurchasePuzzleTableEntry;
        /* 0x04D8 */ public List<int> DifficultyModifier;
        /* 0x04E8 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        /* 0x04F8 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x050C */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x0520 */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x0534 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0544 */ public byte[] Padding544;
        /* 0x0548 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x0868 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x0A48 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x0F48 */ public GcFrigateTraitIcons NegativeTraitIcons;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1448 */ public byte[] Padding1448;
        /* 0x1450 */ public GcScanEffectData FrigateScanEffect;
        /* 0x14A0 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x14F0 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x1540 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x1590 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x15E0 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1644 */ public byte[] Padding1644;
        /* 0x1648 */ public List<NMSString0x80> FrigateHologramModels;
        /* 0x1658 */ public List<NMSString0x80> FrigatePlanetModels;
        /* 0x1668 */ public List<int> ExpeditionRankBoundaries;
        /* 0x1678 */ public List<int> FrigateLevelVictoriesRequired;
        /* 0x1688 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        /* 0x1698 */ public List<NMSString0x80> FrigateInteriorsToCache;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x16A8 */ public byte[] EndPadding;
    }
}

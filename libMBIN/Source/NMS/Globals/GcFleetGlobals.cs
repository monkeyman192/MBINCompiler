using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xFEC2822F248FB729, NameHash = 0xB032629C37506E6A)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        /* 0x0010 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        /* 0x0030 */ public float MaxPurchaseDistance;
        /* 0x0034 */ public float SingleShipFlybyDistance;
        /* 0x0038 */ public float SingleShipFlybyMaxAngle;
        /* 0x003C */ public float SingleShipFlybyHeightOffset;
        /* 0x0040 */ public float DistanceForSingleShipFlybyCommsReset;
        /* 0x0044 */ public float DistanceForPurchaseReset;
        /* 0x0048 */ public float CombatFrigateSpawnMinRange;
        /* 0x004C */ public float CombatFrigateSpawnAngle;
        /* 0x0050 */ public float CombatNotificationTime;
        /* 0x0054 */ public float CombatDefenderSpawnDelay;
        /* 0x0058 */ public float PostCombatSpawnDelay;
        /* 0x005C */ public float CombatSpawnDelay;
        /* 0x0060 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x0070 */ public int ExplorationPointsRequiredForScan;
        /* 0x0074 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x0088 */ public int PercentChangeOfFrigateBeingPurchasable;
        /* 0x0090 */ public NMSString0x20A FleetCommunicationOSDMessage;
        /* 0x00B0 */ public int MinFrigateStatValue;
        /* 0x00B4 */ public int MaxFrigateStatValue;
        /* 0x00B8 */ public float MinFrigateDistanceFromFreighter;
        /* 0x00BC */ public float MaxFrigateDistanceFromFreighter;
        /* 0x00C0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0x00C4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0x00C8 */ public int MaximumSpeedDecrease;
        /* 0x00CC */ public int MaximumSpeedIncrease;
        /* 0x00D0 */ public float CameraPauseAfterStartingExpedition;
        /* 0x00D4 */ public float UITraitLinesAngle;
        /* 0x00D8 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        /* 0x00E8 */ public List<NMSString0x20> RacialTermForCaptain;
        /* 0x00F8 */ public float TimeBeforeShowingHangar;
        /* 0x00FC */ public float TimeBeforeHidingHangar;
        /* 0x0100 */ public int NumberOfShipsInInitialFleet;
        /* 0x0104 */ public bool NewFrigatesStartDamaged;
        /* 0x0105 */ public bool ExpeditionsCompleteInstantly;
        /* 0x0106 */ public bool ShowSeeds;
        /* 0x0107 */ public bool DisablePlayerFleets;
        /* 0x0108 */ public NMSString0x20A DebugInterventionEvent;
        // size: 0xB
        public enum ForceDebriefEntryTypeEnum { 
            None,
            PrimarySuccess,
            WhaleSuccess,
            PrimaryFailure,
            PrimaryDamage,
            SecondarySuccess,
            SecondaryFailure,
            SecondaryDamage,
            GenericSuccess,
            GenericFailure,
            WhaleFailure
        }
        /* 0x0128 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x012C */ public int ForcedSequentialEventsStartingIndex;
        /* 0x0130 */ public int NextDebriefDescriptionOffset;
        /* 0x0134 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x0138 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x013C */ public float DamagedListEntryPulseRate;
        /* 0x0140 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x0144 */ public int LowDamageNumberOfExpeditions;
        /* 0x0148 */ public int RampDamageNumberOfExpeditions;
        /* 0x014C */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x0154 */ public int PercentChanceOfGenericEventDescription;
        /* 0x0158 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x015C */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x0180 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x01A4 */ public GcNumberedTextList FrigateBadMoods;
        [NMS(Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x01C8 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        /* 0x0354 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x0378 */ public float RadiusRequiredForFrigateSpawn;
        /* 0x037C */ public float SpawnDelayForNewFrigates;
        /* 0x0380 */ public float SpawnDelayForFleetFrigates;
        /* 0x0384 */ public float SpawnDelayForReturningFrigates;
        /* 0x0388 */ public float SpawnDelayRandomMin;
        /* 0x038C */ public float SpawnDelayRandomMax;
        /* 0x0390 */ public float SpawnDelayIncreasePerFrigate;
        /* 0x0394 */ public float DespawnDelay;
        /* 0x0398 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x039C */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x03A0 */ public float HologramSwapSpeed;
        /* 0x03A8 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        /* 0x03C8 */ public NMSString0x20A TerminalInterventionPuzzleID;
        /* 0x03E8 */ public NMSString0x20A TerminalDamagePuzzleID;
        /* 0x0408 */ public NMSString0x20A TerminalActivePuzzleID;
        /* 0x0428 */ public NMSString0x20A TerminalDebriefPuzzleID;
        /* 0x0448 */ public NMSString0x20A NormandyActivePuzzleID;
        /* 0x0468 */ public NMSString0x20A NormandyDebriefPuzzleID;
        /* 0x0488 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        /* 0x04A8 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        /* 0x04C8 */ public NMSString0x20A NeedFrigatesPuzzleID;
        /* 0x04E8 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        /* 0x0508 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        /* 0x0528 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        /* 0x0548 */ public NMSString0x20A SelectExpeditionPuzzleID;
        /* 0x0568 */ public int NumberOfExpeditionChoices;
        /* 0x056C */ public int ExpeditionDifficultyVariance;
        /* 0x0570 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x0574 */ public int MinExpeditionStatValue;
        /* 0x0578 */ public int MaxExpeditionStatValue;
        /* 0x057C */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x0580 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x0584 */ public int TimeTakenForExpeditionEvent;
        /* 0x0588 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x058C */ public int LightYearsPerExpeditionEvent;
        /* 0x0590 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x0594 */ public int TimeBetweenPassiveIncomeTicks;
        /* 0x0598 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        /* 0x05A8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        /* 0x06A8 */ public List<GcExpeditionPowerup> Powerups;
        /* 0x06B8 */ public int FreighterTokenMinimumSpend;
        /* 0x06BC */ public int PercentChanceOfInterventionEvent;
        /* 0x06C0 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x06C4 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x06C8 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x06CC */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x06D0 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x06D4 */ public int StatPointsAwardedForLevelUp;
        /* 0x06D8 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x06DC */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x06E0 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x06E4 */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x06E8 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x06EC */ public float TimeBeforeDebriefLogsStart;
        /* 0x06F0 */ public bool ShowMissingRewardDescriptions;
        /* 0x06F8 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        /* 0x0718 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        /* 0x0738 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        /* 0x0758 */ public List<int> DifficultyModifier;
        /* 0x0768 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        /* 0x0778 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x078C */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x07AC */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x07CC */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        /* 0x07E0 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x0B50 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x0E90 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x1410 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x1990 */ public GcScanEffectData FrigateScanEffect;
        /* 0x19E0 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x1A30 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x1A80 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x1AD0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x1B20 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        /* 0x1B88 */ public List<NMSString0x80> FrigateHologramModels;
        /* 0x1B98 */ public List<NMSString0x80> FrigatePlanetModels;
        /* 0x1BA8 */ public List<int> ExpeditionRankBoundaries;
        /* 0x1BB8 */ public List<int> FrigateLevelVictoriesRequired;
        /* 0x1BC8 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        /* 0x1BD8 */ public List<NMSString0x80> FrigateInteriorsToCache;
        /* 0x1BE8 */ public int NormandyFailures;
        /* 0x1BEC */ public int NormandyDamageEvents;
        /* 0x1BF0 */ public List<NMSString0x10> NormandyTraits;
        /* 0x1C00 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        /* 0x1C10 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        /* 0x1C20 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        /* 0x1C30 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
    }
}

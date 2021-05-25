using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1910, GUID = 0x284B5EBC189D518E, NameHash = 0xB032629C37506E6A)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        [NMS(Size = 0x20)]
        /* 0x0010 */ public string CivilianMPMissionGiverPuzzle;
        /* 0x0030 */ public float MaxPurchaseDistance;
        /* 0x0034 */ public float SingleShipFlybyDistance;
        /* 0x0038 */ public float SingleShipFlybyMaxAngle;
        /* 0x003C */ public float SingleShipFlybyHeightOffset;
        /* 0x0040 */ public float DistanceForFlybyCommsReset;
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
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x008C */ public byte[] Padding8C;
        [NMS(Size = 0x20)]
        /* 0x0090 */ public string FleetCommunicationOSDMessage;
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
        [NMS(Size = 0x20)]
        /* 0x0108 */ public string DebugInterventionEvent;
        // size: 0x9                      
        public enum ForceDebriefEntryTypeEnum {None, PrimarySuccess, PrimaryFailure, PrimaryDamage,
            SecondarySuccess, SecondaryFailure, SecondaryDamage, GenericSuccess, GenericFailure };                 
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
        /* 0x01C8 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x01EC */ public float RadiusRequiredForFrigateSpawn;
        /* 0x01F0 */ public float SpawnDelayForNewFrigates;
        /* 0x01F4 */ public float SpawnDelayForFleetFrigates;
        /* 0x01F8 */ public float SpawnDelayForReturningFrigates;
        /* 0x01FC */ public float SpawnDelayRandomMin;
        /* 0x0200 */ public float SpawnDelayRandomMax;
        /* 0x0204 */ public float SpawnDelayIncreasePerFrigate;
        /* 0x0208 */ public float DespawnDelay;
        /* 0x020C */ public float DespawnDelayIncreasePerFrigate;
        /* 0x0210 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x0214 */ public float HologramSwapSpeed;
        [NMS(Size = 0x20)]
        /* 0x0218 */ public string TerminalNeedsAssignmentPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0238 */ public string TerminalInterventionPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0258 */ public string TerminalDamagePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0278 */ public string TerminalActivePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0298 */ public string TerminalDebriefPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x02B8 */ public string NormandyActivePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x02D8 */ public string NormandyDebriefPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x02F8 */ public string NeedFrigatesPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0318 */ public string NewExpeditionsAvailablePuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0338 */ public string NeedExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0358 */ public string NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Size = 0x20)]
        /* 0x0378 */ public string SelectExpeditionPuzzleID;
        /* 0x0398 */ public int NumberOfExpeditionChoices;
        /* 0x039C */ public int ExpeditionDifficultyVariance;
        /* 0x03A0 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x03A4 */ public int MinExpeditionStatValue;
        /* 0x03A8 */ public int MaxExpeditionStatValue;
        /* 0x03AC */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x03B0 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x03B4 */ public int TimeTakenForExpeditionEvent;
        /* 0x03B8 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x03BC */ public int LightYearsPerExpeditionEvent;
        /* 0x03C0 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x03C4 */ public int TimeBetweenPassiveIncomeTicks;
        /* 0x03C8 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        /* 0x03D8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        /* 0x0498 */ public List<GcExpeditionPowerup> Powerups;
        /* 0x04A8 */ public int FreighterTokenMinimumSpend;
        /* 0x04AC */ public int PercentChanceOfInterventionEvent;
        /* 0x04B0 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x04B4 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x04B8 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x04BC */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x04C0 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x04C4 */ public int StatPointsAwardedForLevelUp;
        /* 0x04C8 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x04CC */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x04D0 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x04D4 */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x04D8 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x04DC */ public float TimeBeforeDebriefLogsStart;
        /* 0x04E0 */ public bool ShowMissingRewardDescriptions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x04E1 */ public byte[] Padding4E1;
        [NMS(Size = 0x20)]
        /* 0x04E8 */ public string CommunicatorDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x0508 */ public string FrigateDamagePuzzleTableEntry;
        [NMS(Size = 0x20)]
        /* 0x0528 */ public string FrigatePurchasePuzzleTableEntry;
        /* 0x0548 */ public List<int> DifficultyModifier;
        /* 0x0558 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        /* 0x0568 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x057C */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x0594 */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x05AC */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x05BC */ public byte[] Padding5BC;
        /* 0x05C0 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x0930 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x0BA0 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x1120 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x16A0 */ public GcScanEffectData FrigateScanEffect;
        /* 0x16F0 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x1740 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x1790 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x17E0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x1830 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1894 */ public byte[] Padding1894;
        /* 0x1898 */ public List<NMSString0x80> FrigateHologramModels;
        /* 0x18A8 */ public List<NMSString0x80> FrigatePlanetModels;
        /* 0x18B8 */ public List<int> ExpeditionRankBoundaries;
        /* 0x18C8 */ public List<int> FrigateLevelVictoriesRequired;
        /* 0x18D8 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        /* 0x18E8 */ public List<NMSString0x80> FrigateInteriorsToCache;
        /* 0x18F8 */ public int NormandyFailures;
        /* 0x18FC */ public int NormandyDamageEvents;
        /* 0x1900 */ public List<NMSString0x10> NormandyTraits;
    }
}

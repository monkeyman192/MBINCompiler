using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x78C62618191354A2, NameHash = 0xB032629C37506E6A)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x0050 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x00A0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x00F0 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x0140 */ public GcScanEffectData FrigateScanEffect;
        /* 0x0190 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        /* 0x01A0 */ public Vector3f PirateFreighterCustomiserSunAngleAdjust;
        /* 0x01B0 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x0558 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x08C8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        /* 0x09E8 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        /* 0x0A08 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        /* 0x0A28 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        /* 0x0A48 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        /* 0x0A68 */ public NMSString0x20A FleetCommunicationOSDMessage;
        /* 0x0A88 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        /* 0x0AA8 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        /* 0x0AC8 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        /* 0x0AE8 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        /* 0x0B08 */ public NMSString0x20A NeedFrigatesPuzzleID;
        /* 0x0B28 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        /* 0x0B48 */ public NMSString0x20A NormandyActivePuzzleID;
        /* 0x0B68 */ public NMSString0x20A NormandyDebriefPuzzleID;
        /* 0x0B88 */ public NMSString0x20A NormandyInterventionPuzzleID;
        /* 0x0BA8 */ public NMSString0x20A SelectExpeditionPuzzleID;
        /* 0x0BC8 */ public NMSString0x20A TerminalActivePuzzleID;
        /* 0x0BE8 */ public NMSString0x20A TerminalDamagePuzzleID;
        /* 0x0C08 */ public NMSString0x20A TerminalDebriefPuzzleID;
        /* 0x0C28 */ public NMSString0x20A TerminalInterventionPuzzleID;
        /* 0x0C48 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        /* 0x0C68 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x0C78 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        /* 0x0C88 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        /* 0x0C98 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        /* 0x0CA8 */ public List<int> DifficultyModifier;
        /* 0x0CB8 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        /* 0x0CC8 */ public List<int> ExpeditionRankBoundaries;
        /* 0x0CD8 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        /* 0x0CE8 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        /* 0x0CF8 */ public List<NMSString0x80> FrigateHologramModels;
        /* 0x0D08 */ public List<NMSString0x80> FrigateInteriorsToCache;
        /* 0x0D18 */ public List<int> FrigateLevelVictoriesRequired;
        /* 0x0D28 */ public List<NMSString0x80> FrigatePlanetModels;
        /* 0x0D38 */ public List<NMSString0x10> NormandyTraits;
        /* 0x0D48 */ public List<GcExpeditionPowerup> Powerups;
        /* 0x0D58 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        [NMS(Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0D68 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        /* 0x0EF4 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        /* 0x0F58 */ public GcNumberedTextList FrigateBadMoods;
        /* 0x0F7C */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x0FA0 */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x0FC4 */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x0FE8 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x100C */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x1030 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x1044 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x1058 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        /* 0x1068 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x1070 */ public float CameraPauseAfterStartingExpedition;
        /* 0x1074 */ public float CombatDefenderSpawnDelay;
        /* 0x1078 */ public float CombatFrigateSpawnAngle;
        /* 0x107C */ public float CombatFrigateSpawnMinRange;
        /* 0x1080 */ public float CombatNotificationTime;
        /* 0x1084 */ public float CombatSpawnDelay;
        /* 0x1088 */ public float DamagedListEntryPulseRate;
        /* 0x108C */ public float DespawnDelay;
        /* 0x1090 */ public float DespawnDelayIncreasePerFrigate;
        /* 0x1094 */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x1098 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x109C */ public float DistanceForPurchaseReset;
        /* 0x10A0 */ public float DistanceForSingleShipFlybyCommsReset;
        /* 0x10A4 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x10A8 */ public int ExpeditionDifficultyVariance;
        /* 0x10AC */ public int ExplorationPointsRequiredForScan;
        /* 0x10B0 */ public int FirstEventIndexWhichCanBeIntervention;
        // size: 0xB
        public enum ForceDebriefEntryTypeEnum : uint {
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
            WhaleFailure,
        }
        /* 0x10B4 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x10B8 */ public int ForcedSequentialEventsStartingIndex;
        /* 0x10BC */ public int FreighterTokenMinimumSpend;
        /* 0x10C0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0x10C4 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x10C8 */ public float HologramSwapSpeed;
        /* 0x10CC */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x10D0 */ public int LightYearsPerExpeditionEvent;
        /* 0x10D4 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x10D8 */ public int LowDamageNumberOfExpeditions;
        /* 0x10DC */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x10E0 */ public int MaxExpeditionStatValue;
        /* 0x10E4 */ public float MaxFrigateDistanceFromFreighter;
        /* 0x10E8 */ public int MaxFrigateStatValue;
        /* 0x10EC */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x10F0 */ public int MaximumSpeedDecrease;
        /* 0x10F4 */ public int MaximumSpeedIncrease;
        /* 0x10F8 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
        /* 0x10FC */ public float MaxPurchaseDistance;
        /* 0x1100 */ public int MinExpeditionStatValue;
        /* 0x1104 */ public float MinFrigateDistanceFromFreighter;
        /* 0x1108 */ public int MinFrigateStatValue;
        /* 0x110C */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x1110 */ public int NextDebriefDescriptionOffset;
        /* 0x1114 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x1118 */ public int NormandyDamageEvents;
        /* 0x111C */ public int NormandyFailures;
        /* 0x1120 */ public int NumberOfExpeditionChoices;
        /* 0x1124 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x1128 */ public int NumberOfShipsInInitialFleet;
        /* 0x112C */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x1130 */ public int OverrideExpeditionSecondsPerDay;
        /* 0x1134 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0x1138 */ public int PercentChanceOfGenericEventDescription;
        /* 0x113C */ public int PercentChanceOfInterventionEvent;
        /* 0x1140 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x1144 */ public int PercentChangeOfFrigateBeingPurchasable;
        /* 0x1148 */ public float PostCombatSpawnDelay;
        /* 0x114C */ public float RadiusRequiredForFrigateSpawn;
        /* 0x1150 */ public int RampDamageNumberOfExpeditions;
        /* 0x1154 */ public float SingleShipFlybyDistance;
        /* 0x1158 */ public float SingleShipFlybyHeightOffset;
        /* 0x115C */ public float SingleShipFlybyMaxAngle;
        /* 0x1160 */ public float SpawnDelayForFleetFrigates;
        /* 0x1164 */ public float SpawnDelayForNewFrigates;
        /* 0x1168 */ public float SpawnDelayForReturningFrigates;
        /* 0x116C */ public float SpawnDelayIncreasePerFrigate;
        /* 0x1170 */ public float SpawnDelayRandomMax;
        /* 0x1174 */ public float SpawnDelayRandomMin;
        /* 0x1178 */ public int StatPointsAwardedForLevelUp;
        /* 0x117C */ public float TimeBeforeDebriefLogsStart;
        /* 0x1180 */ public float TimeBeforeHidingHangar;
        /* 0x1184 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x1188 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x118C */ public float TimeBeforeShowingHangar;
        /* 0x1190 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x1194 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x1198 */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x119C */ public int TimeBetweenPassiveIncomeTicks;
        /* 0x11A0 */ public int TimeTakenForExpeditionEvent;
        /* 0x11A4 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x11A8 */ public float UITraitLinesAngle;
        /* 0x11AC */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x172C */ public GcFrigateTraitIcons TraitIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1CAC */ public NMSString0x20[] RacialTermForCaptain;
        /* 0x1DCC */ public bool DisablePlayerFleets;
        /* 0x1DCD */ public bool ExpeditionsCompleteInstantly;
        /* 0x1DCE */ public bool NewFrigatesStartDamaged;
        /* 0x1DCF */ public bool ShowMissingRewardDescriptions;
        /* 0x1DD0 */ public bool ShowSeeds;
    }
}

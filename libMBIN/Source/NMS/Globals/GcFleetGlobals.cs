using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x78C62618191354A2, NameHash = 0xB032629C37506E6A)]
    public class GcFleetGlobals : NMSTemplate
    {
        [NMS(Index = 128)]
        /* 0x0000 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        [NMS(Index = 129)]
        /* 0x0050 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        [NMS(Index = 130)]
        /* 0x00A0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        [NMS(Index = 127)]
        /* 0x00F0 */ public GcScanEffectData FrigateHologramScanEffect;
        [NMS(Index = 126)]
        /* 0x0140 */ public GcScanEffectData FrigateScanEffect;
        [NMS(Index = 0)]
        /* 0x0190 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        [NMS(Index = 1)]
        /* 0x01A0 */ public Vector3f PirateFreighterCustomiserSunAngleAdjust;
        [NMS(Index = 123)]
        /* 0x01B0 */ public GcFrigateStatsByClass FrigateInitialStats;
        [NMS(Index = 122)]
        /* 0x0558 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        [NMS(Index = 96)]
        /* 0x08C8 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Index = 2)]
        /* 0x09E8 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        [NMS(Index = 113)]
        /* 0x0A08 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        [NMS(Index = 76)]
        /* 0x0A28 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        [NMS(Index = 77)]
        /* 0x0A48 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        [NMS(Index = 19)]
        /* 0x0A68 */ public NMSString0x20A FleetCommunicationOSDMessage;
        [NMS(Index = 114)]
        /* 0x0A88 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        [NMS(Index = 115)]
        /* 0x0AA8 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        [NMS(Index = 81)]
        /* 0x0AC8 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Index = 80)]
        /* 0x0AE8 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        [NMS(Index = 78)]
        /* 0x0B08 */ public NMSString0x20A NeedFrigatesPuzzleID;
        [NMS(Index = 79)]
        /* 0x0B28 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        [NMS(Index = 74)]
        /* 0x0B48 */ public NMSString0x20A NormandyActivePuzzleID;
        [NMS(Index = 75)]
        /* 0x0B68 */ public NMSString0x20A NormandyDebriefPuzzleID;
        [NMS(Index = 73)]
        /* 0x0B88 */ public NMSString0x20A NormandyInterventionPuzzleID;
        [NMS(Index = 82)]
        /* 0x0BA8 */ public NMSString0x20A SelectExpeditionPuzzleID;
        [NMS(Index = 71)]
        /* 0x0BC8 */ public NMSString0x20A TerminalActivePuzzleID;
        [NMS(Index = 70)]
        /* 0x0BE8 */ public NMSString0x20A TerminalDamagePuzzleID;
        [NMS(Index = 72)]
        /* 0x0C08 */ public NMSString0x20A TerminalDebriefPuzzleID;
        [NMS(Index = 69)]
        /* 0x0C28 */ public NMSString0x20A TerminalInterventionPuzzleID;
        [NMS(Index = 68)]
        /* 0x0C48 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        [NMS(Index = 15)]
        /* 0x0C68 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        [NMS(Index = 117)]
        /* 0x0C78 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        [NMS(Index = 142)]
        /* 0x0C88 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        [NMS(Index = 141)]
        /* 0x0C98 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        [NMS(Index = 116)]
        /* 0x0CA8 */ public List<int> DifficultyModifier;
        [NMS(Index = 136)]
        /* 0x0CB8 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        [NMS(Index = 134)]
        /* 0x0CC8 */ public List<int> ExpeditionRankBoundaries;
        [NMS(Index = 95)]
        /* 0x0CD8 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        [NMS(Index = 143)]
        /* 0x0CE8 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        [NMS(Index = 132)]
        /* 0x0CF8 */ public List<NMSString0x80> FrigateHologramModels;
        [NMS(Index = 137)]
        /* 0x0D08 */ public List<NMSString0x80> FrigateInteriorsToCache;
        [NMS(Index = 135)]
        /* 0x0D18 */ public List<int> FrigateLevelVictoriesRequired;
        [NMS(Index = 133)]
        /* 0x0D28 */ public List<NMSString0x80> FrigatePlanetModels;
        [NMS(Index = 140)]
        /* 0x0D38 */ public List<NMSString0x10> NormandyTraits;
        [NMS(Index = 97)]
        /* 0x0D48 */ public List<GcExpeditionPowerup> Powerups;
        [NMS(Index = 30)]
        /* 0x0D58 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        [NMS(Index = 55, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0D68 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        [NMS(Index = 131)]
        /* 0x0EF4 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Index = 54)]
        /* 0x0F58 */ public GcNumberedTextList FrigateBadMoods;
        [NMS(Index = 119)]
        /* 0x0F7C */ public GcFrigateClassCost FrigateBaseCost;
        [NMS(Index = 120)]
        /* 0x0FA0 */ public GcFrigateClassCost FrigateCostVariance;
        [NMS(Index = 52)]
        /* 0x0FC4 */ public GcNumberedTextList FrigateDamageDescriptions;
        [NMS(Index = 56)]
        /* 0x0FE8 */ public GcNumberedTextList FrigateExtraNotes;
        [NMS(Index = 53)]
        /* 0x100C */ public GcNumberedTextList FrigateGoodMoods;
        [NMS(Index = 118)]
        /* 0x1030 */ public GcExpeditionDurationValues ExpeditionDurations;
        [NMS(Index = 17)]
        /* 0x1044 */ public GcInteractionDof FleetInteractionDepthOfField;
        [NMS(Index = 121)]
        /* 0x1058 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        [NMS(Index = 49)]
        /* 0x1068 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        [NMS(Index = 28)]
        /* 0x1070 */ public float CameraPauseAfterStartingExpedition;
        [NMS(Index = 12)]
        /* 0x1074 */ public float CombatDefenderSpawnDelay;
        [NMS(Index = 10)]
        /* 0x1078 */ public float CombatFrigateSpawnAngle;
        [NMS(Index = 9)]
        /* 0x107C */ public float CombatFrigateSpawnMinRange;
        [NMS(Index = 11)]
        /* 0x1080 */ public float CombatNotificationTime;
        [NMS(Index = 14)]
        /* 0x1084 */ public float CombatSpawnDelay;
        [NMS(Index = 45)]
        /* 0x1088 */ public float DamagedListEntryPulseRate;
        [NMS(Index = 64)]
        /* 0x108C */ public float DespawnDelay;
        [NMS(Index = 65)]
        /* 0x1090 */ public float DespawnDelayIncreasePerFrigate;
        [NMS(Index = 103)]
        /* 0x1094 */ public float DifficultyMultiplierForBalancedExpeditions;
        [NMS(Index = 104)]
        /* 0x1098 */ public float DifficultyMultiplierForNonPrimaryEvents;
        [NMS(Index = 8)]
        /* 0x109C */ public float DistanceForPurchaseReset;
        [NMS(Index = 7)]
        /* 0x10A0 */ public float DistanceForSingleShipFlybyCommsReset;
        [NMS(Index = 85)]
        /* 0x10A4 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        [NMS(Index = 84)]
        /* 0x10A8 */ public int ExpeditionDifficultyVariance;
        [NMS(Index = 16)]
        /* 0x10AC */ public int ExplorationPointsRequiredForScan;
        [NMS(Index = 100)]
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
        [NMS(Index = 40)]
        /* 0x10B4 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        [NMS(Index = 41)]
        /* 0x10B8 */ public int ForcedSequentialEventsStartingIndex;
        [NMS(Index = 98)]
        /* 0x10BC */ public int FreighterTokenMinimumSpend;
        [NMS(Index = 24)]
        /* 0x10C0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        [NMS(Index = 66)]
        /* 0x10C4 */ public float FrigatesPerSecondForInstantSpawn;
        [NMS(Index = 67)]
        /* 0x10C8 */ public float HologramSwapSpeed;
        [NMS(Index = 43)]
        /* 0x10CC */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        [NMS(Index = 92)]
        /* 0x10D0 */ public int LightYearsPerExpeditionEvent;
        [NMS(Index = 91)]
        /* 0x10D4 */ public int LightYearsPerExpeditionEvent_Easy;
        [NMS(Index = 47)]
        /* 0x10D8 */ public int LowDamageNumberOfExpeditions;
        [NMS(Index = 102)]
        /* 0x10DC */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        [NMS(Index = 87)]
        /* 0x10E0 */ public int MaxExpeditionStatValue;
        [NMS(Index = 23)]
        /* 0x10E4 */ public float MaxFrigateDistanceFromFreighter;
        [NMS(Index = 21)]
        /* 0x10E8 */ public int MaxFrigateStatValue;
        [NMS(Index = 107)]
        /* 0x10EC */ public int MaxGapBetweenExpeditionLogEntries;
        [NMS(Index = 26)]
        /* 0x10F0 */ public int MaximumSpeedDecrease;
        [NMS(Index = 27)]
        /* 0x10F4 */ public int MaximumSpeedIncrease;
        [NMS(Index = 144)]
        /* 0x10F8 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
        [NMS(Index = 3)]
        /* 0x10FC */ public float MaxPurchaseDistance;
        [NMS(Index = 86)]
        /* 0x1100 */ public int MinExpeditionStatValue;
        [NMS(Index = 22)]
        /* 0x1104 */ public float MinFrigateDistanceFromFreighter;
        [NMS(Index = 20)]
        /* 0x1108 */ public int MinFrigateStatValue;
        [NMS(Index = 106)]
        /* 0x110C */ public int MinGapBetweenExpeditionLogEntries;
        [NMS(Index = 42)]
        /* 0x1110 */ public int NextDebriefDescriptionOffset;
        [NMS(Index = 46)]
        /* 0x1114 */ public float NonUrgentDamagedListEntryAlpha;
        [NMS(Index = 139)]
        /* 0x1118 */ public int NormandyDamageEvents;
        [NMS(Index = 138)]
        /* 0x111C */ public int NormandyFailures;
        [NMS(Index = 83)]
        /* 0x1120 */ public int NumberOfExpeditionChoices;
        [NMS(Index = 88)]
        /* 0x1124 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        [NMS(Index = 34)]
        /* 0x1128 */ public int NumberOfShipsInInitialFleet;
        [NMS(Index = 93)]
        /* 0x112C */ public int NumberOfUAChangesPerExpeditionEvent;
        [NMS(Index = 37)]
        /* 0x1130 */ public int OverrideExpeditionSecondsPerDay;
        [NMS(Index = 25)]
        /* 0x1134 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        [NMS(Index = 50)]
        /* 0x1138 */ public int PercentChanceOfGenericEventDescription;
        [NMS(Index = 99)]
        /* 0x113C */ public int PercentChanceOfInterventionEvent;
        [NMS(Index = 51)]
        /* 0x1140 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        [NMS(Index = 18)]
        /* 0x1144 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Index = 13)]
        /* 0x1148 */ public float PostCombatSpawnDelay;
        [NMS(Index = 57)]
        /* 0x114C */ public float RadiusRequiredForFrigateSpawn;
        [NMS(Index = 48)]
        /* 0x1150 */ public int RampDamageNumberOfExpeditions;
        [NMS(Index = 4)]
        /* 0x1154 */ public float SingleShipFlybyDistance;
        [NMS(Index = 6)]
        /* 0x1158 */ public float SingleShipFlybyHeightOffset;
        [NMS(Index = 5)]
        /* 0x115C */ public float SingleShipFlybyMaxAngle;
        [NMS(Index = 59)]
        /* 0x1160 */ public float SpawnDelayForFleetFrigates;
        [NMS(Index = 58)]
        /* 0x1164 */ public float SpawnDelayForNewFrigates;
        [NMS(Index = 60)]
        /* 0x1168 */ public float SpawnDelayForReturningFrigates;
        [NMS(Index = 63)]
        /* 0x116C */ public float SpawnDelayIncreasePerFrigate;
        [NMS(Index = 62)]
        /* 0x1170 */ public float SpawnDelayRandomMax;
        [NMS(Index = 61)]
        /* 0x1174 */ public float SpawnDelayRandomMin;
        [NMS(Index = 105)]
        /* 0x1178 */ public int StatPointsAwardedForLevelUp;
        [NMS(Index = 111)]
        /* 0x117C */ public float TimeBeforeDebriefLogsStart;
        [NMS(Index = 33)]
        /* 0x1180 */ public float TimeBeforeHidingHangar;
        [NMS(Index = 44)]
        /* 0x1184 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        [NMS(Index = 101)]
        /* 0x1188 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        [NMS(Index = 32)]
        /* 0x118C */ public float TimeBeforeShowingHangar;
        [NMS(Index = 108)]
        /* 0x1190 */ public float TimeBetweenDebriefLettersAppearing;
        [NMS(Index = 110)]
        /* 0x1194 */ public float TimeBetweenDebriefLogsAppearing;
        [NMS(Index = 109)]
        /* 0x1198 */ public float TimeBetweenDebriefLogSectionsAppearing;
        [NMS(Index = 94)]
        /* 0x119C */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Index = 90)]
        /* 0x11A0 */ public int TimeTakenForExpeditionEvent;
        [NMS(Index = 89)]
        /* 0x11A4 */ public int TimeTakenForExpeditionEvent_Easy;
        [NMS(Index = 29)]
        /* 0x11A8 */ public float UITraitLinesAngle;
        [NMS(Index = 125)]
        /* 0x11AC */ public GcFrigateTraitIcons NegativeTraitIcons;
        [NMS(Index = 124)]
        /* 0x172C */ public GcFrigateTraitIcons TraitIcons;
        [NMS(Index = 31, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1CAC */ public NMSString0x20[] RacialTermForCaptain;
        [NMS(Index = 39)]
        /* 0x1DCC */ public bool DisablePlayerFleets;
        [NMS(Index = 36)]
        /* 0x1DCD */ public bool ExpeditionsCompleteInstantly;
        [NMS(Index = 35)]
        /* 0x1DCE */ public bool NewFrigatesStartDamaged;
        [NMS(Index = 112)]
        /* 0x1DCF */ public bool ShowMissingRewardDescriptions;
        [NMS(Index = 38)]
        /* 0x1DD0 */ public bool ShowSeeds;
    }
}

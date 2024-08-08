using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x1E3F85C14675717, NameHash = 0xCD2E438C)]
    public class GcFleetGlobals : NMSTemplate
    {
        [NMS(Index = 129)]
        /* 0x0000 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        [NMS(Index = 130)]
        /* 0x0050 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        [NMS(Index = 131)]
        /* 0x00A0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        [NMS(Index = 128)]
        /* 0x00F0 */ public GcScanEffectData FrigateHologramScanEffect;
        [NMS(Index = 127)]
        /* 0x0140 */ public GcScanEffectData FrigateScanEffect;
        [NMS(Index = 0)]
        /* 0x0190 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        [NMS(Index = 1)]
        /* 0x01A0 */ public Vector3f PirateFreighterCustomiserSunAngleAdjust;
        [NMS(Index = 124)]
        /* 0x01B0 */ public GcFrigateStatsByClass FrigateInitialStats;
        [NMS(Index = 123)]
        /* 0x05C0 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        [NMS(Index = 97)]
        /* 0x0930 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Index = 55, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0A70 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        [NMS(Index = 126)]
        /* 0x0B78 */ public GcFrigateTraitIcons NegativeTraitIcons;
        [NMS(Index = 125)]
        /* 0x0C28 */ public GcFrigateTraitIcons TraitIcons;
        [NMS(Index = 2)]
        /* 0x0CD8 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        [NMS(Index = 114)]
        /* 0x0CF8 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        [NMS(Index = 77)]
        /* 0x0D18 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        [NMS(Index = 78)]
        /* 0x0D38 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        [NMS(Index = 19)]
        /* 0x0D58 */ public NMSString0x20A FleetCommunicationOSDMessage;
        [NMS(Index = 115)]
        /* 0x0D78 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        [NMS(Index = 116)]
        /* 0x0D98 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        [NMS(Index = 82)]
        /* 0x0DB8 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Index = 81)]
        /* 0x0DD8 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        [NMS(Index = 79)]
        /* 0x0DF8 */ public NMSString0x20A NeedFrigatesPuzzleID;
        [NMS(Index = 80)]
        /* 0x0E18 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        [NMS(Index = 75)]
        /* 0x0E38 */ public NMSString0x20A NormandyActivePuzzleID;
        [NMS(Index = 76)]
        /* 0x0E58 */ public NMSString0x20A NormandyDebriefPuzzleID;
        [NMS(Index = 83)]
        /* 0x0E78 */ public NMSString0x20A SelectExpeditionPuzzleID;
        [NMS(Index = 73)]
        /* 0x0E98 */ public NMSString0x20A TerminalActivePuzzleID;
        [NMS(Index = 72)]
        /* 0x0EB8 */ public NMSString0x20A TerminalDamagePuzzleID;
        [NMS(Index = 74)]
        /* 0x0ED8 */ public NMSString0x20A TerminalDebriefPuzzleID;
        [NMS(Index = 71)]
        /* 0x0EF8 */ public NMSString0x20A TerminalInterventionPuzzleID;
        [NMS(Index = 70)]
        /* 0x0F18 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        [NMS(Index = 54)]
        /* 0x0F38 */ public GcNumberedTextList FrigateBadMoods;
        [NMS(Index = 52)]
        /* 0x0F50 */ public GcNumberedTextList FrigateDamageDescriptions;
        [NMS(Index = 56)]
        /* 0x0F68 */ public GcNumberedTextList FrigateExtraNotes;
        [NMS(Index = 53)]
        /* 0x0F80 */ public GcNumberedTextList FrigateGoodMoods;
        [NMS(Index = 15)]
        /* 0x0F98 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        [NMS(Index = 118)]
        /* 0x0FA8 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        [NMS(Index = 144)]
        /* 0x0FB8 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        [NMS(Index = 143)]
        /* 0x0FC8 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        [NMS(Index = 117)]
        /* 0x0FD8 */ public List<int> DifficultyModifier;
        [NMS(Index = 137)]
        /* 0x0FE8 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        [NMS(Index = 135)]
        /* 0x0FF8 */ public List<int> ExpeditionRankBoundaries;
        [NMS(Index = 96)]
        /* 0x1008 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        [NMS(Index = 145)]
        /* 0x1018 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        [NMS(Index = 133)]
        /* 0x1028 */ public List<VariableSizeString> FrigateHologramModels;
        [NMS(Index = 138)]
        /* 0x1038 */ public List<VariableSizeString> FrigateInteriorsToCache;
        [NMS(Index = 136)]
        /* 0x1048 */ public List<int> FrigateLevelVictoriesRequired;
        [NMS(Index = 134)]
        /* 0x1058 */ public List<VariableSizeString> FrigatePlanetModels;
        [NMS(Index = 142)]
        /* 0x1068 */ public List<NMSString0x10> GhostShipFrigateTraits;
        [NMS(Index = 141)]
        /* 0x1078 */ public List<NMSString0x10> NormandyTraits;
        [NMS(Index = 98)]
        /* 0x1088 */ public List<GcExpeditionPowerup> Powerups;
        [NMS(Index = 30)]
        /* 0x1098 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        [NMS(Index = 132)]
        /* 0x10A8 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Index = 120)]
        /* 0x110C */ public GcFrigateClassCost FrigateBaseCost;
        [NMS(Index = 121)]
        /* 0x1134 */ public GcFrigateClassCost FrigateCostVariance;
        [NMS(Index = 119)]
        /* 0x115C */ public GcExpeditionDurationValues ExpeditionDurations;
        [NMS(Index = 17)]
        /* 0x1170 */ public GcInteractionDof FleetInteractionDepthOfField;
        [NMS(Index = 122)]
        /* 0x1184 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        [NMS(Index = 49)]
        /* 0x1194 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        [NMS(Index = 28)]
        /* 0x119C */ public float CameraPauseAfterStartingExpedition;
        [NMS(Index = 12)]
        /* 0x11A0 */ public float CombatDefenderSpawnDelay;
        [NMS(Index = 10)]
        /* 0x11A4 */ public float CombatFrigateSpawnAngle;
        [NMS(Index = 9)]
        /* 0x11A8 */ public float CombatFrigateSpawnMinRange;
        [NMS(Index = 11)]
        /* 0x11AC */ public float CombatNotificationTime;
        [NMS(Index = 14)]
        /* 0x11B0 */ public float CombatSpawnDelay;
        [NMS(Index = 45)]
        /* 0x11B4 */ public float DamagedListEntryPulseRate;
        [NMS(Index = 66)]
        /* 0x11B8 */ public float DespawnDelay;
        [NMS(Index = 67)]
        /* 0x11BC */ public float DespawnDelayIncreasePerFrigate;
        [NMS(Index = 104)]
        /* 0x11C0 */ public float DifficultyMultiplierForBalancedExpeditions;
        [NMS(Index = 105)]
        /* 0x11C4 */ public float DifficultyMultiplierForNonPrimaryEvents;
        [NMS(Index = 8)]
        /* 0x11C8 */ public float DistanceForPurchaseReset;
        [NMS(Index = 7)]
        /* 0x11CC */ public float DistanceForSingleShipFlybyCommsReset;
        [NMS(Index = 86)]
        /* 0x11D0 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        [NMS(Index = 85)]
        /* 0x11D4 */ public int ExpeditionDifficultyVariance;
        [NMS(Index = 16)]
        /* 0x11D8 */ public int ExplorationPointsRequiredForScan;
        [NMS(Index = 101)]
        /* 0x11DC */ public int FirstEventIndexWhichCanBeIntervention;
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
        /* 0x11E0 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        [NMS(Index = 41)]
        /* 0x11E4 */ public int ForcedSequentialEventsStartingIndex;
        [NMS(Index = 99)]
        /* 0x11E8 */ public int FreighterTokenMinimumSpend;
        [NMS(Index = 24)]
        /* 0x11EC */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        [NMS(Index = 68)]
        /* 0x11F0 */ public float FrigatesPerSecondForInstantSpawn;
        [NMS(Index = 69)]
        /* 0x11F4 */ public float HologramSwapSpeed;
        [NMS(Index = 43)]
        /* 0x11F8 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        [NMS(Index = 93)]
        /* 0x11FC */ public int LightYearsPerExpeditionEvent;
        [NMS(Index = 92)]
        /* 0x1200 */ public int LightYearsPerExpeditionEvent_Easy;
        [NMS(Index = 47)]
        /* 0x1204 */ public int LowDamageNumberOfExpeditions;
        [NMS(Index = 103)]
        /* 0x1208 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        [NMS(Index = 88)]
        /* 0x120C */ public int MaxExpeditionStatValue;
        [NMS(Index = 23)]
        /* 0x1210 */ public float MaxFrigateDistanceFromFreighter;
        [NMS(Index = 21)]
        /* 0x1214 */ public int MaxFrigateStatValue;
        [NMS(Index = 108)]
        /* 0x1218 */ public int MaxGapBetweenExpeditionLogEntries;
        [NMS(Index = 26)]
        /* 0x121C */ public int MaximumSpeedDecrease;
        [NMS(Index = 27)]
        /* 0x1220 */ public int MaximumSpeedIncrease;
        [NMS(Index = 146)]
        /* 0x1224 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
        [NMS(Index = 3)]
        /* 0x1228 */ public float MaxPurchaseDistance;
        [NMS(Index = 87)]
        /* 0x122C */ public int MinExpeditionStatValue;
        [NMS(Index = 22)]
        /* 0x1230 */ public float MinFrigateDistanceFromFreighter;
        [NMS(Index = 20)]
        /* 0x1234 */ public int MinFrigateStatValue;
        [NMS(Index = 107)]
        /* 0x1238 */ public int MinGapBetweenExpeditionLogEntries;
        [NMS(Index = 42)]
        /* 0x123C */ public int NextDebriefDescriptionOffset;
        [NMS(Index = 46)]
        /* 0x1240 */ public float NonUrgentDamagedListEntryAlpha;
        [NMS(Index = 140)]
        /* 0x1244 */ public int NormandyDamageEvents;
        [NMS(Index = 139)]
        /* 0x1248 */ public int NormandyFailures;
        [NMS(Index = 84)]
        /* 0x124C */ public int NumberOfExpeditionChoices;
        [NMS(Index = 89)]
        /* 0x1250 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        [NMS(Index = 34)]
        /* 0x1254 */ public int NumberOfShipsInInitialFleet;
        [NMS(Index = 94)]
        /* 0x1258 */ public int NumberOfUAChangesPerExpeditionEvent;
        [NMS(Index = 37)]
        /* 0x125C */ public int OverrideExpeditionSecondsPerDay;
        [NMS(Index = 25)]
        /* 0x1260 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        [NMS(Index = 50)]
        /* 0x1264 */ public int PercentChanceOfGenericEventDescription;
        [NMS(Index = 100)]
        /* 0x1268 */ public int PercentChanceOfInterventionEvent;
        [NMS(Index = 51)]
        /* 0x126C */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        [NMS(Index = 18)]
        /* 0x1270 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Index = 13)]
        /* 0x1274 */ public float PostCombatSpawnDelay;
        [NMS(Index = 60)]
        /* 0x1278 */ public float PostFreighterWarpSpawnDelayForFleetFrigates;
        [NMS(Index = 59)]
        /* 0x127C */ public float PreFreighterWarpDepawnDelayForFleetFrigates;
        [NMS(Index = 57)]
        /* 0x1280 */ public float RadiusRequiredForFrigateSpawn;
        [NMS(Index = 48)]
        /* 0x1284 */ public int RampDamageNumberOfExpeditions;
        [NMS(Index = 4)]
        /* 0x1288 */ public float SingleShipFlybyDistance;
        [NMS(Index = 6)]
        /* 0x128C */ public float SingleShipFlybyHeightOffset;
        [NMS(Index = 5)]
        /* 0x1290 */ public float SingleShipFlybyMaxAngle;
        [NMS(Index = 61)]
        /* 0x1294 */ public float SpawnDelayForFleetFrigates;
        [NMS(Index = 58)]
        /* 0x1298 */ public float SpawnDelayForNewFrigates;
        [NMS(Index = 62)]
        /* 0x129C */ public float SpawnDelayForReturningFrigates;
        [NMS(Index = 65)]
        /* 0x12A0 */ public float SpawnDelayIncreasePerFrigate;
        [NMS(Index = 64)]
        /* 0x12A4 */ public float SpawnDelayRandomMax;
        [NMS(Index = 63)]
        /* 0x12A8 */ public float SpawnDelayRandomMin;
        [NMS(Index = 106)]
        /* 0x12AC */ public int StatPointsAwardedForLevelUp;
        [NMS(Index = 112)]
        /* 0x12B0 */ public float TimeBeforeDebriefLogsStart;
        [NMS(Index = 33)]
        /* 0x12B4 */ public float TimeBeforeHidingHangar;
        [NMS(Index = 44)]
        /* 0x12B8 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        [NMS(Index = 102)]
        /* 0x12BC */ public float TimeBeforePlayerAlertedToInterventionEvent;
        [NMS(Index = 32)]
        /* 0x12C0 */ public float TimeBeforeShowingHangar;
        [NMS(Index = 109)]
        /* 0x12C4 */ public float TimeBetweenDebriefLettersAppearing;
        [NMS(Index = 111)]
        /* 0x12C8 */ public float TimeBetweenDebriefLogsAppearing;
        [NMS(Index = 110)]
        /* 0x12CC */ public float TimeBetweenDebriefLogSectionsAppearing;
        [NMS(Index = 95)]
        /* 0x12D0 */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Index = 91)]
        /* 0x12D4 */ public int TimeTakenForExpeditionEvent;
        [NMS(Index = 90)]
        /* 0x12D8 */ public int TimeTakenForExpeditionEvent_Easy;
        [NMS(Index = 29)]
        /* 0x12DC */ public float UITraitLinesAngle;
        [NMS(Index = 31, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x12E0 */ public NMSString0x20[] RacialTermForCaptain;
        [NMS(Index = 39)]
        /* 0x1400 */ public bool DisablePlayerFleets;
        [NMS(Index = 36)]
        /* 0x1401 */ public bool ExpeditionsCompleteInstantly;
        [NMS(Index = 35)]
        /* 0x1402 */ public bool NewFrigatesStartDamaged;
        [NMS(Index = 113)]
        /* 0x1403 */ public bool ShowMissingRewardDescriptions;
        [NMS(Index = 38)]
        /* 0x1404 */ public bool ShowSeeds;
    }
}

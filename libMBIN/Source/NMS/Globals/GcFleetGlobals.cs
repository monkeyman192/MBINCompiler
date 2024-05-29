using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x3A16DD72D72A1F7A, NameHash = 0xB032629C37506E6A)]
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
        /* 0x05C0 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        [NMS(Index = 96)]
        /* 0x0930 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        [NMS(Index = 2)]
        /* 0x0A70 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        [NMS(Index = 113)]
        /* 0x0A90 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        [NMS(Index = 76)]
        /* 0x0AB0 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        [NMS(Index = 77)]
        /* 0x0AD0 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        [NMS(Index = 19)]
        /* 0x0AF0 */ public NMSString0x20A FleetCommunicationOSDMessage;
        [NMS(Index = 114)]
        /* 0x0B10 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        [NMS(Index = 115)]
        /* 0x0B30 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        [NMS(Index = 81)]
        /* 0x0B50 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        [NMS(Index = 80)]
        /* 0x0B70 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        [NMS(Index = 78)]
        /* 0x0B90 */ public NMSString0x20A NeedFrigatesPuzzleID;
        [NMS(Index = 79)]
        /* 0x0BB0 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        [NMS(Index = 74)]
        /* 0x0BD0 */ public NMSString0x20A NormandyActivePuzzleID;
        [NMS(Index = 75)]
        /* 0x0BF0 */ public NMSString0x20A NormandyDebriefPuzzleID;
        [NMS(Index = 73)]
        /* 0x0C10 */ public NMSString0x20A NormandyInterventionPuzzleID;
        [NMS(Index = 82)]
        /* 0x0C30 */ public NMSString0x20A SelectExpeditionPuzzleID;
        [NMS(Index = 71)]
        /* 0x0C50 */ public NMSString0x20A TerminalActivePuzzleID;
        [NMS(Index = 70)]
        /* 0x0C70 */ public NMSString0x20A TerminalDamagePuzzleID;
        [NMS(Index = 72)]
        /* 0x0C90 */ public NMSString0x20A TerminalDebriefPuzzleID;
        [NMS(Index = 69)]
        /* 0x0CB0 */ public NMSString0x20A TerminalInterventionPuzzleID;
        [NMS(Index = 68)]
        /* 0x0CD0 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        [NMS(Index = 15)]
        /* 0x0CF0 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        [NMS(Index = 117)]
        /* 0x0D00 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        [NMS(Index = 143)]
        /* 0x0D10 */ public List<NMSString0x10> DeepSpaceCommonPrimaryTraits;
        [NMS(Index = 142)]
        /* 0x0D20 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
        [NMS(Index = 116)]
        /* 0x0D30 */ public List<int> DifficultyModifier;
        [NMS(Index = 136)]
        /* 0x0D40 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        [NMS(Index = 134)]
        /* 0x0D50 */ public List<int> ExpeditionRankBoundaries;
        [NMS(Index = 95)]
        /* 0x0D60 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        [NMS(Index = 144)]
        /* 0x0D70 */ public List<NMSString0x20> FrigateCaptainPuzzleIds;
        [NMS(Index = 132)]
        /* 0x0D80 */ public List<NMSString0x80> FrigateHologramModels;
        [NMS(Index = 137)]
        /* 0x0D90 */ public List<NMSString0x80> FrigateInteriorsToCache;
        [NMS(Index = 135)]
        /* 0x0DA0 */ public List<int> FrigateLevelVictoriesRequired;
        [NMS(Index = 133)]
        /* 0x0DB0 */ public List<NMSString0x80> FrigatePlanetModels;
        [NMS(Index = 141)]
        /* 0x0DC0 */ public List<NMSString0x10> GhostShipFrigateTraits;
        [NMS(Index = 140)]
        /* 0x0DD0 */ public List<NMSString0x10> NormandyTraits;
        [NMS(Index = 97)]
        /* 0x0DE0 */ public List<GcExpeditionPowerup> Powerups;
        [NMS(Index = 30)]
        /* 0x0DF0 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        [NMS(Index = 55, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0E00 */ public GcNumberedTextList[] DeepSpaceFrigateMoods;
        [NMS(Index = 131)]
        /* 0x0F8C */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        [NMS(Index = 119)]
        /* 0x0FF0 */ public GcFrigateClassCost FrigateBaseCost;
        [NMS(Index = 120)]
        /* 0x1018 */ public GcFrigateClassCost FrigateCostVariance;
        [NMS(Index = 54)]
        /* 0x1040 */ public GcNumberedTextList FrigateBadMoods;
        [NMS(Index = 52)]
        /* 0x1064 */ public GcNumberedTextList FrigateDamageDescriptions;
        [NMS(Index = 56)]
        /* 0x1088 */ public GcNumberedTextList FrigateExtraNotes;
        [NMS(Index = 53)]
        /* 0x10AC */ public GcNumberedTextList FrigateGoodMoods;
        [NMS(Index = 118)]
        /* 0x10D0 */ public GcExpeditionDurationValues ExpeditionDurations;
        [NMS(Index = 17)]
        /* 0x10E4 */ public GcInteractionDof FleetInteractionDepthOfField;
        [NMS(Index = 121)]
        /* 0x10F8 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        [NMS(Index = 49)]
        /* 0x1108 */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        [NMS(Index = 28)]
        /* 0x1110 */ public float CameraPauseAfterStartingExpedition;
        [NMS(Index = 12)]
        /* 0x1114 */ public float CombatDefenderSpawnDelay;
        [NMS(Index = 10)]
        /* 0x1118 */ public float CombatFrigateSpawnAngle;
        [NMS(Index = 9)]
        /* 0x111C */ public float CombatFrigateSpawnMinRange;
        [NMS(Index = 11)]
        /* 0x1120 */ public float CombatNotificationTime;
        [NMS(Index = 14)]
        /* 0x1124 */ public float CombatSpawnDelay;
        [NMS(Index = 45)]
        /* 0x1128 */ public float DamagedListEntryPulseRate;
        [NMS(Index = 64)]
        /* 0x112C */ public float DespawnDelay;
        [NMS(Index = 65)]
        /* 0x1130 */ public float DespawnDelayIncreasePerFrigate;
        [NMS(Index = 103)]
        /* 0x1134 */ public float DifficultyMultiplierForBalancedExpeditions;
        [NMS(Index = 104)]
        /* 0x1138 */ public float DifficultyMultiplierForNonPrimaryEvents;
        [NMS(Index = 8)]
        /* 0x113C */ public float DistanceForPurchaseReset;
        [NMS(Index = 7)]
        /* 0x1140 */ public float DistanceForSingleShipFlybyCommsReset;
        [NMS(Index = 85)]
        /* 0x1144 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        [NMS(Index = 84)]
        /* 0x1148 */ public int ExpeditionDifficultyVariance;
        [NMS(Index = 16)]
        /* 0x114C */ public int ExplorationPointsRequiredForScan;
        [NMS(Index = 100)]
        /* 0x1150 */ public int FirstEventIndexWhichCanBeIntervention;
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
        /* 0x1154 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        [NMS(Index = 41)]
        /* 0x1158 */ public int ForcedSequentialEventsStartingIndex;
        [NMS(Index = 98)]
        /* 0x115C */ public int FreighterTokenMinimumSpend;
        [NMS(Index = 24)]
        /* 0x1160 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        [NMS(Index = 66)]
        /* 0x1164 */ public float FrigatesPerSecondForInstantSpawn;
        [NMS(Index = 67)]
        /* 0x1168 */ public float HologramSwapSpeed;
        [NMS(Index = 43)]
        /* 0x116C */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        [NMS(Index = 92)]
        /* 0x1170 */ public int LightYearsPerExpeditionEvent;
        [NMS(Index = 91)]
        /* 0x1174 */ public int LightYearsPerExpeditionEvent_Easy;
        [NMS(Index = 47)]
        /* 0x1178 */ public int LowDamageNumberOfExpeditions;
        [NMS(Index = 102)]
        /* 0x117C */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        [NMS(Index = 87)]
        /* 0x1180 */ public int MaxExpeditionStatValue;
        [NMS(Index = 23)]
        /* 0x1184 */ public float MaxFrigateDistanceFromFreighter;
        [NMS(Index = 21)]
        /* 0x1188 */ public int MaxFrigateStatValue;
        [NMS(Index = 107)]
        /* 0x118C */ public int MaxGapBetweenExpeditionLogEntries;
        [NMS(Index = 26)]
        /* 0x1190 */ public int MaximumSpeedDecrease;
        [NMS(Index = 27)]
        /* 0x1194 */ public int MaximumSpeedIncrease;
        [NMS(Index = 145)]
        /* 0x1198 */ public int MaxNumberOfPlayerShipsInFreighterHangar;
        [NMS(Index = 3)]
        /* 0x119C */ public float MaxPurchaseDistance;
        [NMS(Index = 86)]
        /* 0x11A0 */ public int MinExpeditionStatValue;
        [NMS(Index = 22)]
        /* 0x11A4 */ public float MinFrigateDistanceFromFreighter;
        [NMS(Index = 20)]
        /* 0x11A8 */ public int MinFrigateStatValue;
        [NMS(Index = 106)]
        /* 0x11AC */ public int MinGapBetweenExpeditionLogEntries;
        [NMS(Index = 42)]
        /* 0x11B0 */ public int NextDebriefDescriptionOffset;
        [NMS(Index = 46)]
        /* 0x11B4 */ public float NonUrgentDamagedListEntryAlpha;
        [NMS(Index = 139)]
        /* 0x11B8 */ public int NormandyDamageEvents;
        [NMS(Index = 138)]
        /* 0x11BC */ public int NormandyFailures;
        [NMS(Index = 83)]
        /* 0x11C0 */ public int NumberOfExpeditionChoices;
        [NMS(Index = 88)]
        /* 0x11C4 */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        [NMS(Index = 34)]
        /* 0x11C8 */ public int NumberOfShipsInInitialFleet;
        [NMS(Index = 93)]
        /* 0x11CC */ public int NumberOfUAChangesPerExpeditionEvent;
        [NMS(Index = 37)]
        /* 0x11D0 */ public int OverrideExpeditionSecondsPerDay;
        [NMS(Index = 25)]
        /* 0x11D4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        [NMS(Index = 50)]
        /* 0x11D8 */ public int PercentChanceOfGenericEventDescription;
        [NMS(Index = 99)]
        /* 0x11DC */ public int PercentChanceOfInterventionEvent;
        [NMS(Index = 51)]
        /* 0x11E0 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        [NMS(Index = 18)]
        /* 0x11E4 */ public int PercentChangeOfFrigateBeingPurchasable;
        [NMS(Index = 13)]
        /* 0x11E8 */ public float PostCombatSpawnDelay;
        [NMS(Index = 57)]
        /* 0x11EC */ public float RadiusRequiredForFrigateSpawn;
        [NMS(Index = 48)]
        /* 0x11F0 */ public int RampDamageNumberOfExpeditions;
        [NMS(Index = 4)]
        /* 0x11F4 */ public float SingleShipFlybyDistance;
        [NMS(Index = 6)]
        /* 0x11F8 */ public float SingleShipFlybyHeightOffset;
        [NMS(Index = 5)]
        /* 0x11FC */ public float SingleShipFlybyMaxAngle;
        [NMS(Index = 59)]
        /* 0x1200 */ public float SpawnDelayForFleetFrigates;
        [NMS(Index = 58)]
        /* 0x1204 */ public float SpawnDelayForNewFrigates;
        [NMS(Index = 60)]
        /* 0x1208 */ public float SpawnDelayForReturningFrigates;
        [NMS(Index = 63)]
        /* 0x120C */ public float SpawnDelayIncreasePerFrigate;
        [NMS(Index = 62)]
        /* 0x1210 */ public float SpawnDelayRandomMax;
        [NMS(Index = 61)]
        /* 0x1214 */ public float SpawnDelayRandomMin;
        [NMS(Index = 105)]
        /* 0x1218 */ public int StatPointsAwardedForLevelUp;
        [NMS(Index = 111)]
        /* 0x121C */ public float TimeBeforeDebriefLogsStart;
        [NMS(Index = 33)]
        /* 0x1220 */ public float TimeBeforeHidingHangar;
        [NMS(Index = 44)]
        /* 0x1224 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        [NMS(Index = 101)]
        /* 0x1228 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        [NMS(Index = 32)]
        /* 0x122C */ public float TimeBeforeShowingHangar;
        [NMS(Index = 108)]
        /* 0x1230 */ public float TimeBetweenDebriefLettersAppearing;
        [NMS(Index = 110)]
        /* 0x1234 */ public float TimeBetweenDebriefLogsAppearing;
        [NMS(Index = 109)]
        /* 0x1238 */ public float TimeBetweenDebriefLogSectionsAppearing;
        [NMS(Index = 94)]
        /* 0x123C */ public int TimeBetweenPassiveIncomeTicks;
        [NMS(Index = 90)]
        /* 0x1240 */ public int TimeTakenForExpeditionEvent;
        [NMS(Index = 89)]
        /* 0x1244 */ public int TimeTakenForExpeditionEvent_Easy;
        [NMS(Index = 29)]
        /* 0x1248 */ public float UITraitLinesAngle;
        [NMS(Index = 125)]
        /* 0x124C */ public GcFrigateTraitIcons NegativeTraitIcons;
        [NMS(Index = 124)]
        /* 0x17CC */ public GcFrigateTraitIcons TraitIcons;
        [NMS(Index = 31, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1D4C */ public NMSString0x20[] RacialTermForCaptain;
        [NMS(Index = 39)]
        /* 0x1E6C */ public bool DisablePlayerFleets;
        [NMS(Index = 36)]
        /* 0x1E6D */ public bool ExpeditionsCompleteInstantly;
        [NMS(Index = 35)]
        /* 0x1E6E */ public bool NewFrigatesStartDamaged;
        [NMS(Index = 112)]
        /* 0x1E6F */ public bool ShowMissingRewardDescriptions;
        [NMS(Index = 38)]
        /* 0x1E70 */ public bool ShowSeeds;
    }
}

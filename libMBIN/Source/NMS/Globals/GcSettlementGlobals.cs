using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xBD3DB884EEA3FB52, NameHash = 0xCDDCFCB7)]
    public class GcSettlementGlobals : NMSTemplate
    {
        [NMS(Index = 52)]
        /* 0x0000 */ public Colour NegativeStatColour;
        [NMS(Index = 51)]
        /* 0x0010 */ public Colour PositiveStatColour;
        [NMS(Index = 24, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0020 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        [NMS(Index = 22, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x6A70 */ public GcSettlementBuildingContribution[] SettlementBuildingContributions;
        [NMS(Index = 20, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x7A30 */ public NMSString0x20A[] BuildingProductionNotes;
        [NMS(Index = 21, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x8210 */ public NMSString0x20A[] BuildingUpgradePageNames;
        [NMS(Index = 75, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x89F0 */ public NMSString0x20A[] SettlementBuildingClassGenericRequirement;
        [NMS(Index = 74, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x91D0 */ public NMSString0x20A[] SettlementBuildingClassGenericTitle;
        [NMS(Index = 23, Size = 0x3F, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x99B0 */ public ulong[] SettlementBuildingTimes;
        [NMS(Index = 79, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9BA8 */ public NMSString0x20A[] JudgementMissionObjectives;
        [NMS(Index = 77, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9D28 */ public NMSString0x20A[] JudgementUpdateMainText;
        [NMS(Index = 78, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9EA8 */ public NMSString0x20A[] JudgementUpdateSubtitles;
        [NMS(Index = 76, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0xA028 */ public NMSString0x20A[] JudgementUpdateTitles;
        [NMS(Index = 92, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA1A8 */ public NMSString0x20A[] LongAltResearchLocIDs;
        [NMS(Index = 88, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA2A8 */ public NMSString0x20A[] LongPolicyLocIDs;
        [NMS(Index = 90, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA3A8 */ public NMSString0x20A[] LongResearchLocIDs;
        [NMS(Index = 85, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA4A8 */ public NMSString0x20A[] NegativeFakePerkOSDLocIDs;
        [NMS(Index = 81, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA5A8 */ public NMSString0x20A[] NegativeStatChangeOSDLocIDs;
        [NMS(Index = 84, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA6A8 */ public NMSString0x20A[] PositiveFakePerkOSDLocIDs;
        [NMS(Index = 80, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA7A8 */ public NMSString0x20A[] PositiveStatChangeOSDLocIDs;
        [NMS(Index = 86, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA8A8 */ public NMSString0x20A[] ProcPerkDescriptions;
        [NMS(Index = 91, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA9A8 */ public NMSString0x20A[] ShortAltResearchLocIDs;
        [NMS(Index = 87, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAAA8 */ public NMSString0x20A[] ShortPolicyLocIDs;
        [NMS(Index = 89, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABA8 */ public NMSString0x20A[] ShortResearchLocIDs;
        [NMS(Index = 68, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xACA8 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Index = 83, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAD28 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Index = 66, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xADA8 */ public NMSString0x10[] PolicyPerks;
        [NMS(Index = 82, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAE28 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Index = 67, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAEA8 */ public NMSString0x10[] ResearchPerks;
        [NMS(Index = 0)]
        /* 0xAF28 */ public GcScanToRevealComponentData BuilderNPCScanToRevealData;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcSettlementTowerPower.SettlementTowerPowerEnum))]
        /* 0xAF88 */ public ulong[] TowerPowerRechargeTime;
        [NMS(Index = 96)]
        /* 0xAFA8 */ public List<GcSettlementGiftDetails> AutophageGifts;
        [NMS(Index = 73)]
        /* 0xAFB8 */ public List<GcSettlementProductionElement> AutophageProductionElementsSelectable;
        [NMS(Index = 26)]
        /* 0xAFC8 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        [NMS(Index = 93)]
        /* 0xAFD8 */ public List<GcSettlementGiftDetails> GekGifts;
        [NMS(Index = 70)]
        /* 0xAFE8 */ public List<GcSettlementProductionElement> GekProductionElementsSelectable;
        [NMS(Index = 97)]
        /* 0xAFF8 */ public List<GcSettlementGiftDetails> Gifts;
        [NMS(Index = 99)]
        /* 0xB008 */ public List<GcSettlementJobDetails> JobTypes;
        [NMS(Index = 25)]
        /* 0xB018 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Index = 14)]
        /* 0xB028 */ public NMSString0x10 JudgementTextHashID;
        [NMS(Index = 94)]
        /* 0xB038 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        [NMS(Index = 71)]
        /* 0xB048 */ public List<GcSettlementProductionElement> KorvaxProductionElementsSelectable;
        [NMS(Index = 18)]
        /* 0xB058 */ public NMSString0x10 MiniMissionFailJudgement;
        [NMS(Index = 17)]
        /* 0xB068 */ public NMSString0x10 MiniMissionSuccessJudgement;
        [NMS(Index = 1)]
        /* 0xB078 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        [NMS(Index = 30)]
        /* 0xB088 */ public NMSString0x10 SettlementCostAutophage;
        [NMS(Index = 27)]
        /* 0xB098 */ public NMSString0x10 SettlementCostGek;
        [NMS(Index = 28)]
        /* 0xB0A8 */ public NMSString0x10 SettlementCostKorvax;
        [NMS(Index = 29)]
        /* 0xB0B8 */ public NMSString0x10 SettlementCostVykeen;
        [NMS(Index = 16)]
        /* 0xB0C8 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        [NMS(Index = 98)]
        /* 0xB0D8 */ public List<NMSString0x10> TechGiftPerks;
        [NMS(Index = 95)]
        /* 0xB0E8 */ public List<GcSettlementGiftDetails> VykeenGifts;
        [NMS(Index = 72)]
        /* 0xB0F8 */ public List<GcSettlementProductionElement> VykeenProductionElementsSelectable;
        [NMS(Index = 56)]
        /* 0xB108 */ public ulong AlertCycleDurationInSeconds;
        [NMS(Index = 57)]
        /* 0xB110 */ public ulong BugAttackCycleDurationInSeconds;
        [NMS(Index = 4)]
        /* 0xB118 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        [NMS(Index = 3)]
        /* 0xB120 */ public ulong BuildingUpgradeTimeInSeconds;
        [NMS(Index = 54)]
        /* 0xB128 */ public ulong ProductionCycleDurationInSeconds;
        [NMS(Index = 53)]
        /* 0xB130 */ public ulong ProductionSlotTimerOffsetInSeconds;
        [NMS(Index = 11)]
        /* 0xB138 */ public ulong TowerRechargeTime;
        [NMS(Index = 69, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB140 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        [NMS(Index = 7, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0xB300 */ public float[] JudgementSelectionWeights;
        [NMS(Index = 47, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB330 */ public int[] InitialStatsMaxValues;
        [NMS(Index = 44, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB350 */ public int[] InitialStatsMinValues;
        [NMS(Index = 49, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB370 */ public float[] NormalisedStatBadThresholds;
        [NMS(Index = 50, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB390 */ public float[] NormalisedStatGoodThresholds;
        [NMS(Index = 64, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB3B0 */ public int[] StatProductivityContributionModifiers;
        [NMS(Index = 43, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB3D0 */ public int[] StatsMaxValues;
        [NMS(Index = 42, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB3F0 */ public int[] StatsMinValues;
        [NMS(Index = 62)]
        /* 0xB410 */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Index = 63)]
        /* 0xB414 */ public int BugAttackUnitsPerCycleRateModifier;
        [NMS(Index = 2)]
        /* 0xB418 */ public float BuildingRevealCutsceneLength;
        [NMS(Index = 61)]
        /* 0xB41C */ public int DailyDebtPaymentModifier;
        [NMS(Index = 46)]
        /* 0xB420 */ public int InitialBuildingCountMax;
        [NMS(Index = 45)]
        /* 0xB424 */ public int InitialBuildingCountMin;
        [NMS(Index = 60)]
        /* 0xB428 */ public int InitialDebtCycles;
        [NMS(Index = 8)]
        /* 0xB42C */ public float JudgementSpecificRacePartyChance;
        [NMS(Index = 6)]
        /* 0xB430 */ public int JudgementWaitTimeMax;
        [NMS(Index = 5)]
        /* 0xB434 */ public int JudgementWaitTimeMin;
        [NMS(Index = 35)]
        /* 0xB438 */ public int MaxInitialNegativePerksCount;
        [NMS(Index = 33)]
        /* 0xB43C */ public int MaxInitialPositivePerksCount;
        [NMS(Index = 9)]
        /* 0xB440 */ public int MaxNPCPopulation;
        [NMS(Index = 31)]
        /* 0xB444 */ public int MaxPerksCount;
        [NMS(Index = 34)]
        /* 0xB448 */ public int MinInitialNegativePerksCount;
        [NMS(Index = 32)]
        /* 0xB44C */ public int MinInitialPositivePerksCount;
        [NMS(Index = 38)]
        /* 0xB450 */ public int PopulationGrowthRatePerDayBad;
        [NMS(Index = 40)]
        /* 0xB454 */ public int PopulationGrowthRatePerDayGood;
        [NMS(Index = 39)]
        /* 0xB458 */ public int PopulationGrowthRatePerDayNeutral;
        [NMS(Index = 36)]
        /* 0xB45C */ public float PopulationGrowthRateThresholdBad;
        [NMS(Index = 37)]
        /* 0xB460 */ public float PopulationGrowthRateThresholdGood;
        [NMS(Index = 55)]
        /* 0xB464 */ public float ProductionBoostConversionRate;
        [NMS(Index = 58)]
        /* 0xB468 */ public int ProductUnitsPerCycleRateModifier;
        [NMS(Index = 13)]
        /* 0xB46C */ public float SettlementEntryMessageDistance;
        [NMS(Index = 19)]
        /* 0xB470 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Index = 15)]
        /* 0xB474 */ public int SettlementMiniExpeditionTime;
        [NMS(Index = 41)]
        /* 0xB478 */ public float StartingPopulationScalar;
        [NMS(Index = 59)]
        /* 0xB47C */ public int SubstanceUnitsPerCycleRateModifier;
        [NMS(Index = 48, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB480 */ public bool[] StatIsGoodWhenPositive;
        [NMS(Index = 65, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB488 */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Index = 10)]
        /* 0xB490 */ public bool DebugForceShowHiddenPerks;
    }
}

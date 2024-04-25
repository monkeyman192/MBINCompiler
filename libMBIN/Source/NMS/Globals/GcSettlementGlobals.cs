using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x19AC494C0B929E4B, NameHash = 0x8652A1B779227539)]
    public class GcSettlementGlobals : NMSTemplate
    {
        [NMS(Index = 38)]
        /* 0x0000 */ public Colour NegativeStatColour;
        [NMS(Index = 37)]
        /* 0x0010 */ public Colour PositiveStatColour;
        [NMS(Index = 16, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0020 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        [NMS(Index = 19, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x3E00 */ public GcSettlementStatChangeArray[] SettlementBuildingStatRewards;
        [NMS(Index = 15, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x4170 */ public ulong[] SettlementBuildingTimes;
        [NMS(Index = 61, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4328 */ public NMSString0x20A[] JudgementUpdateMainText;
        [NMS(Index = 62, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4408 */ public NMSString0x20A[] JudgementUpdateSubtitles;
        [NMS(Index = 60, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x44E8 */ public NMSString0x20A[] JudgementUpdateTitles;
        [NMS(Index = 75, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x45C8 */ public NMSString0x20A[] LongAltResearchLocIDs;
        [NMS(Index = 71, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x46A8 */ public NMSString0x20A[] LongPolicyLocIDs;
        [NMS(Index = 73, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4788 */ public NMSString0x20A[] LongResearchLocIDs;
        [NMS(Index = 68, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4868 */ public NMSString0x20A[] NegativeFakePerkOSDLocIDs;
        [NMS(Index = 64, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4948 */ public NMSString0x20A[] NegativeStatChangeOSDLocIDs;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4A28 */ public NMSString0x20A[] PositiveFakePerkOSDLocIDs;
        [NMS(Index = 63, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4B08 */ public NMSString0x20A[] PositiveStatChangeOSDLocIDs;
        [NMS(Index = 69, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4BE8 */ public NMSString0x20A[] ProcPerkDescriptions;
        [NMS(Index = 74, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4CC8 */ public NMSString0x20A[] ShortAltResearchLocIDs;
        [NMS(Index = 70, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4DA8 */ public NMSString0x20A[] ShortPolicyLocIDs;
        [NMS(Index = 72, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4E88 */ public NMSString0x20A[] ShortResearchLocIDs;
        [NMS(Index = 52, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4F68 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Index = 66, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4FD8 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5048 */ public NMSString0x10[] PolicyPerks;
        [NMS(Index = 65, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x50B8 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Index = 51, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5128 */ public NMSString0x10[] ResearchPerks;
        [NMS(Index = 18)]
        /* 0x5198 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        [NMS(Index = 76)]
        /* 0x51A8 */ public List<GcSettlementGiftDetails> GekGifts;
        [NMS(Index = 54)]
        /* 0x51B8 */ public List<NMSString0x10> GekProductionElements;
        [NMS(Index = 79)]
        /* 0x51C8 */ public List<GcSettlementGiftDetails> Gifts;
        [NMS(Index = 81)]
        /* 0x51D8 */ public List<GcSettlementJobDetails> JobTypes;
        [NMS(Index = 17)]
        /* 0x51E8 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Index = 77)]
        /* 0x51F8 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        [NMS(Index = 55)]
        /* 0x5208 */ public List<NMSString0x10> KorvaxProductionElements;
        [NMS(Index = 58)]
        /* 0x5218 */ public List<NMSString0x10> NeutralProductionElements;
        [NMS(Index = 57)]
        /* 0x5228 */ public List<NMSString0x10> PoorProductionElements;
        [NMS(Index = 59)]
        /* 0x5238 */ public List<NMSString0x10> RichProductionElements;
        [NMS(Index = 0)]
        /* 0x5248 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        [NMS(Index = 20)]
        /* 0x5258 */ public NMSString0x10 SettlementCostGek;
        [NMS(Index = 21)]
        /* 0x5268 */ public NMSString0x10 SettlementCostKorvax;
        [NMS(Index = 22)]
        /* 0x5278 */ public NMSString0x10 SettlementCostVykeen;
        [NMS(Index = 13)]
        /* 0x5288 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        [NMS(Index = 80)]
        /* 0x5298 */ public List<NMSString0x10> TechGiftPerks;
        [NMS(Index = 78)]
        /* 0x52A8 */ public List<GcSettlementGiftDetails> VykeenGifts;
        [NMS(Index = 56)]
        /* 0x52B8 */ public List<NMSString0x10> VykeenProductionElements;
        [NMS(Index = 41)]
        /* 0x52C8 */ public ulong AlertCycleDurationInSeconds;
        [NMS(Index = 2)]
        /* 0x52D0 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        [NMS(Index = 1)]
        /* 0x52D8 */ public ulong BuildingUpgradeTimeInSeconds;
        [NMS(Index = 40)]
        /* 0x52E0 */ public ulong ProductionCycleDurationInSeconds;
        [NMS(Index = 39)]
        /* 0x52E8 */ public ulong ProductionSlotTimerOffsetInSeconds;
        [NMS(Index = 53, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x52F0 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        [NMS(Index = 33, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5478 */ public int[] InitialStatsMaxValues;
        [NMS(Index = 30, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5494 */ public int[] InitialStatsMinValues;
        [NMS(Index = 35, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x54B0 */ public float[] NormalisedStatBadThresholds;
        [NMS(Index = 36, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x54CC */ public float[] NormalisedStatGoodThresholds;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x54E8 */ public int[] StatProductivityContributionModifiers;
        [NMS(Index = 29, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5504 */ public int[] StatsMaxValues;
        [NMS(Index = 28, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5520 */ public int[] StatsMinValues;
        [NMS(Index = 47)]
        /* 0x553C */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Index = 5)]
        /* 0x5540 */ public float BuildingJudgementPriorityChance;
        [NMS(Index = 9)]
        /* 0x5544 */ public float ConflictJudgementSelector;
        [NMS(Index = 46)]
        /* 0x5548 */ public int DailyDebtPaymentModifier;
        [NMS(Index = 32)]
        /* 0x554C */ public int InitialBuildingCountMax;
        [NMS(Index = 31)]
        /* 0x5550 */ public int InitialBuildingCountMin;
        [NMS(Index = 45)]
        /* 0x5554 */ public int InitialDebtCycles;
        [NMS(Index = 4)]
        /* 0x5558 */ public int JudgementWaitTimeMax;
        [NMS(Index = 3)]
        /* 0x555C */ public int JudgementWaitTimeMin;
        [NMS(Index = 27)]
        /* 0x5560 */ public int MaxInitialNegativePerksCount;
        [NMS(Index = 25)]
        /* 0x5564 */ public int MaxInitialPositivePerksCount;
        [NMS(Index = 10)]
        /* 0x5568 */ public int MaxNPCPopulation;
        [NMS(Index = 23)]
        /* 0x556C */ public int MaxPerksCount;
        [NMS(Index = 42)]
        /* 0x5570 */ public int MaxProductionSlotUnits;
        [NMS(Index = 26)]
        /* 0x5574 */ public int MinInitialNegativePerksCount;
        [NMS(Index = 24)]
        /* 0x5578 */ public int MinInitialPositivePerksCount;
        [NMS(Index = 7)]
        /* 0x557C */ public float PolicyJudgementSelector;
        [NMS(Index = 43)]
        /* 0x5580 */ public int ProductUnitsPerCycleRateModifier;
        [NMS(Index = 8)]
        /* 0x5584 */ public float RequestJudgementSelector;
        [NMS(Index = 12)]
        /* 0x5588 */ public float SettlementEntryMessageDistance;
        [NMS(Index = 14)]
        /* 0x558C */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Index = 44)]
        /* 0x5590 */ public int SubstanceUnitsPerCycleRateModifier;
        [NMS(Index = 6)]
        /* 0x5594 */ public float VisitorJudgementSelector;
        [NMS(Index = 34, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5598 */ public bool[] StatIsGoodWhenPositive;
        [NMS(Index = 49, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x559F */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Index = 11)]
        /* 0x55A6 */ public bool DebugForceShowHiddenPerks;
    }
}

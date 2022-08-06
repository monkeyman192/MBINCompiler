using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x5DF4C2715B3155C3, NameHash = 0x8652A1B779227539)]
    public class GcSettlementGlobals : NMSTemplate
    {
        /* 0x0000 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        /* 0x0010 */ public ulong BuildingUpgradeTimeInSeconds;
        /* 0x0018 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        /* 0x0020 */ public int JudgementWaitTimeMin;
        /* 0x0024 */ public int JudgementWaitTimeMax;
        /* 0x0028 */ public float BuildingJudgementPriorityChance;
        /* 0x002C */ public float VisitorJudgementSelector;
        /* 0x0030 */ public float PolicyJudgementSelector;
        /* 0x0034 */ public float RequestJudgementSelector;
        /* 0x0038 */ public float ConflictJudgementSelector;
        /* 0x003C */ public int MaxNPCPopulation;
        /* 0x0040 */ public bool DebugForceShowHiddenPerks;
        /* 0x0044 */ public float SettlementEntryMessageDistance;
        /* 0x0048 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        /* 0x0058 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Size = 0x34, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0060 */ public ulong[] SettlementBuildingTimes;
        [NMS(Size = 0x34, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0200 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        /* 0x3C80 */ public List<GcSettlementJudgementData> Judgements;
        /* 0x3C90 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        [NMS(Size = 0x34, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x3CA0 */ public GcSettlementStatChangeArray[] SettlementBuildingStatRewards;
        /* 0x3FE0 */ public NMSString0x10 SettlementCostGek;
        /* 0x3FF0 */ public NMSString0x10 SettlementCostKorvax;
        /* 0x4000 */ public NMSString0x10 SettlementCostVykeen;
        /* 0x4010 */ public int MaxPerksCount;
        /* 0x4014 */ public int MinInitialPositivePerksCount;
        /* 0x4018 */ public int MaxInitialPositivePerksCount;
        /* 0x401C */ public int MinInitialNegativePerksCount;
        /* 0x4020 */ public int MaxInitialNegativePerksCount;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4024 */ public int[] StatsMinValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4040 */ public int[] StatsMaxValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x405C */ public int[] InitialStatsMinValues;
        /* 0x4078 */ public int InitialBuildingCountMin;
        /* 0x407C */ public int InitialBuildingCountMax;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4080 */ public int[] InitialStatsMaxValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x409C */ public bool[] StatIsGoodWhenPositive;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x40A4 */ public float[] NormalisedStatBadThresholds;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x40C0 */ public float[] NormalisedStatGoodThresholds;
        /* 0x40E0 */ public Colour PositiveStatColour;
        /* 0x40F0 */ public Colour NegativeStatColour;
        /* 0x4100 */ public ulong ProductionSlotTimerOffsetInSeconds;
        /* 0x4108 */ public ulong ProductionCycleDurationInSeconds;
        /* 0x4110 */ public ulong AlertCycleDurationInSeconds;
        /* 0x4118 */ public int MaxProductionSlotUnits;
        /* 0x411C */ public int ProductUnitsPerCycleRateModifier;
        /* 0x4120 */ public int SubstanceUnitsPerCycleRateModifier;
        /* 0x4124 */ public int InitialDebtCycles;
        /* 0x4128 */ public int DailyDebtPaymentModifier;
        /* 0x412C */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4130 */ public int[] StatProductivityContributionModifiers;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x414C */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4158 */ public NMSString0x10[] PolicyPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x41C8 */ public NMSString0x10[] ResearchPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4238 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x42A8 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        /* 0x4430 */ public List<NMSString0x10> GekProductionElements;
        /* 0x4440 */ public List<NMSString0x10> KorvaxProductionElements;
        /* 0x4450 */ public List<NMSString0x10> VykeenProductionElements;
        /* 0x4460 */ public List<NMSString0x10> PoorProductionElements;
        /* 0x4470 */ public List<NMSString0x10> NeutralProductionElements;
        /* 0x4480 */ public List<NMSString0x10> RichProductionElements;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4490 */ public NMSString0x20[] JudgementUpdateTitles;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4570 */ public NMSString0x20[] JudgementUpdateMainText;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4650 */ public NMSString0x20[] JudgementUpdateSubtitles;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4730 */ public NMSString0x20[] PositiveStatChangeOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4810 */ public NMSString0x20[] NegativeStatChangeOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x48F0 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4960 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x49D0 */ public NMSString0x20[] PositiveFakePerkOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4AB0 */ public NMSString0x20[] NegativeFakePerkOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4B90 */ public NMSString0x20[] ProcPerkDescriptions;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4C70 */ public NMSString0x20[] ShortPolicyLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4D50 */ public NMSString0x20[] LongPolicyLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4E30 */ public NMSString0x20[] ShortResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4F10 */ public NMSString0x20[] LongResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4FF0 */ public NMSString0x20[] ShortAltResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x50D0 */ public NMSString0x20[] LongAltResearchLocIDs;
        /* 0x51B0 */ public List<GcSettlementGiftDetails> GekGifts;
        /* 0x51C0 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        /* 0x51D0 */ public List<GcSettlementGiftDetails> VykeenGifts;
        /* 0x51E0 */ public List<GcSettlementGiftDetails> Gifts;
        /* 0x51F0 */ public List<NMSString0x10> TechGiftPerks;
        /* 0x5200 */ public List<GcSettlementJobDetails> JobTypes;
    }
}

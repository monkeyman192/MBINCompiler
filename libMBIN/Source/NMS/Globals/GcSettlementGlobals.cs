using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x50C0, GUID = 0x69B5BA713F640738, NameHash = 0x8652A1B779227539)]
    public class GcSettlementGlobals : NMSTemplate
    {
        /* 0x0000 */ public ulong BuildingUpgradeTimeInSeconds;
        /* 0x0008 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        /* 0x0010 */ public int JudgementWaitTimeMin;
        /* 0x0014 */ public int JudgementWaitTimeMax;
        /* 0x0018 */ public float BuildingJudgementPriorityChance;
        /* 0x001C */ public float VisitorJudgementSelector;
        /* 0x0020 */ public float PolicyJudgementSelector;
        /* 0x0024 */ public float RequestJudgementSelector;
        /* 0x0028 */ public float ConflictJudgementSelector;
        /* 0x002C */ public int MaxNPCPopulation;
        /* 0x0030 */ public bool DebugForceShowHiddenPerks;
        /* 0x0034 */ public float SettlementEntryMessageDistance;
        /* 0x0038 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        /* 0x0048 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0050 */ public ulong[] SettlementBuildingTimes;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x01E8 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        /* 0x3B48 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Size = 0x33, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x3B58 */ public GcSettlementStatChangeArray[] SettlementBuildingStatRewards;
        /* 0x3E88 */ public NMSString0x10 SettlementCostGek;
        /* 0x3E98 */ public NMSString0x10 SettlementCostKorvax;
        /* 0x3EA8 */ public NMSString0x10 SettlementCostVykeen;
        /* 0x3EB8 */ public int MaxPerksCount;
        /* 0x3EBC */ public int MinInitialPositivePerksCount;
        /* 0x3EC0 */ public int MaxInitialPositivePerksCount;
        /* 0x3EC4 */ public int MinInitialNegativePerksCount;
        /* 0x3EC8 */ public int MaxInitialNegativePerksCount;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3ECC */ public int[] StatsMinValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3EE8 */ public int[] StatsMaxValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F04 */ public int[] InitialStatsMinValues;
        /* 0x3F20 */ public int InitialBuildingCountMin;
        /* 0x3F24 */ public int InitialBuildingCountMax;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F28 */ public int[] InitialStatsMaxValues;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F44 */ public bool[] StatIsGoodWhenPositive;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F4C */ public float[] NormalisedStatBadThresholds;
        [NMS(Size = 0x7)]
        /* 0x3F68 */ public float[] NormalisedStatGoodThresholds;
        /* 0x3F90 */ public Colour PositiveStatColour;
        /* 0x3FA0 */ public Colour NegativeStatColour;
        /* 0x3FB0 */ public ulong ProductionSlotTimerOffsetInSeconds;
        /* 0x3FB8 */ public ulong ProductionCycleDurationInSeconds;
        /* 0x3FC0 */ public ulong AlertCycleDurationInSeconds;
        /* 0x3FC8 */ public int MaxProductionSlotUnits;
        /* 0x3FCC */ public int ProductUnitsPerCycleRateModifier;
        /* 0x3FD0 */ public int SubstanceUnitsPerCycleRateModifier;
        /* 0x3FD4 */ public int InitialDebtCycles;
        /* 0x3FD8 */ public int DailyDebtPaymentModifier;
        /* 0x3FDC */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3FE0 */ public int[] StatProductivityContributionModifiers;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3FFC */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4008 */ public NMSString0x10[] PolicyPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4078 */ public NMSString0x10[] ResearchPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x40E8 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4158 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        /* 0x42E0 */ public List<NMSString0x10> GekProductionElements;
        /* 0x42F0 */ public List<NMSString0x10> KorvaxProductionElements;
        /* 0x4300 */ public List<NMSString0x10> VykeenProductionElements;
        /* 0x4310 */ public List<NMSString0x10> PoorProductionElements;
        /* 0x4320 */ public List<NMSString0x10> NeutralProductionElements;
        /* 0x4330 */ public List<NMSString0x10> RichProductionElements;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4340 */ public NMSString0x20[] JudgementUpdateTitles;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4420 */ public NMSString0x20[] JudgementUpdateMainText;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4500 */ public NMSString0x20[] JudgementUpdateSubtitles;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x45E0 */ public NMSString0x20[] PositiveStatChangeOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x46C0 */ public NMSString0x20[] NegativeStatChangeOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x47A0 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4810 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4880 */ public NMSString0x20[] PositiveFakePerkOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4960 */ public NMSString0x20[] NegativeFakePerkOSDLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4A40 */ public NMSString0x20[] ProcPerkDescriptions;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4B20 */ public NMSString0x20[] ShortPolicyLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4C00 */ public NMSString0x20[] LongPolicyLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4CE0 */ public NMSString0x20[] ShortResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4DC0 */ public NMSString0x20[] LongResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4EA0 */ public NMSString0x20[] ShortAltResearchLocIDs;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4F80 */ public NMSString0x20[] LongAltResearchLocIDs;
        /* 0x5060 */ public List<GcSettlementGiftDetails> GekGifts;
        /* 0x5070 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        /* 0x5080 */ public List<GcSettlementGiftDetails> VykeenGifts;
        /* 0x5090 */ public List<GcSettlementGiftDetails> Gifts;
        /* 0x50A0 */ public List<NMSString0x10> TechGiftPerks;
        /* 0x50B0 */ public List<GcSettlementJobDetails> JobTypes;
    }
}

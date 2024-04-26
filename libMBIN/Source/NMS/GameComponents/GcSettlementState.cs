using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AC48DB16C441070, NameHash = 0x92FAA41D8355CBAE)]
    public class GcSettlementState : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public Vector3f Position;
        [NMS(Index = 5, Size = 0x30)]
        /* 0x010 */ public ulong[] LastBuildingUpgradesTimestamps;
        [NMS(Index = 19, Size = 0x2)]
        /* 0x190 */ public GcSettlementProductionSlotData[] ProductionState;
        [NMS(Index = 9)]
        /* 0x1D0 */ public NMSString0x10 PendingCustomJudgementID;
        [NMS(Index = 11)]
        /* 0x1E0 */ public List<NMSString0x10> Perks;
        [NMS(Index = 17)]
        /* 0x1F0 */ public ulong DbTimestamp;
        [NMS(Index = 15)]
        /* 0x1F8 */ public ulong LastAlertChangeTime;
        [NMS(Index = 14)]
        /* 0x200 */ public ulong LastDebtChangeTime;
        [NMS(Index = 12)]
        /* 0x208 */ public ulong LastJudgementTime;
        [NMS(Index = 13)]
        /* 0x210 */ public ulong LastUpkeepDebtCheckTime;
        [NMS(Index = 23)]
        /* 0x218 */ public ulong NextBuildingUpgradeSeedValue;
        [NMS(Index = 3)]
        /* 0x220 */ public ulong SeedValue;
        [NMS(Index = 1)]
        /* 0x228 */ public ulong UniverseAddress;
        [NMS(Index = 7)]
        /* 0x230 */ public GcDiscoveryOwner Owner;
        [NMS(Index = 4, Size = 0x30)]
        /* 0x334 */ public int[] BuildingStates;
        [NMS(Index = 10, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F4 */ public int[] Stats;
        [NMS(Index = 18)]
        /* 0x410 */ public int DbVersion;
        [NMS(Index = 22)]
        /* 0x414 */ public GcBuildingClassification NextBuildingUpgradeClass;
        [NMS(Index = 21)]
        /* 0x418 */ public int NextBuildingUpgradeIndex;
        [NMS(Index = 8)]
        /* 0x41C */ public GcSettlementJudgementType PendingJudgementType;
        [NMS(Index = 16)]
        /* 0x420 */ public NMSString0x40 DbResourceId;
        [NMS(Index = 6)]
        /* 0x460 */ public NMSString0x40 Name;
        [NMS(Index = 0)]
        /* 0x4A0 */ public NMSString0x40 UniqueId;
        [NMS(Index = 20)]
        /* 0x4E0 */ public bool IsReported;
    }
}

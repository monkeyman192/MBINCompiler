using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AC48DB16C441070, NameHash = 0x92FAA41D8355CBAE)]
    public class GcSettlementState : NMSTemplate
    {
        /* 0x000 */ public Vector3f Position;
        [NMS(Size = 0x30)]
        /* 0x010 */ public ulong[] LastBuildingUpgradesTimestamps;
        [NMS(Size = 0x2)]
        /* 0x190 */ public GcSettlementProductionSlotData[] ProductionState;
        /* 0x1D0 */ public NMSString0x10 PendingCustomJudgementID;
        /* 0x1E0 */ public List<NMSString0x10> Perks;
        /* 0x1F0 */ public ulong DbTimestamp;
        /* 0x1F8 */ public ulong LastAlertChangeTime;
        /* 0x200 */ public ulong LastDebtChangeTime;
        /* 0x208 */ public ulong LastJudgementTime;
        /* 0x210 */ public ulong LastUpkeepDebtCheckTime;
        /* 0x218 */ public ulong NextBuildingUpgradeSeedValue;
        /* 0x220 */ public ulong SeedValue;
        /* 0x228 */ public ulong UniverseAddress;
        /* 0x230 */ public GcDiscoveryOwner Owner;
        [NMS(Size = 0x30)]
        /* 0x334 */ public int[] BuildingStates;
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x3F4 */ public int[] Stats;
        /* 0x410 */ public int DbVersion;
        /* 0x414 */ public GcBuildingClassification NextBuildingUpgradeClass;
        /* 0x418 */ public int NextBuildingUpgradeIndex;
        /* 0x41C */ public GcSettlementJudgementType PendingJudgementType;
        /* 0x420 */ public NMSString0x40 DbResourceId;
        /* 0x460 */ public NMSString0x40 Name;
        /* 0x4A0 */ public NMSString0x40 UniqueId;
        /* 0x4E0 */ public bool IsReported;
    }
}

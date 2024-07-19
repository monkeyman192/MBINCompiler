using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45562B85264EBCDB, NameHash = 0xF5D18571)]
    public class GcSeasonStateData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcInventoryContainer SeasonTransferInventory;
        [NMS(Index = 0)]
        /* 0x158 */ public List<float> MilestoneValues;
        [NMS(Index = 6)]
        /* 0x168 */ public List<GcUAProtectedLocations> ProtectedEvents;
        [NMS(Index = 4)]
        /* 0x178 */ public List<ulong> RendezvousUAs;
        [NMS(Index = 1)]
        /* 0x188 */ public List<short> RewardCollected;
        [NMS(Index = 9)]
        /* 0x198 */ public GcSeasonEndRewardsRedemptionState EndRewardsRedemptionState;
        [NMS(Index = 3)]
        /* 0x19C */ public int PinnedMilestone;
        [NMS(Index = 2)]
        /* 0x1A0 */ public int PinnedStage;
        [NMS(Index = 7)]
        /* 0x1A4 */ public GcSeasonSaveStateOnDeath StateOnDeath;
        [NMS(Index = 5)]
        /* 0x1A8 */ public bool HasCollectedFinalReward;
    }
}

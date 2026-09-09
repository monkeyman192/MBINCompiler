using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x150684163F3C525, NameHash = 0xF5D18571)]
    public class GcSeasonStateData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public GcInventoryContainer SeasonTransferInventory;
        [NMS(Index = 11)]
        /* 0x160 */ public List<ulong> AdditionalProtectedUAs;
        [NMS(Index = 0)]
        /* 0x170 */ public List<float> MilestoneValues;
        [NMS(Index = 7)]
        /* 0x180 */ public List<GcUAProtectedLocations> ProtectedEvents;
        [NMS(Index = 5)]
        /* 0x190 */ public List<GcPlayerMissionParticipant> RendezvousParticipants;
        [NMS(Index = 4)]
        /* 0x1A0 */ public List<ulong> RendezvousUAs;
        [NMS(Index = 1)]
        /* 0x1B0 */ public List<short> RewardCollected;
        [NMS(Index = 10)]
        /* 0x1C0 */ public GcSeasonEndRewardsRedemptionState EndRewardsRedemptionState;
        [NMS(Index = 3)]
        /* 0x1C4 */ public int PinnedMilestone;
        [NMS(Index = 2)]
        /* 0x1C8 */ public int PinnedStage;
        [NMS(Index = 8)]
        /* 0x1CC */ public GcSeasonSaveStateOnDeath StateOnDeath;
        [NMS(Index = 6)]
        /* 0x1D0 */ public bool HasCollectedFinalReward;
    }
}

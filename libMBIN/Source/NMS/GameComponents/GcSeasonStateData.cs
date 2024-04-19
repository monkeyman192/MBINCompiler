using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E883A1AE4717A59, NameHash = 0x4BC716CF849F5A74)]
    public class GcSeasonStateData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer SeasonTransferInventory;
        /* 0x158 */ public List<float> MilestoneValues;
        /* 0x168 */ public List<GcUAProtectedLocations> ProtectedEvents;
        /* 0x178 */ public List<ulong> RendezvousUAs;
        /* 0x188 */ public List<short> RewardCollected;
        /* 0x198 */ public GcSeasonEndRewardsRedemptionState EndRewardsRedemptionState;
        /* 0x19C */ public int PinnedMilestone;
        /* 0x1A0 */ public int PinnedStage;
        /* 0x1A4 */ public GcSeasonSaveStateOnDeath StateOnDeath;
        /* 0x1A8 */ public bool HasCollectedFinalReward;
    }
}

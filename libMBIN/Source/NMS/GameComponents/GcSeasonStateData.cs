using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50, GUID = 0x46B484536E555EE2, NameHash = 0x4BC716CF849F5A74)]
    public class GcSeasonStateData : NMSTemplate
    {
        /* 0x00 */ public List<float> MilestoneValues;
        /* 0x10 */ public List<NMSString0x20> RewardCollected;      // not sure about this... Need to see what uses this class to confirm in exe.
        /* 0x20 */ public int PinnedStage;
        /* 0x24 */ public int PinnedMilestone;
        /* 0x28 */ public List<ulong> RendezvousUAs;
        /* 0x38 */ public bool HasCollectedFinalReward;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x39 */ public byte[] Padding39;
        /* 0x40 */ public List<GcUAProtectedLocations> ProtectedEvents;
    }
}

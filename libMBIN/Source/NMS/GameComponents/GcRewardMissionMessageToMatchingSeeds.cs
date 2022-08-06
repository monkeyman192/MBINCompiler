using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88ABA39C4A0CBA4A, NameHash = 0x9688A6EC7C08672F)]
    public class GcRewardMissionMessageToMatchingSeeds : NMSTemplate
    {
        public NMSString0x10 MessageID;
        public bool BroadcastInMultiplayer;
    }
}

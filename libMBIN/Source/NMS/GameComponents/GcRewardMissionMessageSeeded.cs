using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x867F7373ED1252F6, NameHash = 0x56DEE85C9E579653)]
    public class GcRewardMissionMessageSeeded : NMSTemplate
    {
        public NMSString0x10 MessageID;
        public bool BroadcastInMultiplayer;
        public bool BroadcastToActiveMultiplayerMission;
    }
}
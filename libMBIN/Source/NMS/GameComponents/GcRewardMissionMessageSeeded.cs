using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x867F7373ED1252F6, NameHash = 0x56DEE85C9E579653)]
    public class GcRewardMissionMessageSeeded : NMSTemplate
    {
        public NMSString0x10 MessageID;
        public bool BroadcastInMultiplayer;
        public bool BroadcastToActiveMultiplayerMission;
        [NMS(Size = 0x6, Ignore = true)]
        public byte[] EndPadding;
    }
}
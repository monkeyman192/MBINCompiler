namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FA26355282BB41A, NameHash = 0x56DEE85C9E579653)]
    public class GcRewardMissionMessageSeeded : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MessageID;
        /* 0x10 */ public bool BroadcastInMultiplayer;
        /* 0x11 */ public bool BroadcastToActiveMultiplayerMission;
        /* 0x18 */ public NMSString0x10 SpecificMissionID;
    }
}

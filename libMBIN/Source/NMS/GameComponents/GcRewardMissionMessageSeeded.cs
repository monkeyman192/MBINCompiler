namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21A11FC97B380451, NameHash = 0xD144E843)]
    public class GcRewardMissionMessageSeeded : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MessageID;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 SpecificMissionID;
        [NMS(Index = 1)]
        /* 0x20 */ public bool BroadcastInMultiplayer;
        [NMS(Index = 2)]
        /* 0x21 */ public bool BroadcastToActiveMultiplayerMission;
    }
}

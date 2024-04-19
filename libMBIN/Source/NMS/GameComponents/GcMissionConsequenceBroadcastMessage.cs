namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA32C14F4E9C14167, NameHash = 0xA59C48B28345C469)]
    public class GcMissionConsequenceBroadcastMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MessageID;
        /* 0x10 */ public bool BroadcastToActiveMultiplayerMission;
        /* 0x11 */ public bool CanSendToInactive;
        /* 0x12 */ public bool Multiplayer;
        /* 0x13 */ public bool Seeded;
        /* 0x14 */ public bool SendToAllMatchingSeeds;
    }
}

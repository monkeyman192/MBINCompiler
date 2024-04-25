namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA32C14F4E9C14167, NameHash = 0xA59C48B28345C469)]
    public class GcMissionConsequenceBroadcastMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MessageID;
        [NMS(Index = 5)]
        /* 0x10 */ public bool BroadcastToActiveMultiplayerMission;
        [NMS(Index = 4)]
        /* 0x11 */ public bool CanSendToInactive;
        [NMS(Index = 3)]
        /* 0x12 */ public bool Multiplayer;
        [NMS(Index = 1)]
        /* 0x13 */ public bool Seeded;
        [NMS(Index = 2)]
        /* 0x14 */ public bool SendToAllMatchingSeeds;
    }
}

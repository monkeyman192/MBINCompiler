namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7020685B9AD15DAB, NameHash = 0x7264C46B)]
    public class GcMissionSequenceBroadcastMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 MessageID;
        [NMS(Index = 6)]
        /* 0x20 */ public bool BroadcastToActiveMultiplayerMission;
        [NMS(Index = 5)]
        /* 0x21 */ public bool CanSendToInactive;
        [NMS(Index = 4)]
        /* 0x22 */ public bool Multiplayer;
        [NMS(Index = 2)]
        /* 0x23 */ public bool Seeded;
        [NMS(Index = 3)]
        /* 0x24 */ public bool SendToAllMatchingSeeds;
    }
}

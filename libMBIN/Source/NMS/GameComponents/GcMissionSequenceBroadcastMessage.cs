namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FCFDD282C322588, NameHash = 0x60741FB7E840229E)]
    public class GcMissionSequenceBroadcastMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 MessageID;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 DebugText;
        [NMS(Index = 6)]
        /* 0x90 */ public bool BroadcastToActiveMultiplayerMission;
        [NMS(Index = 5)]
        /* 0x91 */ public bool CanSendToInactive;
        [NMS(Index = 4)]
        /* 0x92 */ public bool Multiplayer;
        [NMS(Index = 2)]
        /* 0x93 */ public bool Seeded;
        [NMS(Index = 3)]
        /* 0x94 */ public bool SendToAllMatchingSeeds;
    }
}

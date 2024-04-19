namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA4EDF6A4CF077A8D, NameHash = 0x60741FB7E840229E)]
    public class GcMissionSequenceBroadcastMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MessageID;
        /* 0x10 */ public NMSString0x80 DebugText;
        /* 0x90 */ public bool BroadcastToActiveMultiplayerMission;
        /* 0x91 */ public bool CanSendToInactive;
        /* 0x92 */ public bool Multiplayer;
        /* 0x93 */ public bool Seeded;
        /* 0x94 */ public bool SendToAllMatchingSeeds;
    }
}

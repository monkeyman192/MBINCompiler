using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9243925ED382F62, NameHash = 0x60B1E1BA)]
    public class GcBlockListPersistence : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0000 */ public int ListSize;
        [NMS(Index = 5)]
        /* 0x0004 */ public int MessageListSize;
        [NMS(Index = 4)]
        /* 0x0008 */ public int MessageNextSlot;
        [NMS(Index = 1)]
        /* 0x000C */ public int NextSlot;
        [NMS(Index = 8)]
        /* 0x0010 */ public int ReportedAllianceListSize;
        [NMS(Index = 7)]
        /* 0x0014 */ public int ReportedAllianceNextSlot;
        [NMS(Index = 6, Size = 0x64)]
        /* 0x0018 */ public GcReportedAlliance[] ReportedAllianceArray;
        [NMS(Index = 0, Size = 0x32)]
        /* 0x32E0 */ public GcBlockedUser[] BlockedUserArray;
        [NMS(Index = 3, Size = 0x32)]
        /* 0x5220 */ public GcBlockedMessage[] BlockedMessageArray;
    }
}

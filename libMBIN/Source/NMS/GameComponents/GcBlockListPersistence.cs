using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4732DC1B41CCE0B, NameHash = 0x60B1E1BA)]
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
        [NMS(Index = 0, Size = 0x32)]
        /* 0x0010 */ public GcBlockedUser[] BlockedUserArray;
        [NMS(Index = 3, Size = 0x32)]
        /* 0x1F50 */ public GcBlockedMessage[] BlockedMessageArray;
    }
}

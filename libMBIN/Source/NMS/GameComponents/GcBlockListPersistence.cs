using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6018730138103927, NameHash = 0xFD630C0F790F1BCB)]
    public class GcBlockListPersistence : NMSTemplate
    {
        /* 0x0000 */ public int ListSize;
        /* 0x0004 */ public int MessageListSize;
        /* 0x0008 */ public int MessageNextSlot;
        /* 0x000C */ public int NextSlot;
        [NMS(Size = 0x32)]
        /* 0x0010 */ public GcBlockedUser[] BlockedUserArray;
        [NMS(Size = 0x32)]
        /* 0x1F50 */ public GcBlockedMessage[] BlockedMessageArray;
    }
}

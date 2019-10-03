using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x35EAC27A312632DF, NameHash = 0xFD630C0F790F1BCB)]
    public class GcBlockListPersistence : NMSTemplate       // size: 0x3850
    {
        [NMS(Size = 0x32)]
        /* 0x0000 */ public GcBlockedUser[] BlockedUserArray;
        /* 0x1F40 */ public int NextSlot;
        /* 0x1F44 */ public int ListSize;
        [NMS(Size = 0x32)]
        /* 0x1F48 */ public GcBlockedMessage[] BlockedMessageArray;
        /* 0x3848 */ public int MessageNextSlot;
        /* 0x384C */ public int MessageListSize;
    }
}

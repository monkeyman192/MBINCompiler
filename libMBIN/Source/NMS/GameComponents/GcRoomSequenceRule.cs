using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x21E0E5F55BA9785E, NameHash = 0x836CEABBD3EE007D)]
    public class GcRoomSequenceRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RoomID;
        /* 0x10 */ public int MinRoomIndex;
        /* 0x18 */ public NMSString0x10 MustBeBeforeRoom;
        /* 0x28 */ public NMSString0x10 MustBeAfterRoom;
    }
}

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x21E0E5F55BA9785E, NameHash = 0x836CEABBD3EE007D)]
    public class GcRoomSequenceRule : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string RoomID;
        /* 0x10 */ public int MinRoomIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string MustBeBeforeRoom;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string MustBeAfterRoom;
    }
}

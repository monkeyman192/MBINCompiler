namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1B2A3B82AB3ED0D, NameHash = 0x836CEABBD3EE007D)]
    public class GcRoomSequenceRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MustBeAfterRoom;
        /* 0x10 */ public NMSString0x10 MustBeBeforeRoom;
        /* 0x20 */ public NMSString0x10 RoomID;
        /* 0x30 */ public int MinRoomIndex;
    }
}

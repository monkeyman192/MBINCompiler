namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB71F30F827058725, NameHash = 0x836CEABBD3EE007D)]
    public class GcRoomSequenceRule : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 MustBeAfterRoom;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 MustBeBeforeRoom;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 RoomID;
        [NMS(Index = 1)]
        /* 0x30 */ public int MinRoomIndex;
    }
}

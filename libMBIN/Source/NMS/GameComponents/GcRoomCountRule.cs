namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCDFCCF477FD77B55, NameHash = 0x847F4524E9703A38)]
    public class GcRoomCountRule : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 RoomID;
        [NMS(Index = 2)]
        /* 0x10 */ public int Max;
        [NMS(Index = 1)]
        /* 0x14 */ public int Min;
    }
}

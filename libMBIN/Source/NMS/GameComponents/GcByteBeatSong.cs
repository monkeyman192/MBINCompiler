namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A1695EC46335BC8, NameHash = 0xDC95ACD037A3B77)]
    public class GcByteBeatSong : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public NMSString0x20A LocID;
        [NMS(Index = 0)]
        /* 0x020 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x030 */ public NMSString0x10 RequiredSpecialId;
        [NMS(Index = 7, Size = 0x8)]
        /* 0x040 */ public NMSString0x40[] Data;
        [NMS(Index = 4)]
        /* 0x240 */ public NMSString0x40 AuthorOnlineID;
        [NMS(Index = 6)]
        /* 0x280 */ public NMSString0x40 AuthorPlatform;
        [NMS(Index = 5)]
        /* 0x2C0 */ public NMSString0x40 AuthorUsername;
        [NMS(Index = 2)]
        /* 0x300 */ public NMSString0x20 Name;
    }
}

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A1695EC46335BC8, NameHash = 0xDC95ACD037A3B77)]
    public class GcByteBeatSong : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A LocID;
        /* 0x020 */ public NMSString0x10 Id;
        /* 0x030 */ public NMSString0x10 RequiredSpecialId;
        [NMS(Size = 0x8)]
        /* 0x040 */ public NMSString0x40[] Data;
        /* 0x240 */ public NMSString0x40 AuthorOnlineID;
        /* 0x280 */ public NMSString0x40 AuthorPlatform;
        /* 0x2C0 */ public NMSString0x40 AuthorUsername;
        /* 0x300 */ public NMSString0x20 Name;
    }
}

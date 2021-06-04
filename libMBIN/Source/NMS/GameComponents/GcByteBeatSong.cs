using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x320, Alignment = 0x8, GUID = 0x9C67B4FAEE40B081, NameHash = 0xDC95ACD037A3B77)]
    public class GcByteBeatSong : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x10 RequiredSpecialId;
        /* 0x020 */ public NMSString0x20 Name;
        /* 0x040 */ public NMSString0x20A LocID;
        /* 0x060 */ public NMSString0x40 AuthorOnlineID;
        /* 0x0A0 */ public NMSString0x40 AuthorUsername;
        /* 0x0E0 */ public NMSString0x40 AuthorPlatform;
        [NMS(Size = 0x8)]
        /* 0x120 */ public NMSString0x40[] Data;
    }
}

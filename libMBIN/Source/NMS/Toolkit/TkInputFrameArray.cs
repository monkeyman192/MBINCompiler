using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC36377F46A98F6BC, NameHash = 0xA9237A301B5A6C2F)]
    public class TkInputFrameArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4E20)]
        /* 0x0 */ public TkInputFrame[] Array;
    }
}

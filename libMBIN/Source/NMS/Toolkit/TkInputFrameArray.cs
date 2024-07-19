using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x54F16995E20EF819, NameHash = 0x43297D06)]
    public class TkInputFrameArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4E20)]
        /* 0x0 */ public TkInputFrame[] Array;
    }
}

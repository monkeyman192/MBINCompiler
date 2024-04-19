using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1BCA8BCE43496244, NameHash = 0x2FAF5D4269DCB98C)]
    public class TkBlackboardDefaultValueInteger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x14 */ public int DefaultValue;
    }
}

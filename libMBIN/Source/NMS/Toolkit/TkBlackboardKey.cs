using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8947A8185E5DE602, NameHash = 0x388ED0AC2B4CA0A6)]
    public class TkBlackboardKey : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
    }
}

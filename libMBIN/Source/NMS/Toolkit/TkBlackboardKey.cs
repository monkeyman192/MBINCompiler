using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8571795995E1A0DC, NameHash = 0xFC9024A5)]
    public class TkBlackboardKey : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 0)]
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
    }
}

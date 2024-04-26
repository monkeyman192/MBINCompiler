using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8120304A040520DE, NameHash = 0x51BC6BBE6D56FC99)]
    public class TkBlackboardDefaultValueId : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 DefaultValue;
        [NMS(Index = 0)]
        /* 0x20 */ public TkBlackboardCategory BlackboardCategory;
    }
}

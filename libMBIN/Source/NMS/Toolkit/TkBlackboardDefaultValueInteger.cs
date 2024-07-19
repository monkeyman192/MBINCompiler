using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x72E36870EF87F590, NameHash = 0x1DAF38D3)]
    public class TkBlackboardDefaultValueInteger : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 0)]
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
        [NMS(Index = 2)]
        /* 0x14 */ public int DefaultValue;
    }
}

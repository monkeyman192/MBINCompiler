using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x921C7D45C4DE4835, NameHash = 0xFB06554B7F990F81)]
    public class TkBlackboardDefaultValueBool : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 0)]
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
        [NMS(Index = 2)]
        /* 0x14 */ public bool DefaultValue;
    }
}

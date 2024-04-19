using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x921C7D45C4DE4835, NameHash = 0xFB06554B7F990F81)]
    public class TkBlackboardDefaultValueBool : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x14 */ public bool DefaultValue;
    }
}

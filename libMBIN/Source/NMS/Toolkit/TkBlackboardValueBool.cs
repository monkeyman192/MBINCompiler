using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8B928220AD9352E2, NameHash = 0x6DB5B4A5FCDA4578)]
    public class TkBlackboardValueBool : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public bool Value;
    }
}

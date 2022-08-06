using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC2DEBEFE9B248E6D, NameHash = 0x45A1CDC5CD2FB6DC)]
    public class TkBlackboardDefaultValueFloat : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x08 */ public NMSString0x10 BlackboardKey;
        /* 0x18 */ public float DefaultValue;
    }
}

using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9F06630E398C2F3A, NameHash = 0x45A1CDC5CD2FB6DC)]
    public class TkBlackboardDefaultValueFloat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x14 */ public float DefaultValue;
    }
}

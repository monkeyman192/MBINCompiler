using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x963739480AD63E5B, NameHash = 0x8E91F497B8C8D2F3)]
    public class TkBlackboardDefaultValueVector : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardCategory BlackboardCategory;
        /* 0x08 */ public NMSString0x10 BlackboardKey;
        /* 0x20 */ public Vector3f DefaultValue;
    }
}

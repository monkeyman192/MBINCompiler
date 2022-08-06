using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8268CECB2F613CD, NameHash = 0x98D4CDA3D0370A4B)]
    public class TkBlackboardValueVector : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public Vector3f Value;
    }
}

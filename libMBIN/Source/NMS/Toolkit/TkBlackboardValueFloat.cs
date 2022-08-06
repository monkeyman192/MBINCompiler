using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF6204BFDEE40831C, NameHash = 0xBCB0673179FC6C44)]
    public class TkBlackboardValueFloat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public float Value;
    }
}

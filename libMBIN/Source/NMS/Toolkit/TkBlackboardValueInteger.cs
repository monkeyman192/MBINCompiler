using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x459905D7F693CB18, NameHash = 0x66E627EC0C57305C)]
    public class TkBlackboardValueInteger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public int Value;
    }
}

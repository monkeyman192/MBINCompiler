using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x333BDBCE8E81CE6E, NameHash = 0x9A99DA98FF7577EC)]
    public class TkBlackboardValueId : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public NMSString0x10 Value;
    }
}

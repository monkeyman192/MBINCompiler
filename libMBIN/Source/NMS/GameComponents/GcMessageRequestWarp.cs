using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x5080D27AD07FC174, NameHash = 0x2188DF2B7DDB1798)]
    public class GcMessageRequestWarp : NMSTemplate
    {
        public float Delay;
    }
}

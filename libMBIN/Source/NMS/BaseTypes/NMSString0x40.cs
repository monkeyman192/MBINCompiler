using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    public class NMSString0x40 : NMSTemplate
    {
        [NMS(Size = 0x40)]
        public string Value { get; set; }
    }
}

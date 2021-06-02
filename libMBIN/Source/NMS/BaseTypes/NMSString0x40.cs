using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x40, Alignment = 0x1)]
    public class NMSString0x40 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x40)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public NMSString0x40(string str)
        {
            this.Value = str;
        }

        public NMSString0x40() { }
    }
}

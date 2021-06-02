using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x80, Alignment = 0x1)]
    public class NMSString0x80 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x80)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public NMSString0x80(string str)
        {
            this.Value = str;
        }

        public NMSString0x80() { }
    }
}

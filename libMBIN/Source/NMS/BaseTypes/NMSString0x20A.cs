using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x20, Alignment = 0x8)]
    public class NMSString0x20A : NMSTemplate, INMSString
    {
        // This is a modified version of the NMSString0x20 which is aligned (hence the 'A' in the name) to 0x8.
        [NMS(Size = 0x20)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public NMSString0x20A(string str)
        {
            this.Value = str;
        }

        public NMSString0x20A() { }
    }
}

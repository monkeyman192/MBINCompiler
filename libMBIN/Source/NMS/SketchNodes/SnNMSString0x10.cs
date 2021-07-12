using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x4)]
    public class SnNMSString0x10 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x10)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public SnNMSString0x10(string str)
        {
            this.Value = str;
        }

        public SnNMSString0x10() { }

        public static implicit operator SnNMSString0x10(string str) => new SnNMSString0x10(str);
		public static implicit operator string ( SnNMSString0x10 str ) => str.Value;
	}
}

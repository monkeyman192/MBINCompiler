using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x400, Alignment = 0x1)]
    public class NMSString0x400 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x400)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public NMSString0x400(string str)
        {
            this.Value = str;
        }

        public NMSString0x400() { }

		public static implicit operator NMSString0x400 ( string str ) => new NMSString0x400(str);
		public static implicit operator string ( NMSString0x400 str ) => str.Value;
	}
}

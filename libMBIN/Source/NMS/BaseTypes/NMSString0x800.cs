using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x800, Alignment = 0x1)]
    public class NMSString0x800 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x800)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public NMSString0x800(string str)
        {
            this.Value = str;
        }

        public NMSString0x800() {}

		public static implicit operator NMSString0x800 ( string str ) => new NMSString0x800(str);
		public static implicit operator string ( NMSString0x800 str ) => str.Value;

		public int CompareTo ( INMSString RHS )
		{
			return string.Compare(StringValue(), RHS?.StringValue());
		}
		public bool Equals ( INMSString RHS )
		{
			return string.Equals(StringValue(), RHS?.StringValue());
		}
		public override string ToString ()
		{
			return StringValue();
		}
	}
}

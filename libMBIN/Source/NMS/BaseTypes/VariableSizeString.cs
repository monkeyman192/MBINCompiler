using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x1)]
    public class VariableSizeString : NMSTemplate, INMSString
	{
        public string Value;

		public string StringValue ()
		{
			return this.Value;
		}

		public VariableSizeString(string str)
		{
			this.Value = str;
		}

		public VariableSizeString() {}

		public static implicit operator VariableSizeString ( string str ) => new VariableSizeString(str);
		public static implicit operator string ( VariableSizeString str ) => str.Value;

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

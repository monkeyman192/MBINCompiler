﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x8)]
    public class NMSString0x10 : NMSTemplate, INMSString
    {
        [NMS(Size = 0x10)]
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        public NMSString0x10(string str)
        {
            this.Value = str;
        }

        public NMSString0x10() {}

        public static implicit operator NMSString0x10(string str) => new NMSString0x10(str);
		public static implicit operator string ( NMSString0x10 str ) => str.Value;

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

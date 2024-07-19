using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS
{
    [NMS(Size = 0x10, Alignment = 0x1)]
    public class OptionalVariableSizeString : NMSTemplate, INMSString
    {
        public string Value;

        public string StringValue()
        {
            return this.Value;
        }

        /// <summary>
        /// Returns the value held by this string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Value;
        }

        public OptionalVariableSizeString(string str)
        {
            this.Value = str;
        }

        public OptionalVariableSizeString() { }

        public static implicit operator OptionalVariableSizeString ( string str ) => new OptionalVariableSizeString { Value = str };
        public static implicit operator string ( OptionalVariableSizeString str ) => str.Value;
    }
}

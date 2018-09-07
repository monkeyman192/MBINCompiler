using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkEqualityEnum : NMSTemplate
    {
		public enum EqualityEnumEnum { Equal, Greater, Less, GreaterEqual, LessEqual }
		public EqualityEnumEnum EqualityEnum;
    }
}

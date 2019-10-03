using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xBC8ED0AD6D388727, NameHash = 0xF02414A33F663A2)]
    public class TkEqualityEnum : NMSTemplate
    {
		public enum EqualityEnumEnum { Equal, Greater, Less, GreaterEqual, LessEqual }
		public EqualityEnumEnum EqualityEnum;
    }
}

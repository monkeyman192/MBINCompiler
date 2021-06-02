using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xB0, GUID = 0x4C98B666C4454E5A, NameHash = 0x26AACC9ACEE360C5)]
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        public NMSString0x20 Name;
        public NMSString0x80 Model;

        public List<TkLSystemRestrictionData> Restrictions;
    }
}
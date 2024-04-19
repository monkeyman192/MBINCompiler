using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA11CB8562D934F93, NameHash = 0x26AACC9ACEE360C5)]
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        /* 0x00 */ public List<TkLSystemRestrictionData> Restrictions;
        /* 0x10 */ public NMSString0x80 Model;
        /* 0x90 */ public NMSString0x20 Name;
    }
}

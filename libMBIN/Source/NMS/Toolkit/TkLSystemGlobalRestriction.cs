using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA11CB8562D934F93, NameHash = 0x26AACC9ACEE360C5)]
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<TkLSystemRestrictionData> Restrictions;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x80 Model;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x20 Name;
    }
}

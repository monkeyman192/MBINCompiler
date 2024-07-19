using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4121383A4EE30676, NameHash = 0xDA33326)]
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString Model;
        [NMS(Index = 2)]
        /* 0x10 */ public List<TkLSystemRestrictionData> Restrictions;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20 Name;
    }
}

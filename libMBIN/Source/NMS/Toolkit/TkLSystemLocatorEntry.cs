using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7F504B8592F8DB, NameHash = 0x52984C1F)]
    public class TkLSystemLocatorEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString Model;
        [NMS(Index = 2)]
        /* 0x10 */ public List<TkLSystemRestrictionData> Restrictions;
        [NMS(Index = 1)]
        /* 0x20 */ public float Probability;
    }
}

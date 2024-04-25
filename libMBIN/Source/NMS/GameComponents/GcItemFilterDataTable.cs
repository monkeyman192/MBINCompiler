using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2AE69D0B86E8AA6F, NameHash = 0x35D65366C0A69C32)]
    public class GcItemFilterDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcItemFilterDataTableEntry> Filters;
    }
}

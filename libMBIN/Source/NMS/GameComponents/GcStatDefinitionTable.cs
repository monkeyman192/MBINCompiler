using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7448A429BE1CA64, NameHash = 0x2BFE1835E7B1EFEC)]
    public class GcStatDefinitionTable : NMSTemplate
    {
        /* 0x0 */ public List<GcStatDefinition> StatDefinitionTable;
    }
}

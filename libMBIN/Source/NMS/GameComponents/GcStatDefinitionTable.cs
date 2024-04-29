using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x148ED17B6EB32C93, NameHash = 0x2BFE1835E7B1EFEC)]
    public class GcStatDefinitionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatDefinition> StatDefinitionTable;
    }
}

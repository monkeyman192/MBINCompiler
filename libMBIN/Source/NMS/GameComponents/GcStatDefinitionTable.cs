using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC0FEA1A87D752F, NameHash = 0x2BFE1835E7B1EFEC)]
    public class GcStatDefinitionTable : NMSTemplate
    {
        public List<GcStatDefinition> StatDefinitionTable;
    }
}

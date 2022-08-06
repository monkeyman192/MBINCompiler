using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D3677593F04FAF6, NameHash = 0xE51761B21603792C)]
    public class GcCreatureGenerationWeightedList : NMSTemplate
    {
        // In the exe the datatypes are GcCreatureGenerationWeightedListEntry
        public List<GcCreatureGenerationWeightedListDomainEntry> Ground;
        public List<GcCreatureGenerationWeightedListDomainEntry> Air;
        public List<GcCreatureGenerationWeightedListDomainEntry> Cave;
        public List<GcCreatureGenerationWeightedListDomainEntry> Water;
    }
}

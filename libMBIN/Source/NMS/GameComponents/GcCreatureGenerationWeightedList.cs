using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F1226E9514AC6E8, NameHash = 0xE51761B21603792C)]
    public class GcCreatureGenerationWeightedList : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureGenerationWeightedListDomainEntry> Air;
        /* 0x10 */ public List<GcCreatureGenerationWeightedListDomainEntry> Cave;
        /* 0x20 */ public List<GcCreatureGenerationWeightedListDomainEntry> Ground;
        /* 0x30 */ public List<GcCreatureGenerationWeightedListDomainEntry> Water;
    }
}

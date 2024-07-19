using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2D634D4FBBCAD32, NameHash = 0x415A3043)]
    public class GcCreatureGenerationWeightedList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCreatureGenerationWeightedListDomainEntry> Air;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcCreatureGenerationWeightedListDomainEntry> Cave;
        [NMS(Index = 0)]
        /* 0x20 */ public List<GcCreatureGenerationWeightedListDomainEntry> Ground;
        [NMS(Index = 3)]
        /* 0x30 */ public List<GcCreatureGenerationWeightedListDomainEntry> Water;
    }
}

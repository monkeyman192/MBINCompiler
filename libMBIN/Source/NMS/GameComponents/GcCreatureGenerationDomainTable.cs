using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87BF5DF8DA96608C, NameHash = 0xCE47B2B5ED8374E1)]
    public class GcCreatureGenerationDomainTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcCreatureGenerationDomainEntry> Tables;
        [NMS(Index = 2)]
        /* 0x20 */ public float ChanceOfHemisphereLimit;
        [NMS(Index = 3)]
        /* 0x24 */ public int MaxToHemisphereLimit;
    }
}

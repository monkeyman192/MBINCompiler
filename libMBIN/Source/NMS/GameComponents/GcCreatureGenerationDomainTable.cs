using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97E9A6CD069E609A, NameHash = 0xCF295093)]
    public class GcCreatureGenerationDomainTable : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcCreatureGenerationDomainAdditionalEntries> AdditionalTables;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcCreatureGenerationDomainEntry> Tables;
        [NMS(Index = 2)]
        /* 0x30 */ public float ChanceOfHemisphereLimit;
        [NMS(Index = 3)]
        /* 0x34 */ public int MaxToHemisphereLimit;
    }
}

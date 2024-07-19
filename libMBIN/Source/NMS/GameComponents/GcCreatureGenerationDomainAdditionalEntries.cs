using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DDB92BD76483599, NameHash = 0x2A9BAE5)]
    public class GcCreatureGenerationDomainAdditionalEntries : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCreatureGenerationDomainEntry> Tables;
        [NMS(Index = 2)]
        /* 0x10 */ public float ChanceOfHemisphereLimit;
        [NMS(Index = 0)]
        /* 0x14 */ public int MaxTablesToAdd;
        [NMS(Index = 3)]
        /* 0x18 */ public int MaxToHemisphereLimit;
    }
}

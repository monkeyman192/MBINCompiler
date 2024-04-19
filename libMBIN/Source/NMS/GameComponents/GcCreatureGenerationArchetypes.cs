using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x696350FCE04E777F, NameHash = 0xCFE07CC2C3280EC)]
    public class GcCreatureGenerationArchetypes : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureGenerationDomainTable> AirArchetypes;
        /* 0x10 */ public List<GcCreatureGenerationDomainTable> CaveArchetypes;
        /* 0x20 */ public List<GcCreatureGenerationDomainTable> GroundArchetypes;
        /* 0x30 */ public List<GcCreatureGenerationDomainTable> WaterArchetypes;
    }
}

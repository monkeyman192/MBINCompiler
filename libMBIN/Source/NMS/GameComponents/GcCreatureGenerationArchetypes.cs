using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3F0C9CD0EDAE893, NameHash = 0xCFE07CC2C3280EC)]
    public class GcCreatureGenerationArchetypes : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCreatureGenerationDomainTable> AirArchetypes;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcCreatureGenerationDomainTable> CaveArchetypes;
        [NMS(Index = 0)]
        /* 0x20 */ public List<GcCreatureGenerationDomainTable> GroundArchetypes;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcCreatureGenerationDomainTable> WaterArchetypes;
    }
}

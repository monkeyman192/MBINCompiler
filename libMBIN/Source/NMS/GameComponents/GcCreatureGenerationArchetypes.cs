using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B55D7152697FB96, NameHash = 0x0CFE07CC2C3280EC)]
    public class GcCreatureGenerationArchetypes : NMSTemplate
    {
        public List<GcCreatureGenerationDomainTable> GroundArchetypes;
        public List<GcCreatureGenerationDomainTable> AirArchetypes;
        public List<GcCreatureGenerationDomainTable> WaterArchetypes;
        public List<GcCreatureGenerationDomainTable> CaveArchetypes;
    }
}

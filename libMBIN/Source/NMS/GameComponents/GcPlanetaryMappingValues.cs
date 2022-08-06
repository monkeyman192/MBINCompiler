using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDD90D922CF9002F, NameHash = 0x314960F4DFCC0B34)]
    public class GcPlanetaryMappingValues : NMSTemplate
    {
        public GcPlanetSize PlanetSize;
        public ushort SectionPerSide;
        public ushort PolesPerSection;
    }
}

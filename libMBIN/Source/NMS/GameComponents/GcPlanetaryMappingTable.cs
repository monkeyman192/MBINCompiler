using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5DC5D4E29E7A9C7, NameHash = 0xB47263D5F2CB7D5D)]
    public class GcPlanetaryMappingTable : NMSTemplate
    {
        [NMS(Size = 0x4)]
        public GcPlanetaryMappingValues[] MappingInfo;
    }
}

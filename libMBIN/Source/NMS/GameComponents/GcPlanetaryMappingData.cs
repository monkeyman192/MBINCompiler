using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x280EEEC7CABD5533, NameHash = 0x4F9FD28121A054A4)]
    public class GcPlanetaryMappingData : NMSTemplate
    {
        /* 0x00 */ public List<GcPlanetSectionData> SectionsData;
        /* 0x10 */ public ulong UA;
    }
}

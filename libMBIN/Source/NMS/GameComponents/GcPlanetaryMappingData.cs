using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53549AB5D0471188, NameHash = 0x4F9FD28121A054A4)]
    public class GcPlanetaryMappingData : NMSTemplate
    {
        // This is the other way around in the exe and save file, but this way around in the default save??
        public List<GcPlanetSectionData> SectionsData;
        public ulong UA;
    }
}

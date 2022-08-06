using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC84EB4CAF3DC71D2, NameHash = 0x6110D9A6BE68E9B8)]
    public class GcPetEggSpeciesOverrideTable : NMSTemplate
    {
        public List<GcPetEggSpeciesOverrideData> SpeciesOverrides;
    }
}

using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC798541B9F89176C, NameHash = 0x6110D9A6BE68E9B8)]
    public class GcPetEggSpeciesOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetEggSpeciesOverrideData> SpeciesOverrides;
    }
}

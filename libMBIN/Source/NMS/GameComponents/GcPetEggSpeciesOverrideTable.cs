using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xECCEEBE371A1542E, NameHash = 0x9FB1DE29)]
    public class GcPetEggSpeciesOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetEggSpeciesOverrideData> SpeciesOverrides;
    }
}
